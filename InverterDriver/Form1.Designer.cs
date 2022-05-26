namespace InverterDriver
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxMasterCtrlSw = new System.Windows.Forms.ComboBox();
            this.CbxCompSwCtrl = new System.Windows.Forms.ComboBox();
            this.cbxOutFanCtrl = new System.Windows.Forms.ComboBox();
            this.cbxSerialPort = new System.Windows.Forms.ComboBox();
            this.txtCompTargetSpeed = new System.Windows.Forms.TextBox();
            this.txtOutFanTargetSpeed = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxBaudrate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxDatabits = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxParity = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxStopbits = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.commBox = new System.Windows.Forms.RichTextBox();
            this.checkBoxAutoScroll = new System.Windows.Forms.CheckBox();
            this.btnClearScreen = new System.Windows.Forms.Button();
            this.commBoxHelpBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnProgramAdd = new System.Windows.Forms.Button();
            this.programTimer = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.infoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clockLabel = new System.Windows.Forms.Label();
            this.generalTimer = new System.Windows.Forms.Timer(this.components);
            this.defaultProgram = new System.Windows.Forms.RadioButton();
            this.setProgram = new System.Windows.Forms.RadioButton();
            this.txtProgramCount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelFinishTime = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelLogPath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Master Control Switch:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Compressor Switch Control:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Compressor Target Speed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Outdoor Fan Control:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Outdoor Fan Target Speed:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Serial Port:";
            // 
            // cbxMasterCtrlSw
            // 
            this.cbxMasterCtrlSw.FormattingEnabled = true;
            this.cbxMasterCtrlSw.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.cbxMasterCtrlSw.Location = new System.Drawing.Point(362, 59);
            this.cbxMasterCtrlSw.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMasterCtrlSw.Name = "cbxMasterCtrlSw";
            this.cbxMasterCtrlSw.Size = new System.Drawing.Size(68, 21);
            this.cbxMasterCtrlSw.TabIndex = 6;
            this.cbxMasterCtrlSw.SelectedIndexChanged += new System.EventHandler(this.cbxMasterCtrlSw_SelectedIndexChanged);
            // 
            // CbxCompSwCtrl
            // 
            this.CbxCompSwCtrl.FormattingEnabled = true;
            this.CbxCompSwCtrl.Items.AddRange(new object[] {
            "0: Do not control",
            "1: On",
            "2: Off"});
            this.CbxCompSwCtrl.Location = new System.Drawing.Point(362, 91);
            this.CbxCompSwCtrl.Margin = new System.Windows.Forms.Padding(2);
            this.CbxCompSwCtrl.Name = "CbxCompSwCtrl";
            this.CbxCompSwCtrl.Size = new System.Drawing.Size(68, 21);
            this.CbxCompSwCtrl.TabIndex = 7;
            this.CbxCompSwCtrl.SelectedIndexChanged += new System.EventHandler(this.CbxCompSwCtrl_SelectedIndexChanged);
            // 
            // cbxOutFanCtrl
            // 
            this.cbxOutFanCtrl.FormattingEnabled = true;
            this.cbxOutFanCtrl.Items.AddRange(new object[] {
            "0: Do not control",
            "1: On",
            "2: Off"});
            this.cbxOutFanCtrl.Location = new System.Drawing.Point(362, 157);
            this.cbxOutFanCtrl.Margin = new System.Windows.Forms.Padding(2);
            this.cbxOutFanCtrl.Name = "cbxOutFanCtrl";
            this.cbxOutFanCtrl.Size = new System.Drawing.Size(68, 21);
            this.cbxOutFanCtrl.TabIndex = 8;
            this.cbxOutFanCtrl.SelectedIndexChanged += new System.EventHandler(this.cbxOutFanCtrl_SelectedIndexChanged);
            // 
            // cbxSerialPort
            // 
            this.cbxSerialPort.FormattingEnabled = true;
            this.cbxSerialPort.Location = new System.Drawing.Point(99, 184);
            this.cbxSerialPort.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSerialPort.Name = "cbxSerialPort";
            this.cbxSerialPort.Size = new System.Drawing.Size(68, 21);
            this.cbxSerialPort.TabIndex = 9;
            // 
            // txtCompTargetSpeed
            // 
            this.txtCompTargetSpeed.Location = new System.Drawing.Point(362, 125);
            this.txtCompTargetSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompTargetSpeed.Name = "txtCompTargetSpeed";
            this.txtCompTargetSpeed.Size = new System.Drawing.Size(68, 20);
            this.txtCompTargetSpeed.TabIndex = 10;
            this.txtCompTargetSpeed.TextChanged += new System.EventHandler(this.txtCompTargetSpeed_TextChanged);
            // 
            // txtOutFanTargetSpeed
            // 
            this.txtOutFanTargetSpeed.Location = new System.Drawing.Point(362, 185);
            this.txtOutFanTargetSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutFanTargetSpeed.Name = "txtOutFanTargetSpeed";
            this.txtOutFanTargetSpeed.Size = new System.Drawing.Size(68, 20);
            this.txtOutFanTargetSpeed.TabIndex = 11;
            this.txtOutFanTargetSpeed.TextChanged += new System.EventHandler(this.txtOutFanTargetSpeed_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.LightGreen;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.Location = new System.Drawing.Point(258, 283);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(105, 25);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "Send Settings";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(860, 396);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // cbxBaudrate
            // 
            this.cbxBaudrate.FormattingEnabled = true;
            this.cbxBaudrate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200"});
            this.cbxBaudrate.Location = new System.Drawing.Point(99, 58);
            this.cbxBaudrate.Margin = new System.Windows.Forms.Padding(2);
            this.cbxBaudrate.Name = "cbxBaudrate";
            this.cbxBaudrate.Size = new System.Drawing.Size(68, 21);
            this.cbxBaudrate.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Baudrate: ";
            // 
            // cbxDatabits
            // 
            this.cbxDatabits.FormattingEnabled = true;
            this.cbxDatabits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbxDatabits.Location = new System.Drawing.Point(99, 90);
            this.cbxDatabits.Margin = new System.Windows.Forms.Padding(2);
            this.cbxDatabits.Name = "cbxDatabits";
            this.cbxDatabits.Size = new System.Drawing.Size(68, 21);
            this.cbxDatabits.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 93);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Databits: ";
            // 
            // cbxParity
            // 
            this.cbxParity.FormattingEnabled = true;
            this.cbxParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark",
            "Space"});
            this.cbxParity.Location = new System.Drawing.Point(99, 119);
            this.cbxParity.Margin = new System.Windows.Forms.Padding(2);
            this.cbxParity.Name = "cbxParity";
            this.cbxParity.Size = new System.Drawing.Size(68, 21);
            this.cbxParity.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 122);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Parity: ";
            // 
            // cbxStopbits
            // 
            this.cbxStopbits.FormattingEnabled = true;
            this.cbxStopbits.Items.AddRange(new object[] {
            "One",
            "None",
            "Two",
            "OnePointFive"});
            this.cbxStopbits.Location = new System.Drawing.Point(99, 152);
            this.cbxStopbits.Margin = new System.Windows.Forms.Padding(2);
            this.cbxStopbits.Name = "cbxStopbits";
            this.cbxStopbits.Size = new System.Drawing.Size(68, 21);
            this.cbxStopbits.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 154);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Stopbits: ";
            // 
            // btnConnect
            // 
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Location = new System.Drawing.Point(62, 219);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(89, 25);
            this.btnConnect.TabIndex = 24;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelStatus.Controls.Add(this.labelStatus);
            this.panelStatus.Location = new System.Drawing.Point(62, 280);
            this.panelStatus.Margin = new System.Windows.Forms.Padding(2);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(89, 25);
            this.panelStatus.TabIndex = 25;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(26, 5);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(41, 13);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "label11";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(892, 464);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 13);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "@toygarozl";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // commBox
            // 
            this.commBox.BackColor = System.Drawing.Color.Cornsilk;
            this.commBox.Location = new System.Drawing.Point(460, 54);
            this.commBox.Margin = new System.Windows.Forms.Padding(2);
            this.commBox.Name = "commBox";
            this.commBox.ReadOnly = true;
            this.commBox.Size = new System.Drawing.Size(513, 310);
            this.commBox.TabIndex = 27;
            this.commBox.Text = "";
            this.commBox.TextChanged += new System.EventHandler(this.commBox_TextChanged);
            // 
            // checkBoxAutoScroll
            // 
            this.checkBoxAutoScroll.AutoSize = true;
            this.checkBoxAutoScroll.Location = new System.Drawing.Point(460, 367);
            this.checkBoxAutoScroll.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAutoScroll.Name = "checkBoxAutoScroll";
            this.checkBoxAutoScroll.Size = new System.Drawing.Size(77, 17);
            this.checkBoxAutoScroll.TabIndex = 28;
            this.checkBoxAutoScroll.Text = "Auto Scroll";
            this.checkBoxAutoScroll.UseVisualStyleBackColor = true;
            // 
            // btnClearScreen
            // 
            this.btnClearScreen.Location = new System.Drawing.Point(460, 388);
            this.btnClearScreen.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearScreen.Name = "btnClearScreen";
            this.btnClearScreen.Size = new System.Drawing.Size(89, 25);
            this.btnClearScreen.TabIndex = 29;
            this.btnClearScreen.Text = "Clear Screen";
            this.btnClearScreen.UseVisualStyleBackColor = true;
            this.btnClearScreen.Click += new System.EventHandler(this.btnClearScreen_Click);
            // 
            // commBoxHelpBtn
            // 
            this.commBoxHelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.commBoxHelpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.commBoxHelpBtn.Location = new System.Drawing.Point(942, 20);
            this.commBoxHelpBtn.Margin = new System.Windows.Forms.Padding(2);
            this.commBoxHelpBtn.Name = "commBoxHelpBtn";
            this.commBoxHelpBtn.Size = new System.Drawing.Size(30, 29);
            this.commBoxHelpBtn.TabIndex = 30;
            this.commBoxHelpBtn.Text = "?";
            this.commBoxHelpBtn.UseVisualStyleBackColor = true;
            this.commBoxHelpBtn.MouseLeave += new System.EventHandler(this.commBoxHelpBtn_MouseLeave);
            this.commBoxHelpBtn.MouseHover += new System.EventHandler(this.commBoxHelpBtn_MouseHover);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Info";
            // 
            // btnProgramAdd
            // 
            this.btnProgramAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProgramAdd.Location = new System.Drawing.Point(367, 412);
            this.btnProgramAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnProgramAdd.Name = "btnProgramAdd";
            this.btnProgramAdd.Size = new System.Drawing.Size(45, 32);
            this.btnProgramAdd.TabIndex = 41;
            this.btnProgramAdd.Text = "+";
            this.btnProgramAdd.UseVisualStyleBackColor = true;
            this.btnProgramAdd.Click += new System.EventHandler(this.btnProgramAdd_Click);
            // 
            // programTimer
            // 
            this.programTimer.Interval = 1000;
            this.programTimer.Tick += new System.EventHandler(this.programTimer_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTimer.Location = new System.Drawing.Point(656, 379);
            this.labelTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(126, 35);
            this.labelTimer.TabIndex = 31;
            this.labelTimer.Text = "00:00:00";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.infoColumn,
            this.valueColumn});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.Location = new System.Drawing.Point(9, 318);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Navy;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(190, 109);
            this.dataGridView1.TabIndex = 32;
            // 
            // infoColumn
            // 
            this.infoColumn.Frozen = true;
            this.infoColumn.HeaderText = "info";
            this.infoColumn.MinimumWidth = 6;
            this.infoColumn.Name = "infoColumn";
            this.infoColumn.ReadOnly = true;
            this.infoColumn.Width = 125;
            // 
            // valueColumn
            // 
            this.valueColumn.Frozen = true;
            this.valueColumn.HeaderText = "Value";
            this.valueColumn.MinimumWidth = 6;
            this.valueColumn.Name = "valueColumn";
            this.valueColumn.ReadOnly = true;
            this.valueColumn.Width = 125;
            // 
            // clockLabel
            // 
            this.clockLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clockLabel.Location = new System.Drawing.Point(258, 359);
            this.clockLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(106, 28);
            this.clockLabel.TabIndex = 34;
            this.clockLabel.Text = "00:00:00";
            this.clockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generalTimer
            // 
            this.generalTimer.Enabled = true;
            this.generalTimer.Interval = 1000;
            this.generalTimer.Tick += new System.EventHandler(this.generalTimer_Tick);
            // 
            // defaultProgram
            // 
            this.defaultProgram.AutoSize = true;
            this.defaultProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.defaultProgram.Location = new System.Drawing.Point(258, 223);
            this.defaultProgram.Margin = new System.Windows.Forms.Padding(2);
            this.defaultProgram.Name = "defaultProgram";
            this.defaultProgram.Size = new System.Drawing.Size(71, 21);
            this.defaultProgram.TabIndex = 36;
            this.defaultProgram.TabStop = true;
            this.defaultProgram.Text = "Default";
            this.defaultProgram.UseVisualStyleBackColor = true;
            this.defaultProgram.Click += new System.EventHandler(this.defaultProgram_Click);
            // 
            // setProgram
            // 
            this.setProgram.AutoSize = true;
            this.setProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.setProgram.Location = new System.Drawing.Point(258, 248);
            this.setProgram.Margin = new System.Windows.Forms.Padding(2);
            this.setProgram.Name = "setProgram";
            this.setProgram.Size = new System.Drawing.Size(105, 21);
            this.setProgram.TabIndex = 37;
            this.setProgram.TabStop = true;
            this.setProgram.Text = "Set Program";
            this.setProgram.UseVisualStyleBackColor = true;
            this.setProgram.Click += new System.EventHandler(this.setProgram_Click);
            // 
            // txtProgramCount
            // 
            this.txtProgramCount.Location = new System.Drawing.Point(368, 391);
            this.txtProgramCount.Margin = new System.Windows.Forms.Padding(2);
            this.txtProgramCount.Name = "txtProgramCount";
            this.txtProgramCount.Size = new System.Drawing.Size(45, 20);
            this.txtProgramCount.TabIndex = 42;
            this.txtProgramCount.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtProgramCount_PreviewKeyDown);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(368, 359);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 29);
            this.label11.TabIndex = 43;
            this.label11.Text = "Program Count\r\n";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(256, 339);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 44;
            this.label12.Text = "Finish time: ";
            // 
            // labelFinishTime
            // 
            this.labelFinishTime.AutoSize = true;
            this.labelFinishTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFinishTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFinishTime.Location = new System.Drawing.Point(331, 339);
            this.labelFinishTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFinishTime.Name = "labelFinishTime";
            this.labelFinishTime.Size = new System.Drawing.Size(40, 17);
            this.labelFinishTime.TabIndex = 45;
            this.labelFinishTime.Text = "00:00";
            this.labelFinishTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(256, 326);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 16);
            this.label13.TabIndex = 46;
            this.label13.Text = "Start time: ";
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelStartTime.Location = new System.Drawing.Point(331, 324);
            this.labelStartTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(40, 17);
            this.labelStartTime.TabIndex = 47;
            this.labelStartTime.Text = "00:00";
            this.labelStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLogPath
            // 
            this.labelLogPath.AutoSize = true;
            this.labelLogPath.Location = new System.Drawing.Point(547, 36);
            this.labelLogPath.Name = "labelLogPath";
            this.labelLogPath.Size = new System.Drawing.Size(105, 13);
            this.labelLogPath.TabIndex = 48;
            this.labelLogPath.Text = "Save Direction Path ";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(995, 508);
            this.Controls.Add(this.labelLogPath);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelFinishTime);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtProgramCount);
            this.Controls.Add(this.btnProgramAdd);
            this.Controls.Add(this.setProgram);
            this.Controls.Add(this.defaultProgram);
            this.Controls.Add(this.clockLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.commBoxHelpBtn);
            this.Controls.Add(this.btnClearScreen);
            this.Controls.Add(this.checkBoxAutoScroll);
            this.Controls.Add(this.commBox);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cbxStopbits);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbxParity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxDatabits);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxBaudrate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtOutFanTargetSpeed);
            this.Controls.Add(this.txtCompTargetSpeed);
            this.Controls.Add(this.cbxSerialPort);
            this.Controls.Add(this.cbxOutFanCtrl);
            this.Controls.Add(this.CbxCompSwCtrl);
            this.Controls.Add(this.cbxMasterCtrlSw);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Inverter Driver";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxMasterCtrlSw;
        private System.Windows.Forms.ComboBox CbxCompSwCtrl;
        private System.Windows.Forms.ComboBox cbxOutFanCtrl;
        private System.Windows.Forms.ComboBox cbxSerialPort;
        private System.Windows.Forms.TextBox txtCompTargetSpeed;
        private System.Windows.Forms.TextBox txtOutFanTargetSpeed;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbxBaudrate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxDatabits;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxParity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxStopbits;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.RichTextBox commBox;
        private System.Windows.Forms.CheckBox checkBoxAutoScroll;
        private System.Windows.Forms.Button btnClearScreen;
        private System.Windows.Forms.Button commBoxHelpBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer programTimer;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueColumn;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Timer generalTimer;
        private System.Windows.Forms.RadioButton defaultProgram;
        private System.Windows.Forms.RadioButton setProgram;
        private System.Windows.Forms.Button btnProgramAdd;
        private System.Windows.Forms.TextBox txtProgramCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelFinishTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label labelLogPath;
    }
}

