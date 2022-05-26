using System;
using System.IO.Ports;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Documents;
using InverterDriver.product;

namespace InverterDriver
{
    public partial class Form1 : Form
    {
        private byte[] inverterData = new byte[64]; // Sending data
        List<DateTimePicker> dateTimePickers = new List<DateTimePicker>();
        List<TextBox> compSpeedTextBoxes = new List<TextBox>();
        DateTime startTime;
        DateTime finishTime;
        string logFileName = "temp.csv";
        readonly string saveDir = "D:\\inverter driver log\\";


        // Why c# doesn't have local static variables?
        private int receivedByteCount = 0;
        static private int expectedBytes = 128;
        ResponseData responseData = new ResponseData();
        //private byte[] receivedBytes = new byte[expectedBytes];
        String receivedDataString = "";
        
        /* Helper Functions */
        private void initializeInverterData()
        {
            for (int i = 0; i < inverterData.Length; i++)
            {
                inverterData[i] = Convert.ToByte(0);
            }
            inverterData[0] = 0xFA; // HEADER BYTE 1
            inverterData[1] = 0xFD; // HEADER BYTE 2
        }
        
        private void setDefaultSettings()
        {
            // initialize
            cbxMasterCtrlSw.SelectedIndex = 0;
            cbxOutFanCtrl.SelectedIndex = 1;
            CbxCompSwCtrl.SelectedIndex = 1;
            txtCompTargetSpeed.Text = "1500";
            txtOutFanTargetSpeed.Text = "1500";
            cbxBaudrate.SelectedIndex = 0;
            cbxDatabits.SelectedIndex = 3;
            cbxParity.SelectedIndex = 0;
            cbxStopbits.SelectedIndex = 0;
            foreach (var serialport in SerialPort.GetPortNames())
            {
                cbxSerialPort.Items.Add(serialport);
            }

            // select
            try { cbxSerialPort.SelectedIndex = 0; }
            catch (Exception) { MessageBox.Show("Herhangi bağlantı noktası bulunamadı.\nProgramı yeniden başlatın."); }
        }
        
        private void adjustStatusLabel()
        {
            labelStatus.Left = (panelStatus.Width / 2) - (labelStatus.Width / 2);
            labelStatus.Top = (panelStatus.Height / 2) - (labelStatus.Height / 2);
        }

        delegate void commBoxReceivedDataCallback();
        private void commBoxReceivedData()
        {
            if(commBox.InvokeRequired)
            {
                commBoxReceivedDataCallback d = new commBoxReceivedDataCallback(commBoxReceivedData);
                Invoke(d);
            } else
            {
                commBox.SelectionColor = Color.Red;
                commBox.AppendText("<- ");
                commBox.SelectionColor = Color.MediumOrchid;
                commBox.AppendText(receivedDataString + "\r\n\r\n");
                receivedDataString = "";
                Console.WriteLine("");

                /* log */
                var file = System.IO.File.Open(saveDir + logFileName, System.IO.FileMode.Append);
                file.Write(UTF8Encoding.UTF8.GetBytes(receivedDataString), 0, UTF8Encoding.UTF8.GetByteCount(receivedDataString));
                file.Close();
            }
        }

        private void EnableControlSettings(bool isEnable)
        {
            cbxMasterCtrlSw.Enabled = isEnable;
            cbxOutFanCtrl.Enabled = isEnable;
            CbxCompSwCtrl.Enabled = isEnable;
            txtCompTargetSpeed.Enabled = isEnable;
            txtOutFanTargetSpeed.Enabled = isEnable;
        }
        
        private void EnableProgramSelect(bool isEnable)
        {
            defaultProgram.Enabled = isEnable;
            setProgram.Enabled = isEnable;
        }

        private void EnableProgramSettings(bool isEnable)
        {
            foreach(var datetimepicker in dateTimePickers)
            {
                datetimepicker.Enabled = isEnable;
            }
            foreach (var textbox in compSpeedTextBoxes)
            {
                textbox.Enabled = isEnable;
            }
            txtProgramCount.Enabled = isEnable;
            btnProgramAdd.Enabled = isEnable;
        }

