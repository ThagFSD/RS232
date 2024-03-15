namespace UI_RS232
{
    partial class UI_Form
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbox_comSetup = new System.Windows.Forms.GroupBox();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.button_connect = new System.Windows.Forms.Button();
            this.textbox_currentState = new System.Windows.Forms.TextBox();
            this.dropdownlist_baudRate = new System.Windows.Forms.ComboBox();
            this.dropdownlist_comPort = new System.Windows.Forms.ComboBox();
            this.label_baudRate = new System.Windows.Forms.Label();
            this.label_comPort = new System.Windows.Forms.Label();
            this.gbox_ledControl = new System.Windows.Forms.GroupBox();
            this.button_off3 = new System.Windows.Forms.Button();
            this.button_on3 = new System.Windows.Forms.Button();
            this.button_off2 = new System.Windows.Forms.Button();
            this.button_on2 = new System.Windows.Forms.Button();
            this.button_off1 = new System.Windows.Forms.Button();
            this.button_on1 = new System.Windows.Forms.Button();
            this.picBox_led3 = new System.Windows.Forms.PictureBox();
            this.picBox_led2 = new System.Windows.Forms.PictureBox();
            this.picBox_led1 = new System.Windows.Forms.PictureBox();
            this.label_led2 = new System.Windows.Forms.Label();
            this.label_led1 = new System.Windows.Forms.Label();
            this.label_led3 = new System.Windows.Forms.Label();
            this.gbox_sendAndReceiveData = new System.Windows.Forms.GroupBox();
            this.button_sendData = new System.Windows.Forms.Button();
            this.textBox_receiveData = new System.Windows.Forms.TextBox();
            this.textBox_sendData = new System.Windows.Forms.TextBox();
            this.checkbox_dataSend = new System.Windows.Forms.CheckBox();
            this.label_dataSend = new System.Windows.Forms.Label();
            this.label_data_Receive = new System.Windows.Forms.Label();
            this.gbox_swData = new System.Windows.Forms.GroupBox();
            this.textBox_sw3 = new System.Windows.Forms.TextBox();
            this.textBox_sw1 = new System.Windows.Forms.TextBox();
            this.textBox_sw2 = new System.Windows.Forms.TextBox();
            this.label_sw3CountDisplay = new System.Windows.Forms.Label();
            this.label_sw2CountDisplay = new System.Windows.Forms.Label();
            this.label_sw1CountDisplay = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.signature_label = new System.Windows.Forms.Label();
            this.button_openGate = new System.Windows.Forms.Button();
            this.button_closeGate = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button_resetCounterSw = new System.Windows.Forms.Button();
            this.gbox_vehicleControl = new System.Windows.Forms.GroupBox();
            this.button_turnRight = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_backward = new System.Windows.Forms.Button();
            this.button_forward = new System.Windows.Forms.Button();
            this.button_turnLeft = new System.Windows.Forms.Button();
            this.textBox_vehicleStatus = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gbox_comSetup.SuspendLayout();
            this.gbox_ledControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_led3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_led2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_led1)).BeginInit();
            this.gbox_sendAndReceiveData.SuspendLayout();
            this.gbox_swData.SuspendLayout();
            this.gbox_vehicleControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox_comSetup
            // 
            this.gbox_comSetup.Controls.Add(this.button_disconnect);
            this.gbox_comSetup.Controls.Add(this.button_connect);
            this.gbox_comSetup.Controls.Add(this.textbox_currentState);
            this.gbox_comSetup.Controls.Add(this.dropdownlist_baudRate);
            this.gbox_comSetup.Controls.Add(this.dropdownlist_comPort);
            this.gbox_comSetup.Controls.Add(this.label_baudRate);
            this.gbox_comSetup.Controls.Add(this.label_comPort);
            this.gbox_comSetup.Location = new System.Drawing.Point(12, 53);
            this.gbox_comSetup.Name = "gbox_comSetup";
            this.gbox_comSetup.Size = new System.Drawing.Size(208, 147);
            this.gbox_comSetup.TabIndex = 0;
            this.gbox_comSetup.TabStop = false;
            this.gbox_comSetup.Text = "Communication Setup";
            // 
            // button_disconnect
            // 
            this.button_disconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_disconnect.Enabled = false;
            this.button_disconnect.Location = new System.Drawing.Point(114, 109);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(80, 29);
            this.button_disconnect.TabIndex = 19;
            this.button_disconnect.Text = "Disconnect";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // button_connect
            // 
            this.button_connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_connect.Location = new System.Drawing.Point(13, 109);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(80, 29);
            this.button_connect.TabIndex = 17;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // textbox_currentState
            // 
            this.textbox_currentState.BackColor = System.Drawing.Color.Red;
            this.textbox_currentState.Cursor = System.Windows.Forms.Cursors.Default;
            this.textbox_currentState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_currentState.Location = new System.Drawing.Point(55, 81);
            this.textbox_currentState.Name = "textbox_currentState";
            this.textbox_currentState.ReadOnly = true;
            this.textbox_currentState.Size = new System.Drawing.Size(104, 22);
            this.textbox_currentState.TabIndex = 18;
            this.textbox_currentState.Text = "Disconnected";
            this.textbox_currentState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dropdownlist_baudRate
            // 
            this.dropdownlist_baudRate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropdownlist_baudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownlist_baudRate.Enabled = false;
            this.dropdownlist_baudRate.FormattingEnabled = true;
            this.dropdownlist_baudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.dropdownlist_baudRate.Location = new System.Drawing.Point(74, 54);
            this.dropdownlist_baudRate.Name = "dropdownlist_baudRate";
            this.dropdownlist_baudRate.Size = new System.Drawing.Size(121, 21);
            this.dropdownlist_baudRate.TabIndex = 10;
            this.dropdownlist_baudRate.SelectedIndexChanged += new System.EventHandler(this.dropdownlist_baudRate_SelectedIndexChanged);
            // 
            // dropdownlist_comPort
            // 
            this.dropdownlist_comPort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropdownlist_comPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownlist_comPort.FormattingEnabled = true;
            this.dropdownlist_comPort.Location = new System.Drawing.Point(74, 26);
            this.dropdownlist_comPort.Name = "dropdownlist_comPort";
            this.dropdownlist_comPort.Size = new System.Drawing.Size(121, 21);
            this.dropdownlist_comPort.TabIndex = 7;
            this.dropdownlist_comPort.SelectedIndexChanged += new System.EventHandler(this.dropdownlist_comPort_SelectedIndexChanged);
            // 
            // label_baudRate
            // 
            this.label_baudRate.AutoSize = true;
            this.label_baudRate.Location = new System.Drawing.Point(10, 57);
            this.label_baudRate.Name = "label_baudRate";
            this.label_baudRate.Size = new System.Drawing.Size(58, 13);
            this.label_baudRate.TabIndex = 9;
            this.label_baudRate.Text = "Baud Rate";
            // 
            // label_comPort
            // 
            this.label_comPort.AutoSize = true;
            this.label_comPort.Location = new System.Drawing.Point(10, 29);
            this.label_comPort.Name = "label_comPort";
            this.label_comPort.Size = new System.Drawing.Size(53, 13);
            this.label_comPort.TabIndex = 7;
            this.label_comPort.Text = "COM Port";
            // 
            // gbox_ledControl
            // 
            this.gbox_ledControl.Controls.Add(this.button_off3);
            this.gbox_ledControl.Controls.Add(this.button_on3);
            this.gbox_ledControl.Controls.Add(this.button_off2);
            this.gbox_ledControl.Controls.Add(this.button_on2);
            this.gbox_ledControl.Controls.Add(this.button_off1);
            this.gbox_ledControl.Controls.Add(this.button_on1);
            this.gbox_ledControl.Controls.Add(this.picBox_led3);
            this.gbox_ledControl.Controls.Add(this.picBox_led2);
            this.gbox_ledControl.Controls.Add(this.picBox_led1);
            this.gbox_ledControl.Controls.Add(this.label_led2);
            this.gbox_ledControl.Controls.Add(this.label_led1);
            this.gbox_ledControl.Controls.Add(this.label_led3);
            this.gbox_ledControl.Location = new System.Drawing.Point(464, 53);
            this.gbox_ledControl.Name = "gbox_ledControl";
            this.gbox_ledControl.Size = new System.Drawing.Size(185, 228);
            this.gbox_ledControl.TabIndex = 1;
            this.gbox_ledControl.TabStop = false;
            this.gbox_ledControl.Text = "LED Control";
            // 
            // button_off3
            // 
            this.button_off3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_off3.Location = new System.Drawing.Point(100, 169);
            this.button_off3.Name = "button_off3";
            this.button_off3.Size = new System.Drawing.Size(64, 23);
            this.button_off3.TabIndex = 25;
            this.button_off3.Text = "Off";
            this.button_off3.UseVisualStyleBackColor = true;
            this.button_off3.Click += new System.EventHandler(this.button_off3_Click);
            // 
            // button_on3
            // 
            this.button_on3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_on3.Location = new System.Drawing.Point(100, 140);
            this.button_on3.Name = "button_on3";
            this.button_on3.Size = new System.Drawing.Size(64, 23);
            this.button_on3.TabIndex = 24;
            this.button_on3.Text = "On";
            this.button_on3.UseVisualStyleBackColor = true;
            this.button_on3.Click += new System.EventHandler(this.button_on3_Click);
            // 
            // button_off2
            // 
            this.button_off2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_off2.Location = new System.Drawing.Point(100, 106);
            this.button_off2.Name = "button_off2";
            this.button_off2.Size = new System.Drawing.Size(64, 23);
            this.button_off2.TabIndex = 23;
            this.button_off2.Text = "Off";
            this.button_off2.UseVisualStyleBackColor = true;
            this.button_off2.Click += new System.EventHandler(this.button_off2_Click);
            // 
            // button_on2
            // 
            this.button_on2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_on2.Location = new System.Drawing.Point(100, 77);
            this.button_on2.Name = "button_on2";
            this.button_on2.Size = new System.Drawing.Size(64, 23);
            this.button_on2.TabIndex = 22;
            this.button_on2.Text = "On";
            this.button_on2.UseVisualStyleBackColor = true;
            this.button_on2.Click += new System.EventHandler(this.button_on2_Click);
            // 
            // button_off1
            // 
            this.button_off1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_off1.Location = new System.Drawing.Point(100, 44);
            this.button_off1.Name = "button_off1";
            this.button_off1.Size = new System.Drawing.Size(64, 23);
            this.button_off1.TabIndex = 21;
            this.button_off1.Text = "Off";
            this.button_off1.UseVisualStyleBackColor = true;
            this.button_off1.Click += new System.EventHandler(this.button_off1_Click);
            // 
            // button_on1
            // 
            this.button_on1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_on1.Location = new System.Drawing.Point(100, 18);
            this.button_on1.Name = "button_on1";
            this.button_on1.Size = new System.Drawing.Size(64, 23);
            this.button_on1.TabIndex = 20;
            this.button_on1.Text = "On";
            this.button_on1.UseVisualStyleBackColor = true;
            this.button_on1.Click += new System.EventHandler(this.button_on1_Click);
            // 
            // picBox_led3
            // 
            this.picBox_led3.Image = global::UI_RS232.Properties.Resources.dentat__1_;
            this.picBox_led3.Location = new System.Drawing.Point(57, 149);
            this.picBox_led3.Name = "picBox_led3";
            this.picBox_led3.Size = new System.Drawing.Size(37, 37);
            this.picBox_led3.TabIndex = 16;
            this.picBox_led3.TabStop = false;
            // 
            // picBox_led2
            // 
            this.picBox_led2.Image = global::UI_RS232.Properties.Resources.dentat__1_;
            this.picBox_led2.Location = new System.Drawing.Point(57, 87);
            this.picBox_led2.Name = "picBox_led2";
            this.picBox_led2.Size = new System.Drawing.Size(37, 37);
            this.picBox_led2.TabIndex = 15;
            this.picBox_led2.TabStop = false;
            // 
            // picBox_led1
            // 
            this.picBox_led1.Image = global::UI_RS232.Properties.Resources.dentat__1_;
            this.picBox_led1.Location = new System.Drawing.Point(57, 28);
            this.picBox_led1.Name = "picBox_led1";
            this.picBox_led1.Size = new System.Drawing.Size(37, 37);
            this.picBox_led1.TabIndex = 14;
            this.picBox_led1.TabStop = false;
            // 
            // label_led2
            // 
            this.label_led2.AutoSize = true;
            this.label_led2.Location = new System.Drawing.Point(17, 100);
            this.label_led2.Name = "label_led2";
            this.label_led2.Size = new System.Drawing.Size(34, 13);
            this.label_led2.TabIndex = 10;
            this.label_led2.Text = "LED2";
            // 
            // label_led1
            // 
            this.label_led1.AutoSize = true;
            this.label_led1.Location = new System.Drawing.Point(17, 40);
            this.label_led1.Name = "label_led1";
            this.label_led1.Size = new System.Drawing.Size(34, 13);
            this.label_led1.TabIndex = 8;
            this.label_led1.Text = "LED1";
            // 
            // label_led3
            // 
            this.label_led3.AutoSize = true;
            this.label_led3.Location = new System.Drawing.Point(17, 159);
            this.label_led3.Name = "label_led3";
            this.label_led3.Size = new System.Drawing.Size(34, 13);
            this.label_led3.TabIndex = 13;
            this.label_led3.Text = "LED3";
            // 
            // gbox_sendAndReceiveData
            // 
            this.gbox_sendAndReceiveData.Controls.Add(this.button_sendData);
            this.gbox_sendAndReceiveData.Controls.Add(this.textBox_receiveData);
            this.gbox_sendAndReceiveData.Controls.Add(this.textBox_sendData);
            this.gbox_sendAndReceiveData.Controls.Add(this.checkbox_dataSend);
            this.gbox_sendAndReceiveData.Controls.Add(this.label_dataSend);
            this.gbox_sendAndReceiveData.Controls.Add(this.label_data_Receive);
            this.gbox_sendAndReceiveData.Location = new System.Drawing.Point(239, 53);
            this.gbox_sendAndReceiveData.Name = "gbox_sendAndReceiveData";
            this.gbox_sendAndReceiveData.Size = new System.Drawing.Size(202, 113);
            this.gbox_sendAndReceiveData.TabIndex = 2;
            this.gbox_sendAndReceiveData.TabStop = false;
            this.gbox_sendAndReceiveData.Text = "Data Send/Receive";
            // 
            // button_sendData
            // 
            this.button_sendData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_sendData.Enabled = false;
            this.button_sendData.Location = new System.Drawing.Point(69, 77);
            this.button_sendData.Name = "button_sendData";
            this.button_sendData.Size = new System.Drawing.Size(75, 23);
            this.button_sendData.TabIndex = 18;
            this.button_sendData.Text = "Send";
            this.button_sendData.UseVisualStyleBackColor = true;
            this.button_sendData.Click += new System.EventHandler(this.button_sendData_Click);
            // 
            // textBox_receiveData
            // 
            this.textBox_receiveData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_receiveData.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_receiveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_receiveData.ForeColor = System.Drawing.Color.Red;
            this.textBox_receiveData.Location = new System.Drawing.Point(82, 51);
            this.textBox_receiveData.Name = "textBox_receiveData";
            this.textBox_receiveData.ReadOnly = true;
            this.textBox_receiveData.Size = new System.Drawing.Size(92, 20);
            this.textBox_receiveData.TabIndex = 17;
            this.textBox_receiveData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_receiveData.TextChanged += new System.EventHandler(this.textBox_receiveData_TextChanged);
            // 
            // textBox_sendData
            // 
            this.textBox_sendData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_sendData.Enabled = false;
            this.textBox_sendData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sendData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox_sendData.Location = new System.Drawing.Point(82, 25);
            this.textBox_sendData.Name = "textBox_sendData";
            this.textBox_sendData.Size = new System.Drawing.Size(92, 20);
            this.textBox_sendData.TabIndex = 7;
            this.textBox_sendData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_sendData.TextChanged += new System.EventHandler(this.textBox_sendData_TextChanged);
            // 
            // checkbox_dataSend
            // 
            this.checkbox_dataSend.AutoSize = true;
            this.checkbox_dataSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkbox_dataSend.Enabled = false;
            this.checkbox_dataSend.Location = new System.Drawing.Point(57, 28);
            this.checkbox_dataSend.Name = "checkbox_dataSend";
            this.checkbox_dataSend.Size = new System.Drawing.Size(15, 14);
            this.checkbox_dataSend.TabIndex = 16;
            this.checkbox_dataSend.UseVisualStyleBackColor = true;
            this.checkbox_dataSend.CheckedChanged += new System.EventHandler(this.checkbox_dataSend_CheckedChanged);
            // 
            // label_dataSend
            // 
            this.label_dataSend.AutoSize = true;
            this.label_dataSend.Location = new System.Drawing.Point(19, 28);
            this.label_dataSend.Name = "label_dataSend";
            this.label_dataSend.Size = new System.Drawing.Size(32, 13);
            this.label_dataSend.TabIndex = 12;
            this.label_dataSend.Text = "Send";
            // 
            // label_data_Receive
            // 
            this.label_data_Receive.AutoSize = true;
            this.label_data_Receive.Location = new System.Drawing.Point(19, 54);
            this.label_data_Receive.Name = "label_data_Receive";
            this.label_data_Receive.Size = new System.Drawing.Size(47, 13);
            this.label_data_Receive.TabIndex = 14;
            this.label_data_Receive.Text = "Receive";
            // 
            // gbox_swData
            // 
            this.gbox_swData.Controls.Add(this.textBox_sw3);
            this.gbox_swData.Controls.Add(this.textBox_sw1);
            this.gbox_swData.Controls.Add(this.textBox_sw2);
            this.gbox_swData.Controls.Add(this.label_sw3CountDisplay);
            this.gbox_swData.Controls.Add(this.label_sw2CountDisplay);
            this.gbox_swData.Controls.Add(this.label_sw1CountDisplay);
            this.gbox_swData.Location = new System.Drawing.Point(239, 172);
            this.gbox_swData.Name = "gbox_swData";
            this.gbox_swData.Size = new System.Drawing.Size(202, 109);
            this.gbox_swData.TabIndex = 3;
            this.gbox_swData.TabStop = false;
            this.gbox_swData.Text = "Switch Data";
            // 
            // textBox_sw3
            // 
            this.textBox_sw3.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBox_sw3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_sw3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_sw3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sw3.Location = new System.Drawing.Point(99, 75);
            this.textBox_sw3.Name = "textBox_sw3";
            this.textBox_sw3.ReadOnly = true;
            this.textBox_sw3.Size = new System.Drawing.Size(85, 20);
            this.textBox_sw3.TabIndex = 19;
            this.textBox_sw3.Text = "0";
            this.textBox_sw3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_sw1
            // 
            this.textBox_sw1.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBox_sw1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_sw1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_sw1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sw1.Location = new System.Drawing.Point(99, 22);
            this.textBox_sw1.Name = "textBox_sw1";
            this.textBox_sw1.ReadOnly = true;
            this.textBox_sw1.Size = new System.Drawing.Size(85, 20);
            this.textBox_sw1.TabIndex = 18;
            this.textBox_sw1.Text = "0";
            this.textBox_sw1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_sw2
            // 
            this.textBox_sw2.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBox_sw2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_sw2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_sw2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sw2.Location = new System.Drawing.Point(99, 49);
            this.textBox_sw2.Name = "textBox_sw2";
            this.textBox_sw2.ReadOnly = true;
            this.textBox_sw2.Size = new System.Drawing.Size(85, 20);
            this.textBox_sw2.TabIndex = 20;
            this.textBox_sw2.Text = "0";
            this.textBox_sw2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_sw3CountDisplay
            // 
            this.label_sw3CountDisplay.AutoSize = true;
            this.label_sw3CountDisplay.Location = new System.Drawing.Point(16, 78);
            this.label_sw3CountDisplay.Name = "label_sw3CountDisplay";
            this.label_sw3CountDisplay.Size = new System.Drawing.Size(77, 13);
            this.label_sw3CountDisplay.TabIndex = 15;
            this.label_sw3CountDisplay.Text = "Counter (SW3)";
            // 
            // label_sw2CountDisplay
            // 
            this.label_sw2CountDisplay.AutoSize = true;
            this.label_sw2CountDisplay.Location = new System.Drawing.Point(16, 51);
            this.label_sw2CountDisplay.Name = "label_sw2CountDisplay";
            this.label_sw2CountDisplay.Size = new System.Drawing.Size(77, 13);
            this.label_sw2CountDisplay.TabIndex = 16;
            this.label_sw2CountDisplay.Text = "Counter (SW2)";
            // 
            // label_sw1CountDisplay
            // 
            this.label_sw1CountDisplay.AutoSize = true;
            this.label_sw1CountDisplay.Location = new System.Drawing.Point(16, 25);
            this.label_sw1CountDisplay.Name = "label_sw1CountDisplay";
            this.label_sw1CountDisplay.Size = new System.Drawing.Size(77, 13);
            this.label_sw1CountDisplay.TabIndex = 11;
            this.label_sw1CountDisplay.Text = "Counter (SW1)";
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.Color.Blue;
            this.title_label.Location = new System.Drawing.Point(278, 9);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(371, 25);
            this.title_label.TabIndex = 4;
            this.title_label.Text = "RS232 (COM) Communication Lab";
            // 
            // signature_label
            // 
            this.signature_label.AutoSize = true;
            this.signature_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signature_label.ForeColor = System.Drawing.Color.Blue;
            this.signature_label.Location = new System.Drawing.Point(668, 264);
            this.signature_label.Name = "signature_label";
            this.signature_label.Size = new System.Drawing.Size(143, 16);
            this.signature_label.TabIndex = 5;
            this.signature_label.Text = "Desgined by Thang";
            // 
            // button_openGate
            // 
            this.button_openGate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_openGate.Location = new System.Drawing.Point(30, 206);
            this.button_openGate.Name = "button_openGate";
            this.button_openGate.Size = new System.Drawing.Size(75, 29);
            this.button_openGate.TabIndex = 7;
            this.button_openGate.Text = "Open Gate";
            this.button_openGate.UseVisualStyleBackColor = true;
            this.button_openGate.Click += new System.EventHandler(this.button_openGate_Click);
            // 
            // button_closeGate
            // 
            this.button_closeGate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_closeGate.Location = new System.Drawing.Point(126, 207);
            this.button_closeGate.Name = "button_closeGate";
            this.button_closeGate.Size = new System.Drawing.Size(75, 28);
            this.button_closeGate.TabIndex = 8;
            this.button_closeGate.Text = "Close Gate";
            this.button_closeGate.UseVisualStyleBackColor = true;
            this.button_closeGate.Click += new System.EventHandler(this.button_closeGate_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // button_resetCounterSw
            // 
            this.button_resetCounterSw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_resetCounterSw.Location = new System.Drawing.Point(56, 245);
            this.button_resetCounterSw.Name = "button_resetCounterSw";
            this.button_resetCounterSw.Size = new System.Drawing.Size(115, 23);
            this.button_resetCounterSw.TabIndex = 9;
            this.button_resetCounterSw.Text = "Reset Counter SW";
            this.button_resetCounterSw.UseVisualStyleBackColor = true;
            this.button_resetCounterSw.Click += new System.EventHandler(this.button_resetCounterSw_Click);
            // 
            // gbox_vehicleControl
            // 
            this.gbox_vehicleControl.Controls.Add(this.button_turnRight);
            this.gbox_vehicleControl.Controls.Add(this.button_stop);
            this.gbox_vehicleControl.Controls.Add(this.button_backward);
            this.gbox_vehicleControl.Controls.Add(this.button_forward);
            this.gbox_vehicleControl.Controls.Add(this.button_turnLeft);
            this.gbox_vehicleControl.Controls.Add(this.textBox_vehicleStatus);
            this.gbox_vehicleControl.Location = new System.Drawing.Point(655, 53);
            this.gbox_vehicleControl.Name = "gbox_vehicleControl";
            this.gbox_vehicleControl.Size = new System.Drawing.Size(200, 201);
            this.gbox_vehicleControl.TabIndex = 10;
            this.gbox_vehicleControl.TabStop = false;
            this.gbox_vehicleControl.Text = "Vehicle Control";
            // 
            // button_turnRight
            // 
            this.button_turnRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_turnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_turnRight.Location = new System.Drawing.Point(108, 66);
            this.button_turnRight.Name = "button_turnRight";
            this.button_turnRight.Size = new System.Drawing.Size(75, 31);
            this.button_turnRight.TabIndex = 5;
            this.button_turnRight.Text = "Turn Right";
            this.button_turnRight.UseVisualStyleBackColor = true;
            this.button_turnRight.Click += new System.EventHandler(this.button_turnRight_Click);
            // 
            // button_stop
            // 
            this.button_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_stop.Location = new System.Drawing.Point(67, 141);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(75, 29);
            this.button_stop.TabIndex = 4;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_backward
            // 
            this.button_backward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_backward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_backward.Location = new System.Drawing.Point(108, 103);
            this.button_backward.Name = "button_backward";
            this.button_backward.Size = new System.Drawing.Size(75, 29);
            this.button_backward.TabIndex = 3;
            this.button_backward.Text = "Backward";
            this.button_backward.UseVisualStyleBackColor = true;
            this.button_backward.Click += new System.EventHandler(this.button_backward_Click);
            // 
            // button_forward
            // 
            this.button_forward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_forward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_forward.Location = new System.Drawing.Point(27, 103);
            this.button_forward.Name = "button_forward";
            this.button_forward.Size = new System.Drawing.Size(75, 29);
            this.button_forward.TabIndex = 2;
            this.button_forward.Text = "Forward";
            this.button_forward.UseVisualStyleBackColor = true;
            this.button_forward.Click += new System.EventHandler(this.button_forward_Click);
            // 
            // button_turnLeft
            // 
            this.button_turnLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_turnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_turnLeft.Location = new System.Drawing.Point(27, 66);
            this.button_turnLeft.Name = "button_turnLeft";
            this.button_turnLeft.Size = new System.Drawing.Size(75, 31);
            this.button_turnLeft.TabIndex = 1;
            this.button_turnLeft.Text = "Turn left";
            this.button_turnLeft.UseVisualStyleBackColor = true;
            this.button_turnLeft.Click += new System.EventHandler(this.button_turnLeft_Click);
            // 
            // textBox_vehicleStatus
            // 
            this.textBox_vehicleStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_vehicleStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_vehicleStatus.Location = new System.Drawing.Point(27, 29);
            this.textBox_vehicleStatus.Name = "textBox_vehicleStatus";
            this.textBox_vehicleStatus.ReadOnly = true;
            this.textBox_vehicleStatus.Size = new System.Drawing.Size(156, 26);
            this.textBox_vehicleStatus.TabIndex = 0;
            this.textBox_vehicleStatus.Text = "Vehicle status";
            this.textBox_vehicleStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_vehicleStatus.TextChanged += new System.EventHandler(this.textBox_vehicleStatus_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UI_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(909, 289);
            this.Controls.Add(this.gbox_vehicleControl);
            this.Controls.Add(this.button_resetCounterSw);
            this.Controls.Add(this.button_closeGate);
            this.Controls.Add(this.button_openGate);
            this.Controls.Add(this.signature_label);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.gbox_swData);
            this.Controls.Add(this.gbox_sendAndReceiveData);
            this.Controls.Add(this.gbox_ledControl);
            this.Controls.Add(this.gbox_comSetup);
            this.MaximizeBox = false;
            this.Name = "UI_Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "RS232 Communication";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UI_Form_FormClosing);
            this.Load += new System.EventHandler(this.UI_Form_Load);
            this.gbox_comSetup.ResumeLayout(false);
            this.gbox_comSetup.PerformLayout();
            this.gbox_ledControl.ResumeLayout(false);
            this.gbox_ledControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_led3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_led2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_led1)).EndInit();
            this.gbox_sendAndReceiveData.ResumeLayout(false);
            this.gbox_sendAndReceiveData.PerformLayout();
            this.gbox_swData.ResumeLayout(false);
            this.gbox_swData.PerformLayout();
            this.gbox_vehicleControl.ResumeLayout(false);
            this.gbox_vehicleControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbox_comSetup;
        private System.Windows.Forms.GroupBox gbox_ledControl;
        private System.Windows.Forms.GroupBox gbox_sendAndReceiveData;
        private System.Windows.Forms.GroupBox gbox_swData;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label signature_label;
        private System.Windows.Forms.Label label_baudRate;
        private System.Windows.Forms.Label label_comPort;
        private System.Windows.Forms.Label label_led2;
        private System.Windows.Forms.Label label_led1;
        private System.Windows.Forms.Label label_sw1CountDisplay;
        private System.Windows.Forms.Label label_dataSend;
        private System.Windows.Forms.Label label_led3;
        private System.Windows.Forms.Label label_data_Receive;
        private System.Windows.Forms.Label label_sw3CountDisplay;
        private System.Windows.Forms.CheckBox checkbox_dataSend;
        private System.Windows.Forms.Label label_sw2CountDisplay;
        private System.Windows.Forms.ComboBox dropdownlist_baudRate;
        private System.Windows.Forms.ComboBox dropdownlist_comPort;
        private System.Windows.Forms.PictureBox picBox_led3;
        private System.Windows.Forms.PictureBox picBox_led2;
        private System.Windows.Forms.PictureBox picBox_led1;
        private System.Windows.Forms.TextBox textBox_receiveData;
        private System.Windows.Forms.TextBox textBox_sendData;
        private System.Windows.Forms.TextBox textbox_currentState;
        private System.Windows.Forms.TextBox textBox_sw3;
        private System.Windows.Forms.TextBox textBox_sw1;
        private System.Windows.Forms.TextBox textBox_sw2;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_off1;
        private System.Windows.Forms.Button button_on1;
        private System.Windows.Forms.Button button_off3;
        private System.Windows.Forms.Button button_on3;
        private System.Windows.Forms.Button button_off2;
        private System.Windows.Forms.Button button_on2;
        private System.Windows.Forms.Button button_sendData;
        private System.Windows.Forms.Button button_openGate;
        private System.Windows.Forms.Button button_closeGate;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button_resetCounterSw;
        private System.Windows.Forms.GroupBox gbox_vehicleControl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button_turnLeft;
        private System.Windows.Forms.TextBox textBox_vehicleStatus;
        private System.Windows.Forms.Button button_turnRight;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_backward;
        private System.Windows.Forms.Button button_forward;
    }
}

