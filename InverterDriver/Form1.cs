using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace InverterDriver
{
    public partial class Form1 : Form
    {
        private byte[] inverterData = new byte[64];
        
        // Why c# doesn't have local static variables?
        private int receivedByteCount = 0;
        static private int expectedBytes = 128;
        private byte[] receivedBytes = new byte[expectedBytes];
        
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
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen) { MessageBox.Show("Serial port is not open."); return; }

            /* Normal calisma algoritmasi */

            // Checksum
            byte checksum = 0;
            for (int i = 0; i < inverterData.Length-1; i++)
            {
                checksum += inverterData[i];
            }
            inverterData[63] = checksum;
            foreach (var item in inverterData)
            {
                Console.Write(item.ToString("X2") + " ");
            }
            Console.WriteLine(" ");
            serialPort.Write(inverterData, 0, inverterData.Length);

            /* kartı çalıştıran data */
            /*
            byte checksum = 0;
            var sendData = new byte[65] { 0xFA, 0xFC, 0x01, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x3C, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            foreach (var item in sendData)
            {
                checksum += item;
            }
            sendData[sendData.Length - 1] = checksum;
            serialPort.Write(sendData, 0, sendData.Length);
            */
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
            
            /*
            foreach (var item in buffer)
            {
                Console.Write(item.ToString("X2") + " ");
                receivedBytes[receivedByteCount] = item;
                receivedByteCount++;
                if (receivedByteCount >= expectedBytes) {
                    receivedByteCount = 0;
                    Console.WriteLine("");
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        listBox1.Items.Add(BitConverter.ToString(receivedBytes));
                    }));
                }
            }*/
            
            
            Console.Write(BitConverter.ToString(buffer));
            Console.Write("-");
            if(receivedByteCount >= expectedBytes)
            {
                receivedByteCount = 0;
                Console.WriteLine("");
            }
            

            if (checkBoxAutoScroll.Checked && listBox1.Items.Count > 0)
            {
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
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
    }
}