        private void SetTxChecksum()
        {
            byte checksum = 0;
            for (int i = 0; i < inverterData.Length - 1; i++)
            {
                checksum += inverterData[i];
            }
            inverterData[63] = checksum;
        }
        
        private void WriteToSerial()
        {
            SetTxChecksum();
            serialPort.Write(inverterData, 0, inverterData.Length);

            commBox.SelectionColor = Color.Blue;
            commBox.AppendText("-> ");
            commBox.SelectionColor = Color.LightGreen;
            //var file = System.IO.File.Open("D:\\inverterdriverlog\\" + logFileName, System.IO.FileMode.Append);
            //file.Write(UTF8Encoding.UTF8.GetBytes("->,"), 0, UTF8Encoding.UTF8.GetByteCount("->,"));
            foreach (var item in inverterData)
            {
                var hexStr = item.ToString("X2");
                Console.Write(hexStr + " ");
                commBox.AppendText(hexStr + " ");
                //file.Write(UTF8Encoding.UTF8.GetBytes(hexStr + ","), 0, UTF8Encoding.UTF8.GetByteCount(hexStr + ","));
            }
            //file.Write(UTF8Encoding.UTF8.GetBytes("\r\n"), 0, UTF8Encoding.UTF8.GetByteCount("\r\n"));
            //file.Close();
            Console.WriteLine(" ");
            commBox.AppendText("\r\n\r\n");
        }
        
        private void DefaultProgramWrite()
        {
            SetCompTargetSpeed(Convert.ToInt32(txtCompTargetSpeed.Text));
            WriteToSerial();
        }
        
        private void SetProgramWrite()
        {
            var diff = DateTime.Now.Subtract(startTime);
            //Console.WriteLine("Diff: " + diff.TotalSeconds);
            double totalProgramSecondsTime = 0;
            foreach (var datetimepicker in dateTimePickers)
            {
                totalProgramSecondsTime += (datetimepicker.Value.Hour * 3600 + datetimepicker.Value.Minute * 60 + datetimepicker.Value.Second);
                //Console.WriteLine(datetimepicker.Value);
                if (diff.TotalSeconds < totalProgramSecondsTime)
                {
                    //Console.WriteLine(inverterData[4]);
                    try
                    {
                        SetCompTargetSpeed(Convert.ToInt32(compSpeedTextBoxes[dateTimePickers.IndexOf(datetimepicker)].Text));
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        SetCompTargetSpeed(0);
                    }
                    
                    break;
                }
            }
            WriteToSerial();
        }

        private void SetCompTargetSpeed(int speed)
        {
            inverterData[4] = Convert.ToByte(speed & 0xFF);         // Low byte
            inverterData[5] = Convert.ToByte((speed >> 8) & 0xFF);  // High byte
        }

        /* Program events */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initializeInverterData();
            setDefaultSettings();
            btnConnect.Text = "Connect";
            btnConnect.BackColor = Color.Green;
            labelStatus.Text = "Disconnected";
            panelStatus.BackColor = Color.Red;
            adjustStatusLabel();

            commBox.SelectionFont = new Font("Tahoma", 12, FontStyle.Underline);
            commBox.SelectionAlignment = HorizontalAlignment.Center;
            
            commBox.AppendText("Communication Window");
            commBox.AppendText("\r\n\r\n");

            dataGridView1.Rows.Add("Status", "");
            dataGridView1.Rows.Add("Function", "");
            dataGridView1.Rows.Add("Compressor speed", 0);
            dataGridView1.Rows.Add("Fan speed", 0);
            dataGridView1.Rows.Add("Target Fan speed", 0);
            dataGridView1.Rows.Add("Target Compressor speed", 0);

            dataGridView1.Height = dataGridView1.RowTemplate.Height * (dataGridView1.Rows.Count + 1);

            clockLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            // one ring to rule them all
            defaultProgram_Click(sender, e);

            labelLogPath.Text = $"Çalıştırılan programın log'u {saveDir} klasörüne kaydedilmektedir.";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen) { MessageBox.Show("Serial port is not open."); return; }

