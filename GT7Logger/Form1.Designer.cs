namespace GT7Logger
{
    partial class GT7Logger
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBrake = new System.Windows.Forms.Label();
            this.lblThrottle = new System.Windows.Forms.Label();
            this.lblRPM = new System.Windows.Forms.Label();
            this.barBrake = new System.Windows.Forms.ProgressBar();
            this.lblRR = new System.Windows.Forms.Label();
            this.lblRL = new System.Windows.Forms.Label();
            this.lblFR = new System.Windows.Forms.Label();
            this.lblFL = new System.Windows.Forms.Label();
            this.barRPM = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRR = new System.Windows.Forms.TextBox();
            this.txtRL = new System.Windows.Forms.TextBox();
            this.txtFR = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFL = new System.Windows.Forms.TextBox();
            this.barThrottle = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGear = new System.Windows.Forms.Label();
            this.lblLap = new System.Windows.Forms.Label();
            this.lblRecordId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstDebug = new System.Windows.Forms.ListBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.ddlType = new System.Windows.Forms.ComboBox();
            this.ddlLap = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblLapCount = new System.Windows.Forms.Label();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timRecordUpdate = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTrackname = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.lblLapsImported = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnCreateTrack = new System.Windows.Forms.Button();
            this.ddlTrackRight = new System.Windows.Forms.ComboBox();
            this.ddlTrackLeft = new System.Windows.Forms.ComboBox();
            this.ddlRaceline = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtDatafile = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "PS4/5 IP address";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIP.Location = new System.Drawing.Point(156, 12);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(160, 29);
            this.txtIP.TabIndex = 1;
            this.txtIP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIP_KeyUp);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(339, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(449, 29);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start recording";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblBrake);
            this.groupBox1.Controls.Add(this.lblThrottle);
            this.groupBox1.Controls.Add(this.lblRPM);
            this.groupBox1.Controls.Add(this.barBrake);
            this.groupBox1.Controls.Add(this.lblRR);
            this.groupBox1.Controls.Add(this.lblRL);
            this.groupBox1.Controls.Add(this.lblFR);
            this.groupBox1.Controls.Add(this.lblFL);
            this.groupBox1.Controls.Add(this.barRPM);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtRR);
            this.groupBox1.Controls.Add(this.txtRL);
            this.groupBox1.Controls.Add(this.txtFR);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtFL);
            this.groupBox1.Controls.Add(this.barThrottle);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblSpeed);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblGear);
            this.groupBox1.Controls.Add(this.lblLap);
            this.groupBox1.Controls.Add(this.lblRecordId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 139);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Live data";
            // 
            // lblBrake
            // 
            this.lblBrake.AutoSize = true;
            this.lblBrake.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBrake.Location = new System.Drawing.Point(496, 108);
            this.lblBrake.Name = "lblBrake";
            this.lblBrake.Size = new System.Drawing.Size(13, 15);
            this.lblBrake.TabIndex = 27;
            this.lblBrake.Text = "0";
            // 
            // lblThrottle
            // 
            this.lblThrottle.AutoSize = true;
            this.lblThrottle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblThrottle.Location = new System.Drawing.Point(496, 87);
            this.lblThrottle.Name = "lblThrottle";
            this.lblThrottle.Size = new System.Drawing.Size(13, 15);
            this.lblThrottle.TabIndex = 26;
            this.lblThrottle.Text = "0";
            // 
            // lblRPM
            // 
            this.lblRPM.AutoSize = true;
            this.lblRPM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRPM.Location = new System.Drawing.Point(496, 45);
            this.lblRPM.Name = "lblRPM";
            this.lblRPM.Size = new System.Drawing.Size(13, 15);
            this.lblRPM.TabIndex = 25;
            this.lblRPM.Text = "0";
            // 
            // barBrake
            // 
            this.barBrake.Location = new System.Drawing.Point(327, 104);
            this.barBrake.Name = "barBrake";
            this.barBrake.Size = new System.Drawing.Size(163, 20);
            this.barBrake.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barBrake.TabIndex = 24;
            // 
            // lblRR
            // 
            this.lblRR.AutoSize = true;
            this.lblRR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRR.Location = new System.Drawing.Point(744, 87);
            this.lblRR.Name = "lblRR";
            this.lblRR.Size = new System.Drawing.Size(13, 15);
            this.lblRR.TabIndex = 23;
            this.lblRR.Text = "0";
            // 
            // lblRL
            // 
            this.lblRL.AutoSize = true;
            this.lblRL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRL.Location = new System.Drawing.Point(669, 87);
            this.lblRL.Name = "lblRL";
            this.lblRL.Size = new System.Drawing.Size(13, 15);
            this.lblRL.TabIndex = 22;
            this.lblRL.Text = "0";
            // 
            // lblFR
            // 
            this.lblFR.AutoSize = true;
            this.lblFR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFR.Location = new System.Drawing.Point(744, 46);
            this.lblFR.Name = "lblFR";
            this.lblFR.Size = new System.Drawing.Size(13, 15);
            this.lblFR.TabIndex = 21;
            this.lblFR.Text = "0";
            // 
            // lblFL
            // 
            this.lblFL.AutoSize = true;
            this.lblFL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFL.Location = new System.Drawing.Point(669, 46);
            this.lblFL.Name = "lblFL";
            this.lblFL.Size = new System.Drawing.Size(13, 15);
            this.lblFL.TabIndex = 20;
            this.lblFL.Text = "0";
            // 
            // barRPM
            // 
            this.barRPM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.barRPM.Location = new System.Drawing.Point(327, 40);
            this.barRPM.Name = "barRPM";
            this.barRPM.Size = new System.Drawing.Size(163, 21);
            this.barRPM.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barRPM.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(240, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 21);
            this.label12.TabIndex = 18;
            this.label12.Text = "RPM";
            // 
            // txtRR
            // 
            this.txtRR.BackColor = System.Drawing.Color.Lime;
            this.txtRR.Enabled = false;
            this.txtRR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRR.Location = new System.Drawing.Point(744, 101);
            this.txtRR.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.txtRR.Name = "txtRR";
            this.txtRR.ReadOnly = true;
            this.txtRR.Size = new System.Drawing.Size(16, 23);
            this.txtRR.TabIndex = 17;
            // 
            // txtRL
            // 
            this.txtRL.BackColor = System.Drawing.Color.Lime;
            this.txtRL.Enabled = false;
            this.txtRL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRL.Location = new System.Drawing.Point(669, 101);
            this.txtRL.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.txtRL.Name = "txtRL";
            this.txtRL.ReadOnly = true;
            this.txtRL.Size = new System.Drawing.Size(16, 23);
            this.txtRL.TabIndex = 16;
            // 
            // txtFR
            // 
            this.txtFR.BackColor = System.Drawing.Color.Lime;
            this.txtFR.Enabled = false;
            this.txtFR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFR.Location = new System.Drawing.Point(744, 25);
            this.txtFR.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.txtFR.Name = "txtFR";
            this.txtFR.ReadOnly = true;
            this.txtFR.Size = new System.Drawing.Size(16, 23);
            this.txtFR.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(696, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 21);
            this.label11.TabIndex = 14;
            this.label11.Text = "Rear";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(691, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 21);
            this.label10.TabIndex = 13;
            this.label10.Text = "Front";
            // 
            // txtFL
            // 
            this.txtFL.BackColor = System.Drawing.Color.Lime;
            this.txtFL.Enabled = false;
            this.txtFL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFL.Location = new System.Drawing.Point(669, 25);
            this.txtFL.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.txtFL.Name = "txtFL";
            this.txtFL.ReadOnly = true;
            this.txtFL.Size = new System.Drawing.Size(16, 23);
            this.txtFL.TabIndex = 12;
            // 
            // barThrottle
            // 
            this.barThrottle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.barThrottle.Location = new System.Drawing.Point(327, 82);
            this.barThrottle.Name = "barThrottle";
            this.barThrottle.Size = new System.Drawing.Size(163, 21);
            this.barThrottle.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barThrottle.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(240, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "Brake";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Throttle";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSpeed.Location = new System.Drawing.Point(84, 103);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(19, 21);
            this.lblSpeed.TabIndex = 7;
            this.lblSpeed.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Speed";
            // 
            // lblGear
            // 
            this.lblGear.AutoSize = true;
            this.lblGear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGear.Location = new System.Drawing.Point(84, 82);
            this.lblGear.Name = "lblGear";
            this.lblGear.Size = new System.Drawing.Size(19, 21);
            this.lblGear.TabIndex = 5;
            this.lblGear.Text = "0";
            // 
            // lblLap
            // 
            this.lblLap.AutoSize = true;
            this.lblLap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLap.Location = new System.Drawing.Point(84, 61);
            this.lblLap.Name = "lblLap";
            this.lblLap.Size = new System.Drawing.Size(19, 21);
            this.lblLap.TabIndex = 4;
            this.lblLap.Text = "0";
            // 
            // lblRecordId
            // 
            this.lblRecordId.AutoSize = true;
            this.lblRecordId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecordId.Location = new System.Drawing.Point(84, 40);
            this.lblRecordId.Name = "lblRecordId";
            this.lblRecordId.Size = new System.Drawing.Size(19, 21);
            this.lblRecordId.TabIndex = 3;
            this.lblRecordId.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gear";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Time";
            // 
            // lstDebug
            // 
            this.lstDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDebug.FormattingEnabled = true;
            this.lstDebug.ItemHeight = 15;
            this.lstDebug.Location = new System.Drawing.Point(12, 529);
            this.lstDebug.Name = "lstDebug";
            this.lstDebug.Size = new System.Drawing.Size(776, 49);
            this.lstDebug.TabIndex = 4;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStop.Location = new System.Drawing.Point(339, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(449, 29);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop recording";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnSelect);
            this.groupBox2.Controls.Add(this.txtPath);
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Controls.Add(this.ddlType);
            this.groupBox2.Controls.Add(this.ddlLap);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.lblLapCount);
            this.groupBox2.Controls.Add(this.lblRecordCount);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 142);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recorded data";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 21);
            this.label14.TabIndex = 21;
            this.label14.Text = "File";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(474, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 21);
            this.label13.TabIndex = 20;
            this.label13.Text = "Lap";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(371, 103);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(36, 30);
            this.btnSelect.TabIndex = 16;
            this.btnSelect.Text = "...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(84, 104);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(281, 29);
            this.txtPath.TabIndex = 15;
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(671, 103);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(99, 29);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // ddlType
            // 
            this.ddlType.AutoCompleteCustomSource.AddRange(new string[] {
            "CSV",
            "JSON"});
            this.ddlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlType.FormattingEnabled = true;
            this.ddlType.Items.AddRange(new object[] {
            "CSV",
            "JSON"});
            this.ddlType.Location = new System.Drawing.Point(594, 103);
            this.ddlType.Name = "ddlType";
            this.ddlType.Size = new System.Drawing.Size(71, 29);
            this.ddlType.TabIndex = 13;
            // 
            // ddlLap
            // 
            this.ddlLap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlLap.FormattingEnabled = true;
            this.ddlLap.Location = new System.Drawing.Point(517, 104);
            this.ddlLap.Name = "ddlLap";
            this.ddlLap.Size = new System.Drawing.Size(71, 29);
            this.ddlLap.TabIndex = 12;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(671, 21);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 32);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblLapCount
            // 
            this.lblLapCount.AutoSize = true;
            this.lblLapCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLapCount.Location = new System.Drawing.Point(84, 53);
            this.lblLapCount.Name = "lblLapCount";
            this.lblLapCount.Size = new System.Drawing.Size(19, 21);
            this.lblLapCount.TabIndex = 10;
            this.lblLapCount.Text = "0";
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecordCount.Location = new System.Drawing.Point(84, 32);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(19, 21);
            this.lblRecordCount.TabIndex = 8;
            this.lblRecordCount.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Records";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Laps";
            // 
            // timRecordUpdate
            // 
            this.timRecordUpdate.Interval = 1000;
            this.timRecordUpdate.Tick += new System.EventHandler(this.timRecordUpdate_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTrackname);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.lblLapsImported);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.btnCreateTrack);
            this.groupBox3.Controls.Add(this.ddlTrackRight);
            this.groupBox3.Controls.Add(this.ddlTrackLeft);
            this.groupBox3.Controls.Add(this.ddlRaceline);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.btnLoad);
            this.groupBox3.Controls.Add(this.txtDatafile);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(12, 383);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 140);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extract track";
            // 
            // txtTrackname
            // 
            this.txtTrackname.Location = new System.Drawing.Point(84, 105);
            this.txtTrackname.Name = "txtTrackname";
            this.txtTrackname.Size = new System.Drawing.Size(281, 29);
            this.txtTrackname.TabIndex = 30;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 109);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 21);
            this.label21.TabIndex = 29;
            this.label21.Text = "Trackname";
            // 
            // lblLapsImported
            // 
            this.lblLapsImported.AutoSize = true;
            this.lblLapsImported.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLapsImported.Location = new System.Drawing.Point(84, 74);
            this.lblLapsImported.Name = "lblLapsImported";
            this.lblLapsImported.Size = new System.Drawing.Size(19, 21);
            this.lblLapsImported.TabIndex = 22;
            this.lblLapsImported.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 74);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 21);
            this.label20.TabIndex = 28;
            this.label20.Text = "Laps";
            // 
            // btnCreateTrack
            // 
            this.btnCreateTrack.Enabled = false;
            this.btnCreateTrack.Location = new System.Drawing.Point(624, 103);
            this.btnCreateTrack.Name = "btnCreateTrack";
            this.btnCreateTrack.Size = new System.Drawing.Size(146, 31);
            this.btnCreateTrack.TabIndex = 27;
            this.btnCreateTrack.Text = "Create track";
            this.btnCreateTrack.UseVisualStyleBackColor = true;
            this.btnCreateTrack.Click += new System.EventHandler(this.btnCreateTrack_Click);
            // 
            // ddlTrackRight
            // 
            this.ddlTrackRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTrackRight.FormattingEnabled = true;
            this.ddlTrackRight.Location = new System.Drawing.Point(517, 106);
            this.ddlTrackRight.Name = "ddlTrackRight";
            this.ddlTrackRight.Size = new System.Drawing.Size(71, 29);
            this.ddlTrackRight.TabIndex = 26;
            // 
            // ddlTrackLeft
            // 
            this.ddlTrackLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTrackLeft.FormattingEnabled = true;
            this.ddlTrackLeft.Location = new System.Drawing.Point(517, 71);
            this.ddlTrackLeft.Name = "ddlTrackLeft";
            this.ddlTrackLeft.Size = new System.Drawing.Size(71, 29);
            this.ddlTrackLeft.TabIndex = 25;
            // 
            // ddlRaceline
            // 
            this.ddlRaceline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlRaceline.FormattingEnabled = true;
            this.ddlRaceline.Location = new System.Drawing.Point(517, 36);
            this.ddlRaceline.Name = "ddlRaceline";
            this.ddlRaceline.Size = new System.Drawing.Size(71, 29);
            this.ddlRaceline.TabIndex = 22;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(424, 109);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 21);
            this.label19.TabIndex = 24;
            this.label19.Text = "Track Right";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(435, 74);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 21);
            this.label18.TabIndex = 23;
            this.label18.Text = "Track Left";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(517, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 21);
            this.label17.TabIndex = 22;
            this.label17.Text = "Lap";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(443, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 21);
            this.label16.TabIndex = 22;
            this.label16.Text = "Raceline";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(371, 33);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(36, 29);
            this.btnLoad.TabIndex = 22;
            this.btnLoad.Text = "...";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtDatafile
            // 
            this.txtDatafile.Location = new System.Drawing.Point(84, 33);
            this.txtDatafile.Name = "txtDatafile";
            this.txtDatafile.Size = new System.Drawing.Size(281, 29);
            this.txtDatafile.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 21);
            this.label15.TabIndex = 22;
            this.label15.Text = "File";
            // 
            // GT7Logger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lstDebug);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Name = "GT7Logger";
            this.Text = "GT7 Logger";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtIP;
        private Button btnStart;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblSpeed;
        private Label label5;
        private Label lblGear;
        private Label lblLap;
        private Label lblRecordId;
        private ListBox lstDebug;
        private Button btnStop;
        private GroupBox groupBox2;
        private Label lblLapCount;
        private Label lblRecordCount;
        private Label label7;
        private Label label6;
        private Button btnReset;
        private System.Windows.Forms.Timer timRecordUpdate;
        private Button btnExport;
        private ComboBox ddlType;
        private ComboBox ddlLap;
        private Button btnSelect;
        private TextBox txtPath;
        private Label label8;
        private ProgressBar barThrottle;
        private Label label9;
        private TextBox txtRR;
        private TextBox txtRL;
        private TextBox txtFR;
        private Label label11;
        private Label label10;
        private TextBox txtFL;
        private ProgressBar barRPM;
        private Label label12;
        private Label label13;
        private Label lblRR;
        private Label lblRL;
        private Label lblFR;
        private Label lblFL;
        private ProgressBar barBrake;
        private Label lblBrake;
        private Label lblThrottle;
        private Label lblRPM;
        private Label label14;
        private GroupBox groupBox3;
        private Label label18;
        private Label label17;
        private Label label16;
        private Button btnLoad;
        private TextBox txtDatafile;
        private Label label15;
        private Button btnCreateTrack;
        private ComboBox ddlTrackRight;
        private ComboBox ddlTrackLeft;
        private ComboBox ddlRaceline;
        private Label label19;
        private Label lblLapsImported;
        private Label label20;
        private Label label21;
        private TextBox txtTrackname;
    }
}