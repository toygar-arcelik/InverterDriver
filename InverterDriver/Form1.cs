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
        bool sendFlag = false;
        private byte[] inverterData = new byte[64]; // Sending data
        
        // Why c# doesn't have local static variables?
        private int receivedByteCount = 0;
        static private int expectedBytes = 128;
        ResponseData responseData = new ResponseData();
        //private byte[] receivedBytes = new byte[expectedBytes];
        String receivedDataString = "";
        
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

            }
        }


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
            dataGridView1.Rows.Add("Motor speed", 0);
            dataGridView1.Rows.Add("Fan speed", 0);
            dataGridView1.Rows.Add("target Fan speed", 0);
            dataGridView1.Rows.Add("target motor speed", 0);

            dataGridView1.Height = dataGridView1.RowTemplate.Height * (dataGridView1.Rows.Count + 1);


        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen) { MessageBox.Show("Serial port is not open."); return; }

            if (!timer1.Enabled)
            {
                labelTimer.Text = "00:00:00";
                timer1.Enabled = true;
                btnSend.Text = "Stop sending";
                btnSend.BackColor = Color.Red;
                cbxMasterCtrlSw.Enabled = false;
                cbxOutFanCtrl.Enabled = false;
                CbxCompSwCtrl.Enabled = false;
                txtCompTargetSpeed.Enabled = false;
                txtOutFanTargetSpeed.Enabled = false;
            }
            else
            {
                timer1.Enabled = false;
                btnSend.Text = "Start sending";
                btnSend.BackColor = Color.LightGreen;
                cbxMasterCtrlSw.Enabled = true;
                cbxOutFanCtrl.Enabled = true;
                CbxCompSwCtrl.Enabled = true;
                txtCompTargetSpeed.Enabled = true;
                txtOutFanTargetSpeed.Enabled = true;
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
            UInt16 speed;
            try
            {
                speed = Convert.ToUInt16(txtCompTargetSpeed.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Geçerli kompresör target speed değeri giriniz.");
                return;
            }
            inverterData[4] = Convert.ToByte(speed & 0xFF);         // Low byte
            inverterData[5] = Convert.ToByte((speed >> 8) & 0xFF);  // High byte
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
            else if (serialPort.IsOpen && timer1.Enabled) { MessageBox.Show("First stop sending data.", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen) 
            { 
                timer1.Enabled = false; 
                MessageBox.Show("Serial port is not open."); 
                return; 
            }

            /* Write to Serial Port & Communication Box */
            byte checksum = 0;
            for (int i = 0; i < inverterData.Length - 1; i++)
            {
                checksum += inverterData[i];
            }
            inverterData[63] = checksum;

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

            serialPort.Write(inverterData, 0, inverterData.Length);

            /* Timer Label */
            string[] hms = labelTimer.Text.Split(':');
            int h = Convert.ToInt32(hms[0]);
            int m = Convert.ToInt32(hms[1]);
            int s = Convert.ToInt32(hms[2]);

            s++;
            if (s >= 60) { s = 0; m++; }
            if (m >= 60) { m = 0; h++; }
            labelTimer.Text = h.ToString("00") + ":" + m.ToString("00") + ":" + s.ToString("00");

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
    }
}