            if (!programTimer.Enabled)
            {
                if (!System.IO.File.Exists(saveDir))
                {
                    System.IO.Directory.CreateDirectory(saveDir);
                }
                logFileName = DateTime.Now.ToString("dd.MM.yyy-HH.mm") + ".csv";
                labelTimer.Text = "00:00:00";
                programTimer.Enabled = true;
                btnSend.Text = "Stop sending";
                btnSend.BackColor = Color.Red;
                EnableControlSettings(false);
                EnableProgramSettings(false);
                EnableProgramSelect(false);

                startTime = DateTime.Now;
                labelStartTime.Text = startTime.ToString("dd.MM.yyyy HH:mm");
                //labelStartTime.Text = startTime.ToString("HH:mm");

                if (setProgram.Checked)
                {
                    int remainingMinutes = 0;
                    foreach(var time in dateTimePickers)
                    {
                        remainingMinutes += (time.Value.Minute + time.Value.Hour * 60);
                    }
                    //labelFinishTime.Text = TimeSpan.FromMinutes(remainingMinutes).ToString(@"hh\:mm");
                    finishTime = startTime.Add(TimeSpan.FromMinutes(remainingMinutes));
                    labelFinishTime.Text = finishTime.ToString("dd.MM.yyyy HH:mm");
                    //labelFinishTime.Text = finishTime.ToString("HH:mm");
                }
                else
                {
                    finishTime = DateTime.MaxValue;
                    labelFinishTime.Text = "∞";
                }
            }
            else
            {
                programTimer.Enabled = false;
                btnSend.Text = "Start sending";
                btnSend.BackColor = Color.LightGreen;
                if (defaultProgram.Checked)
                {
                    EnableControlSettings(true);
                }
                else
                {
                    EnableProgramSettings(true);
                }
                EnableProgramSelect(true);
            }
        }

        private void cbxMasterCtrlSw_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxMasterCtrlSw.Text == "On")
            {
                inverterData[2] = 1;
            } else if ( cbxMasterCtrlSw.Text == "Off" )
            {
                inverterData[2] = 0;
            } else
            {
                inverterData[2] = 0;
            }
            
        }

        private void CbxCompSwCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CbxCompSwCtrl.Text == "0: Do not control")
            {
                inverterData[3] = 0;
            } else if (CbxCompSwCtrl.Text == "1: On")
            {
                inverterData[3] = 1;
            } else if (CbxCompSwCtrl.Text == "2: Off")
            {
                inverterData[3] = 2;
            } else
            {
                inverterData[3] = 0;
            }
        }

        private void txtCompTargetSpeed_TextChanged(object sender, EventArgs e)
        {
            int speed;
            try
            {
                speed = Convert.ToInt32(txtCompTargetSpeed.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Geçerli kompresör target speed değeri giriniz.");
                return;
            }
            SetCompTargetSpeed(speed);
        }

        private void cbxOutFanCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxOutFanCtrl.Text == "0: Do not control")
            {
                inverterData[7] = 0;
            }
            else if (cbxOutFanCtrl.Text == "1: On")
            {
                inverterData[7] = 1;
            }
            else if (cbxOutFanCtrl.Text == "2: Off")
            {
                inverterData[7] = 2;
            }
            else
            {
                inverterData[7] = 0;
            }
        }

        private void txtOutFanTargetSpeed_TextChanged(object sender, EventArgs e)
        {
            UInt16 speed;
            try
            {
                speed = Convert.ToUInt16(txtOutFanTargetSpeed.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Geçerli outdoor fan target speed değeri giriniz.");
                return;
            }
            inverterData[8] = Convert.ToByte(speed & 0xFF);         // Low byte
            inverterData[9] = Convert.ToByte((speed >> 8) & 0xFF);  // High byte
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int bytes = serialPort.BytesToRead;
            receivedByteCount += bytes;
            byte[] buffer = new byte[bytes];
            serialPort.Read(buffer, 0, bytes);
           
            Console.Write(BitConverter.ToString(buffer));
            Console.Write("-");
            foreach (var item in buffer)
            {
                receivedDataString += item.ToString("X2") + " ";
            }
            /*
            if (receivedByteCount >= expectedBytes)
            {
                receivedByteCount = 0;
                string[] x = receivedDataString.Split(' ');
                
                List<int> intList = new List<int>();
                foreach (string item in x)
                {
                    if (item != "")
                    {
                        intList.Add(Convert.ToInt32(item, 16));
                    }
                }
                responseData.responseData = intList.SelectMany(i => BitConverter.GetBytes(i)).ToArray();
                commBoxReceivedData();
            }
            */
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                serialPort.PortName = cbxSerialPort.Text;
                serialPort.BaudRate = Convert.ToInt32(cbxBaudrate.Text);
                serialPort.DataBits = Convert.ToInt32(cbxDatabits.Text);
                serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), cbxParity.Text);
                serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbxStopbits.Text);
                try { serialPort.Open(); }
                catch (Exception ex) { 
                    MessageBox.Show(ex.Message);
                    return;
                }
                cbxSerialPort.Enabled = false;
                cbxBaudrate.Enabled = false;
                cbxDatabits.Enabled = false;
                cbxParity.Enabled = false;
                cbxStopbits.Enabled = false;
                btnConnect.Text = "Disconnect";
                btnConnect.BackColor = Color.Red;
                labelStatus.Text = "Connected";
                panelStatus.BackColor = Color.LimeGreen;
                adjustStatusLabel();
            }
            else if (serialPort.IsOpen && programTimer.Enabled) { MessageBox.Show("First stop sending data.", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {
                serialPort.Close();
                cbxSerialPort.Enabled = true;
                cbxBaudrate.Enabled = true;
                cbxDatabits.Enabled = true;
                cbxParity.Enabled = true;
                cbxStopbits.Enabled = true;
                btnConnect.Text = "Connect";
                btnConnect.BackColor = Color.Green;
                labelStatus.Text = "Disconnected";
                panelStatus.BackColor = Color.Red;
                adjustStatusLabel();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.google.com");
        }

        private void btnClearScreen_Click(object sender, EventArgs e)
        {
            commBox.Clear();
            commBox.SelectionFont = new Font("Tahoma", 12, FontStyle.Underline);
            commBox.SelectionAlignment = HorizontalAlignment.Center;

            commBox.AppendText("Communication Window");
            commBox.AppendText("\r\n\r\n");
        }

        private void commBox_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoScroll.Checked)
            {
                commBox.SelectionStart = commBox.Text.Length;
                commBox.ScrollToCaret();
            }
        }

        private void commBoxHelpBtn_MouseHover(object sender, EventArgs e)
        {
            commBoxHelpBtn.BackColor = Color.LightGray;
            toolTip1.Show("hi", commBoxHelpBtn);
            
        }

        private void commBoxHelpBtn_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(commBoxHelpBtn);
            commBoxHelpBtn.BackColor = Color.Transparent;
        }

        private void programTimer_Tick(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen) 
            { 
                programTimer.Enabled = false; 
                MessageBox.Show("Serial port is not open."); 
                return; 
            }

            /* Write to Serial Port & Communication Box */
            if (defaultProgram.Checked)
            {
                DefaultProgramWrite();
            } else if (setProgram.Checked)
            {
                if (dateTimePickers.Count == 0)
                {
                    btnSend_Click(sender, e);
                    MessageBox.Show("En az bir program eklemelisiniz.");
                    return;
                }
                SetProgramWrite();
            }
            /*
            byte checksum = 0;
            for (int i = 0; i < inverterData.Length - 1; i++)
            {
                checksum += inverterData[i];
            }
            inverterData[63] = checksum;
            serialPort.Write(inverterData, 0, inverterData.Length);
            
            commBox.SelectionColor = Color.Blue;
            commBox.AppendText("-> ");
            commBox.SelectionColor = Color.LightGreen;
            foreach (var item in inverterData)
            {
                Console.Write(item.ToString("X2") + " ");
                commBox.AppendText(item.ToString("X2") + " ");
            }
            Console.WriteLine(" ");
            commBox.AppendText("\r\n\r\n");
            */
            
            /* Received Data & Communication Box */
            receivedByteCount = 0;
            string[] x = receivedDataString.Split(' ');

            List<int> intList = new List<int>();
            foreach (string item in x)
            {
                if (item != "")
                {
                    intList.Add(Convert.ToInt32(item, 16));
                }
            }
            
            byte receivedChecksum = 0;
            for (int i = 0; i < intList.Count-1; i++)
            {
                receivedChecksum += Convert.ToByte(intList[i]);
            }
            if (intList.Count != 0 && receivedChecksum == Convert.ToByte(intList[intList.Count - 1])) 
            { 
                for (int i = 0; i < intList.Count; i++)
                {
                    try
                    {
                        responseData.responseData[i] = Convert.ToByte(intList[i]);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            commBoxReceivedData();

            /* Status Table */
            try
            {
                dataGridView1[1, 0].Value = responseData.GetSystemStatus();
                dataGridView1[1, 1].Value = responseData.GetFunctionStatus();
                dataGridView1[1, 2].Value = responseData.GetOutdoorFanActualSpeed();
                dataGridView1[1, 3].Value = responseData.GetCompressorActualSpeed();
                dataGridView1[1, 4].Value = responseData.GetOutdoorFanTargetSpeed();
                dataGridView1[1, 5].Value = responseData.GetCompressorTargetSpeed();
                dataGridView1.Show();
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void generalTimer_Tick(object sender, EventArgs e)
        {
            /* Timer Label */
            if (programTimer.Enabled)
            {
                string[] hms = labelTimer.Text.Split(':');
                int h = Convert.ToInt32(hms[0]);
                int m = Convert.ToInt32(hms[1]);
                int s = Convert.ToInt32(hms[2]);

                s++;
                if (s >= 60) { s = 0; m++; }
                if (m >= 60) { m = 0; h++; }
                labelTimer.Text = h.ToString("00") + ":" + m.ToString("00") + ":" + s.ToString("00");
            }

            clockLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void defaultProgram_Click(object sender, EventArgs e)
        {
            defaultProgram.Checked = true;
            setProgram.Checked = false;
            EnableControlSettings(true);
            EnableProgramSettings(false);
        }

        private void setProgram_Click(object sender, EventArgs e)
        {
            setProgram.Checked = true;
            defaultProgram.Checked = false;
            EnableControlSettings(false);
            EnableProgramSettings(true);
        }

        private void btnProgramAdd_Click(object sender, EventArgs e)
        {
            int programCount;
            int maxProgramCount = 5;
            try
            {
                programCount = Convert.ToInt32(txtProgramCount.Text);
            }
            catch (Exception)
            {
                MessageBox.Show($"Please enter number between ({0} - {maxProgramCount}].");
                return;
            }

            if (programCount < 0 || programCount > maxProgramCount) 
            {
                MessageBox.Show($"Please enter number between ({0} - {maxProgramCount}].");
                return;
            }

            if (programCount < dateTimePickers.Count)
            {
                for(int i = dateTimePickers.Count; i>programCount; i--)
                {
                    Controls.Remove(dateTimePickers[i - 1]);
                    dateTimePickers.RemoveAt(i - 1);
                    Controls.Remove(compSpeedTextBoxes[i - 1]);
                    compSpeedTextBoxes.RemoveAt(i - 1);
                }
            }
            else
            {
                for (int i = 0; i < programCount; i++)
                {
                    dateTimePickers.Add(new DateTimePicker());
                    dateTimePickers[i].Format = DateTimePickerFormat.Custom;
                    dateTimePickers[i].CustomFormat = "HH:mm";
                    dateTimePickers[i].ShowUpDown = true;
                    dateTimePickers[i].Width = clockLabel.Width/2;
                    dateTimePickers[i].Height = 22;
                    dateTimePickers[i].Value = DateTime.Parse("00:00");
                    Controls.Add(dateTimePickers[i]);
                    dateTimePickers[i].Location = new Point(clockLabel.Location.X, clockLabel.Location.Y + 30 + i * 22);

                    compSpeedTextBoxes.Add(new TextBox());
                    compSpeedTextBoxes[i].Width = clockLabel.Width / 2;
                    compSpeedTextBoxes[i].Height = 22;
                    compSpeedTextBoxes[i].Text = "0";
                    Controls.Add(compSpeedTextBoxes[i]);
                    compSpeedTextBoxes[i].Location = new Point(clockLabel.Location.X + clockLabel.Width / 2, clockLabel.Location.Y + 30 + i * 22);
                }
            }

        }

        private void txtProgramCount_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnProgramAdd_Click(sender, e);
            }
        }
    }
}
