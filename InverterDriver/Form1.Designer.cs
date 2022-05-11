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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.infoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1.Location = new System.Drawing.Point(297, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Master Control Switch:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Compressor Switch Control:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Compressor Target Speed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Outdoor Fan Control:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Outdoor Fan Target Speed:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Serial Port:";
            // 
            // cbxMasterCtrlSw
            // 
            this.cbxMasterCtrlSw.FormattingEnabled = true;
            this.cbxMasterCtrlSw.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.cbxMasterCtrlSw.Location = new System.Drawing.Point(440, 72);
            this.cbxMasterCtrlSw.Name = "cbxMasterCtrlSw";
            this.cbxMasterCtrlSw.Size = new System.Drawing.Size(90, 24);
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
            this.CbxCompSwCtrl.Location = new System.Drawing.Point(440, 111);
            this.CbxCompSwCtrl.Name = "CbxCompSwCtrl";
            this.CbxCompSwCtrl.Size = new System.Drawing.Size(90, 24);
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
            this.cbxOutFanCtrl.Location = new System.Drawing.Point(440, 192);
            this.cbxOutFanCtrl.Name = "cbxOutFanCtrl";
            this.cbxOutFanCtrl.Size = new System.Drawing.Size(90, 24);
            this.cbxOutFanCtrl.TabIndex = 8;
            this.cbxOutFanCtrl.SelectedIndexChanged += new System.EventHandler(this.cbxOutFanCtrl_SelectedIndexChanged);
            // 
            // cbxSerialPort
            // 
            this.cbxSerialPort.FormattingEnabled = true;
            this.cbxSerialPort.Location = new System.Drawing.Point(135, 227);
            this.cbxSerialPort.Name = "cbxSerialPort";
            this.cbxSerialPort.Size = new System.Drawing.Size(90, 24);
            this.cbxSerialPort.TabIndex = 9;
            // 
            // txtCompTargetSpeed
            // 
            this.txtCompTargetSpeed.Location = new System.Drawing.Point(440, 152);
            this.txtCompTargetSpeed.Name = "txtCompTargetSpeed";
            this.txtCompTargetSpeed.Size = new System.Drawing.Size(89, 22);
            this.txtCompTargetSpeed.TabIndex = 10;
            this.txtCompTargetSpeed.TextChanged += new System.EventHandler(this.txtCompTargetSpeed_TextChanged);
            // 
            // txtOutFanTargetSpeed
            // 
            this.txtOutFanTargetSpeed.Location = new System.Drawing.Point(440, 227);
            this.txtOutFanTargetSpeed.Name = "txtOutFanTargetSpeed";
            this.txtOutFanTargetSpeed.Size = new System.Drawing.Size(90, 22);
            this.txtOutFanTargetSpeed.TabIndex = 11;
            this.txtOutFanTargetSpeed.TextChanged += new System.EventHandler(this.txtOutFanTargetSpeed_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.LightGreen;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.Location = new System.Drawing.Point(373, 270);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(119, 31);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "Send Settings";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1147, 487);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 81);
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
            this.cbxBaudrate.Location = new System.Drawing.Point(135, 72);
            this.cbxBaudrate.Name = "cbxBaudrate";
            this.cbxBaudrate.Size = new System.Drawing.Size(90, 24);
            this.cbxBaudrate.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
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
            this.cbxDatabits.Location = new System.Drawing.Point(135, 111);
            this.cbxDatabits.Name = "cbxDatabits";
            this.cbxDatabits.Size = new System.Drawing.Size(90, 24);
            this.cbxDatabits.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
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
            this.cbxParity.Location = new System.Drawing.Point(135, 147);
            this.cbxParity.Name = "cbxParity";
            this.cbxParity.Size = new System.Drawing.Size(90, 24);
            this.cbxParity.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
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
            this.cbxStopbits.Location = new System.Drawing.Point(135, 187);
            this.cbxStopbits.Name = "cbxStopbits";
            this.cbxStopbits.Size = new System.Drawing.Size(90, 24);
            this.cbxStopbits.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Stopbits: ";
            // 
            // btnConnect
            // 
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Location = new System.Drawing.Point(85, 270);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(119, 31);
            this.btnConnect.TabIndex = 24;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelStatus.Controls.Add(this.labelStatus);
            this.panelStatus.Location = new System.Drawing.Point(220, 338);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(119, 31);
            this.panelStatus.TabIndex = 25;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(33, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(51, 16);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "label11";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1190, 571);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(76, 16);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "@toygarozl";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // commBox
            // 
            this.commBox.BackColor = System.Drawing.Color.Cornsilk;
            this.commBox.Location = new System.Drawing.Point(613, 66);
            this.commBox.Name = "commBox";
            this.commBox.ReadOnly = true;
            this.commBox.Size = new System.Drawing.Size(683, 380);
            this.commBox.TabIndex = 27;
            this.commBox.Text = "";
            this.commBox.TextChanged += new System.EventHandler(this.commBox_TextChanged);
            // 
            // checkBoxAutoScroll
            // 
            this.checkBoxAutoScroll.AutoSize = true;
            this.checkBoxAutoScroll.Location = new System.Drawing.Point(613, 452);
            this.checkBoxAutoScroll.Name = "checkBoxAutoScroll";
            this.checkBoxAutoScroll.Size = new System.Drawing.Size(93, 20);
            this.checkBoxAutoScroll.TabIndex = 28;
            this.checkBoxAutoScroll.Text = "Auto Scroll";
            this.checkBoxAutoScroll.UseVisualStyleBackColor = true;
            // 
            // btnClearScreen
            // 
            this.btnClearScreen.Location = new System.Drawing.Point(613, 478);
            this.btnClearScreen.Name = "btnClearScreen";
            this.btnClearScreen.Size = new System.Drawing.Size(119, 31);
            this.btnClearScreen.TabIndex = 29;
            this.btnClearScreen.Text = "Clear Screen";
            this.btnClearScreen.UseVisualStyleBackColor = true;
            this.btnClearScreen.Click += new System.EventHandler(this.btnClearScreen_Click);
            // 
            // commBoxHelpBtn
            // 
            this.commBoxHelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.commBoxHelpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.commBoxHelpBtn.Location = new System.Drawing.Point(1256, 24);
            this.commBoxHelpBtn.Name = "commBoxHelpBtn";
            this.commBoxHelpBtn.Size = new System.Drawing.Size(40, 36);
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
            this.toolTip1.ToolTipTitle = "Communication Window";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTimer.Location = new System.Drawing.Point(875, 466);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(167, 43);
            this.labelTimer.TabIndex = 31;
            this.labelTimer.Text = "00:00:00";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.infoColumn,
            this.valueColumn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Location = new System.Drawing.Point(152, 393);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Navy;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(254, 134);
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
            // Form1
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1325, 598);
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueColumn;
    }
}

