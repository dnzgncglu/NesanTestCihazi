
namespace TestCihaziDeniz
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chBoxRtsEnable = new System.Windows.Forms.CheckBox();
            this.chBoxDtrEnable = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxParityBits = new System.Windows.Forms.ComboBox();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.CBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.cBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnSendData = new System.Windows.Forms.Button();
            this.tBoxDataOut = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblDataOutLength = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDataInLength = new System.Windows.Forms.Label();
            this.tBoxDataIN = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fİleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToTxtFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_appendOrOverwriteText = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox_writeLineOrwriteText = new System.Windows.Forms.ToolStripComboBox();
            this.saveToMySQLDatabeseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLOSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transmitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_TxEndLine = new System.Windows.Forms.ToolStripComboBox();
            this.dataFormatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_TxDataFormat = new System.Windows.Forms.ToolStripComboBox();
            this.receiverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_RxShowDataWith = new System.Windows.Forms.ToolStripComboBox();
            this.dataPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_RxDataPositon = new System.Windows.Forms.ToolStripComboBox();
            this.dataFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_RxDataFormat = new System.Windows.Forms.ToolStripComboBox();
            this.multiplePortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ıN1PORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chBoxRtsEnable);
            this.groupBox1.Controls.Add(this.chBoxDtrEnable);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxParityBits);
            this.groupBox1.Controls.Add(this.cBoxStopBits);
            this.groupBox1.Controls.Add(this.cBoxDataBits);
            this.groupBox1.Controls.Add(this.CBoxBaudRate);
            this.groupBox1.Controls.Add(this.cBoxCOMPORT);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM PORT SETTINGS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chBoxRtsEnable
            // 
            this.chBoxRtsEnable.AutoSize = true;
            this.chBoxRtsEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chBoxRtsEnable.Location = new System.Drawing.Point(128, 156);
            this.chBoxRtsEnable.Name = "chBoxRtsEnable";
            this.chBoxRtsEnable.Size = new System.Drawing.Size(89, 17);
            this.chBoxRtsEnable.TabIndex = 12;
            this.chBoxRtsEnable.Text = "RTS ENABLE";
            this.chBoxRtsEnable.UseVisualStyleBackColor = true;
            this.chBoxRtsEnable.CheckedChanged += new System.EventHandler(this.chBoxRtsEnable_CheckedChanged);
            // 
            // chBoxDtrEnable
            // 
            this.chBoxDtrEnable.AutoSize = true;
            this.chBoxDtrEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chBoxDtrEnable.Location = new System.Drawing.Point(21, 156);
            this.chBoxDtrEnable.Name = "chBoxDtrEnable";
            this.chBoxDtrEnable.Size = new System.Drawing.Size(90, 17);
            this.chBoxDtrEnable.TabIndex = 11;
            this.chBoxDtrEnable.Text = "DTR ENABLE";
            this.chBoxDtrEnable.UseVisualStyleBackColor = true;
            this.chBoxDtrEnable.CheckedChanged += new System.EventHandler(this.chBoxDtrEnable_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "PARITY BITS";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "STOP BITS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DATA BITS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "COM PORT";
            // 
            // cBoxParityBits
            // 
            this.cBoxParityBits.FormattingEnabled = true;
            this.cBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParityBits.Location = new System.Drawing.Point(101, 129);
            this.cBoxParityBits.Name = "cBoxParityBits";
            this.cBoxParityBits.Size = new System.Drawing.Size(127, 21);
            this.cBoxParityBits.TabIndex = 5;
            this.cBoxParityBits.Text = " None";
            this.cBoxParityBits.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopBits.Location = new System.Drawing.Point(101, 102);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(127, 21);
            this.cBoxStopBits.TabIndex = 4;
            this.cBoxStopBits.Text = " One";
            this.cBoxStopBits.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(101, 75);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(127, 21);
            this.cBoxDataBits.TabIndex = 3;
            this.cBoxDataBits.Text = " 8";
            this.cBoxDataBits.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // CBoxBaudRate
            // 
            this.CBoxBaudRate.FormattingEnabled = true;
            this.CBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "38400",
            "57600",
            "115200"});
            this.CBoxBaudRate.Location = new System.Drawing.Point(101, 48);
            this.CBoxBaudRate.Name = "CBoxBaudRate";
            this.CBoxBaudRate.Size = new System.Drawing.Size(127, 21);
            this.CBoxBaudRate.TabIndex = 2;
            this.CBoxBaudRate.Text = " 9600";
            this.CBoxBaudRate.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cBoxCOMPORT
            // 
            this.cBoxCOMPORT.FormattingEnabled = true;
            this.cBoxCOMPORT.Location = new System.Drawing.Point(101, 21);
            this.cBoxCOMPORT.Name = "cBoxCOMPORT";
            this.cBoxCOMPORT.Size = new System.Drawing.Size(127, 21);
            this.cBoxCOMPORT.TabIndex = 1;
            this.cBoxCOMPORT.Text = " ";
            this.cBoxCOMPORT.DropDown += new System.EventHandler(this.cBoxCOMPORT_DropDown);
            this.cBoxCOMPORT.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(237, 23);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // btnSendData
            // 
            this.btnSendData.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSendData.Location = new System.Drawing.Point(265, 0);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(49, 25);
            this.btnSendData.TabIndex = 2;
            this.btnSendData.Text = "Send";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // tBoxDataOut
            // 
            this.tBoxDataOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBoxDataOut.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxDataOut.Location = new System.Drawing.Point(0, 0);
            this.tBoxDataOut.Name = "tBoxDataOut";
            this.tBoxDataOut.Size = new System.Drawing.Size(265, 27);
            this.tBoxDataOut.TabIndex = 3;
            this.tBoxDataOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxDataOut_KeyPress);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblDataOutLength);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Location = new System.Drawing.Point(247, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(156, 31);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            // 
            // lblDataOutLength
            // 
            this.lblDataOutLength.AutoSize = true;
            this.lblDataOutLength.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataOutLength.Location = new System.Drawing.Point(126, 11);
            this.lblDataOutLength.Name = "lblDataOutLength";
            this.lblDataOutLength.Size = new System.Drawing.Size(23, 15);
            this.lblDataOutLength.TabIndex = 6;
            this.lblDataOutLength.Text = "00";
            this.lblDataOutLength.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data OUT Length :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label7);
            this.groupBox11.Controls.Add(this.lblDataInLength);
            this.groupBox11.Location = new System.Drawing.Point(425, 0);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(144, 31);
            this.groupBox11.TabIndex = 7;
            this.groupBox11.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(117, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "00";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // lblDataInLength
            // 
            this.lblDataInLength.AutoSize = true;
            this.lblDataInLength.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInLength.Location = new System.Drawing.Point(6, 11);
            this.lblDataInLength.Name = "lblDataInLength";
            this.lblDataInLength.Size = new System.Drawing.Size(116, 15);
            this.lblDataInLength.TabIndex = 5;
            this.lblDataInLength.Text = "Data IN Length :";
            this.lblDataInLength.Click += new System.EventHandler(this.lblDataInLength_Click);
            // 
            // tBoxDataIN
            // 
            this.tBoxDataIN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tBoxDataIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxDataIN.Location = new System.Drawing.Point(3, 46);
            this.tBoxDataIN.Multiline = true;
            this.tBoxDataIN.Name = "tBoxDataIN";
            this.tBoxDataIN.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBoxDataIN.Size = new System.Drawing.Size(314, 139);
            this.tBoxDataIN.TabIndex = 6;
            this.tBoxDataIN.WordWrap = false;
            this.tBoxDataIN.TextChanged += new System.EventHandler(this.tBoxDataIN_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fİleToolStripMenuItem,
            this.comToolStripMenuItem,
            this.transmitterToolStripMenuItem,
            this.receiverToolStripMenuItem,
            this.multiplePortToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(577, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fİleToolStripMenuItem
            // 
            this.fİleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToTxtFileToolStripMenuItem,
            this.saveToMySQLDatabeseToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fİleToolStripMenuItem.Name = "fİleToolStripMenuItem";
            this.fİleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fİleToolStripMenuItem.Text = "File";
            // 
            // saveToTxtFileToolStripMenuItem
            // 
            this.saveToTxtFileToolStripMenuItem.Checked = true;
            this.saveToTxtFileToolStripMenuItem.CheckOnClick = true;
            this.saveToTxtFileToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveToTxtFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_appendOrOverwriteText,
            this.toolStripComboBox_writeLineOrwriteText});
            this.saveToTxtFileToolStripMenuItem.Name = "saveToTxtFileToolStripMenuItem";
            this.saveToTxtFileToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.saveToTxtFileToolStripMenuItem.Text = "Save to Txt File";
            // 
            // toolStripComboBox_appendOrOverwriteText
            // 
            this.toolStripComboBox_appendOrOverwriteText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_appendOrOverwriteText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_appendOrOverwriteText.Items.AddRange(new object[] {
            "Append Text",
            "OverWrite Text"});
            this.toolStripComboBox_appendOrOverwriteText.Name = "toolStripComboBox_appendOrOverwriteText";
            this.toolStripComboBox_appendOrOverwriteText.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox_appendOrOverwriteText.DropDownClosed += new System.EventHandler(this.toolStripComboBox_appendOrOverwriteText_DropDownClosed);
            // 
            // toolStripComboBox_writeLineOrwriteText
            // 
            this.toolStripComboBox_writeLineOrwriteText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_writeLineOrwriteText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_writeLineOrwriteText.Items.AddRange(new object[] {
            "WriteLine",
            "Write"});
            this.toolStripComboBox_writeLineOrwriteText.Name = "toolStripComboBox_writeLineOrwriteText";
            this.toolStripComboBox_writeLineOrwriteText.Size = new System.Drawing.Size(121, 23);
            // 
            // saveToMySQLDatabeseToolStripMenuItem
            // 
            this.saveToMySQLDatabeseToolStripMenuItem.Checked = true;
            this.saveToMySQLDatabeseToolStripMenuItem.CheckOnClick = true;
            this.saveToMySQLDatabeseToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveToMySQLDatabeseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDataToolStripMenuItem1});
            this.saveToMySQLDatabeseToolStripMenuItem.Name = "saveToMySQLDatabeseToolStripMenuItem";
            this.saveToMySQLDatabeseToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.saveToMySQLDatabeseToolStripMenuItem.Text = "Save to MySQL Databese";
            // 
            // showDataToolStripMenuItem1
            // 
            this.showDataToolStripMenuItem1.Name = "showDataToolStripMenuItem1";
            this.showDataToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.showDataToolStripMenuItem1.Text = "Show Data";
            this.showDataToolStripMenuItem1.Click += new System.EventHandler(this.showDataToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // comToolStripMenuItem
            // 
            this.comToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPENToolStripMenuItem,
            this.cLOSEToolStripMenuItem});
            this.comToolStripMenuItem.Name = "comToolStripMenuItem";
            this.comToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.comToolStripMenuItem.Text = "COM Control";
            // 
            // oPENToolStripMenuItem
            // 
            this.oPENToolStripMenuItem.Name = "oPENToolStripMenuItem";
            this.oPENToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.oPENToolStripMenuItem.Text = "OPEN";
            this.oPENToolStripMenuItem.Click += new System.EventHandler(this.oPENToolStripMenuItem_Click);
            // 
            // cLOSEToolStripMenuItem
            // 
            this.cLOSEToolStripMenuItem.Name = "cLOSEToolStripMenuItem";
            this.cLOSEToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.cLOSEToolStripMenuItem.Text = "CLOSE";
            this.cLOSEToolStripMenuItem.Click += new System.EventHandler(this.cLOSEToolStripMenuItem_Click);
            // 
            // transmitterToolStripMenuItem
            // 
            this.transmitterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.endLineToolStripMenuItem,
            this.dataFormatToolStripMenuItem1});
            this.transmitterToolStripMenuItem.Name = "transmitterToolStripMenuItem";
            this.transmitterToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.transmitterToolStripMenuItem.Text = "Transmitter";
            this.transmitterToolStripMenuItem.Click += new System.EventHandler(this.transmitterToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Checked = true;
            this.clearToolStripMenuItem.CheckOnClick = true;
            this.clearToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "Clear After Send";
            // 
            // endLineToolStripMenuItem
            // 
            this.endLineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_TxEndLine});
            this.endLineToolStripMenuItem.Name = "endLineToolStripMenuItem";
            this.endLineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.endLineToolStripMenuItem.Text = "End Line";
            // 
            // toolStripComboBox_TxEndLine
            // 
            this.toolStripComboBox_TxEndLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_TxEndLine.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_TxEndLine.Items.AddRange(new object[] {
            "None",
            "Both (\\r\\n)",
            "New Line (\\n)",
            "Carriage Return (\\r)"});
            this.toolStripComboBox_TxEndLine.Name = "toolStripComboBox_TxEndLine";
            this.toolStripComboBox_TxEndLine.Size = new System.Drawing.Size(130, 23);
            this.toolStripComboBox_TxEndLine.DropDownClosed += new System.EventHandler(this.toolStripComboBox2_DropDownClosed);
            // 
            // dataFormatToolStripMenuItem1
            // 
            this.dataFormatToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_TxDataFormat});
            this.dataFormatToolStripMenuItem1.Name = "dataFormatToolStripMenuItem1";
            this.dataFormatToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.dataFormatToolStripMenuItem1.Text = "Data Format";
            // 
            // toolStripComboBox_TxDataFormat
            // 
            this.toolStripComboBox_TxDataFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_TxDataFormat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_TxDataFormat.Items.AddRange(new object[] {
            "Hex",
            "Decimal",
            "Binary",
            "Char"});
            this.toolStripComboBox_TxDataFormat.Name = "toolStripComboBox_TxDataFormat";
            this.toolStripComboBox_TxDataFormat.Size = new System.Drawing.Size(121, 23);
            // 
            // receiverToolStripMenuItem
            // 
            this.receiverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem1,
            this.showDataToolStripMenuItem,
            this.dataPositionToolStripMenuItem,
            this.dataFormatToolStripMenuItem});
            this.receiverToolStripMenuItem.Name = "receiverToolStripMenuItem";
            this.receiverToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.receiverToolStripMenuItem.Text = "Receiver";
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem1.Text = "Clear";
            this.clearToolStripMenuItem1.Click += new System.EventHandler(this.clearToolStripMenuItem1_Click);
            // 
            // showDataToolStripMenuItem
            // 
            this.showDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_RxShowDataWith});
            this.showDataToolStripMenuItem.Name = "showDataToolStripMenuItem";
            this.showDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showDataToolStripMenuItem.Text = "Show Data With";
            // 
            // toolStripComboBox_RxShowDataWith
            // 
            this.toolStripComboBox_RxShowDataWith.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_RxShowDataWith.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_RxShowDataWith.Items.AddRange(new object[] {
            "Always Update",
            "Add To Old Data\t"});
            this.toolStripComboBox_RxShowDataWith.Name = "toolStripComboBox_RxShowDataWith";
            this.toolStripComboBox_RxShowDataWith.Size = new System.Drawing.Size(121, 23);
            // 
            // dataPositionToolStripMenuItem
            // 
            this.dataPositionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_RxDataPositon});
            this.dataPositionToolStripMenuItem.Name = "dataPositionToolStripMenuItem";
            this.dataPositionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataPositionToolStripMenuItem.Text = "Data Position";
            // 
            // toolStripComboBox_RxDataPositon
            // 
            this.toolStripComboBox_RxDataPositon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_RxDataPositon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_RxDataPositon.Items.AddRange(new object[] {
            "TOP",
            "BUTTON"});
            this.toolStripComboBox_RxDataPositon.Name = "toolStripComboBox_RxDataPositon";
            this.toolStripComboBox_RxDataPositon.Size = new System.Drawing.Size(121, 23);
            // 
            // dataFormatToolStripMenuItem
            // 
            this.dataFormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_RxDataFormat});
            this.dataFormatToolStripMenuItem.Name = "dataFormatToolStripMenuItem";
            this.dataFormatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataFormatToolStripMenuItem.Text = "Data Format";
            // 
            // toolStripComboBox_RxDataFormat
            // 
            this.toolStripComboBox_RxDataFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_RxDataFormat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_RxDataFormat.Items.AddRange(new object[] {
            "Hex",
            "Decimal",
            "Binary",
            "Char"});
            this.toolStripComboBox_RxDataFormat.Name = "toolStripComboBox_RxDataFormat";
            this.toolStripComboBox_RxDataFormat.Size = new System.Drawing.Size(121, 23);
            // 
            // multiplePortToolStripMenuItem
            // 
            this.multiplePortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ıN1PORTSToolStripMenuItem});
            this.multiplePortToolStripMenuItem.Name = "multiplePortToolStripMenuItem";
            this.multiplePortToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.multiplePortToolStripMenuItem.Text = "Multiple Port";
            // 
            // ıN1PORTSToolStripMenuItem
            // 
            this.ıN1PORTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1});
            this.ıN1PORTSToolStripMenuItem.Name = "ıN1PORTSToolStripMenuItem";
            this.ıN1PORTSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ıN1PORTSToolStripMenuItem.Text = "2 IN 1 PORTS";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.panel3);
            this.groupBox12.Controls.Add(this.tBoxDataIN);
            this.groupBox12.Location = new System.Drawing.Point(247, 3);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(320, 188);
            this.groupBox12.TabIndex = 7;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "MONITOR";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tBoxDataOut);
            this.panel3.Controls.Add(this.btnSendData);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 25);
            this.panel3.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.panel1.Size = new System.Drawing.Size(577, 245);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox7);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.groupBox11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 35);
            this.panel2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 269);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(593, 308);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " C# COM PORT SERIAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBoxCOMPORT;
        private System.Windows.Forms.ComboBox cBoxParityBits;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.ComboBox CBoxBaudRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.TextBox tBoxDataOut;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.CheckBox chBoxRtsEnable;
        private System.Windows.Forms.CheckBox chBoxDtrEnable;
        private System.Windows.Forms.Label lblDataOutLength;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBoxDataIN;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDataInLength;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fİleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLOSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transmitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_TxEndLine;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_RxShowDataWith;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.ToolStripMenuItem dataPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_RxDataPositon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem saveToTxtFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_appendOrOverwriteText;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_writeLineOrwriteText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToMySQLDatabeseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDataToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem multiplePortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ıN1PORTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dataFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_RxDataFormat;
        private System.Windows.Forms.ToolStripMenuItem dataFormatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_TxDataFormat;
    }
}

