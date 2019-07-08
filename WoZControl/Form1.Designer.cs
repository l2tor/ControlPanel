namespace WoZControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_scene = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnVAD = new System.Windows.Forms.Button();
            this.lbl_task_id = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_task_type = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnResetGaze = new System.Windows.Forms.Button();
            this.btnQi = new System.Windows.Forms.Button();
            this.txtSay = new System.Windows.Forms.TextBox();
            this.btnSay = new System.Windows.Forms.Button();
            this.btncrouch = new System.Windows.Forms.Button();
            this.groupStatus = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblStatusKinectModule = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblStatusuwds = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblStatusControlPanel = new System.Windows.Forms.Label();
            this.lblStatusoutputmanager = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblStatustabletgame = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblStatusinteractionmanager = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_unload_memory = new System.Windows.Forms.Button();
            this.btn_save_memory = new System.Windows.Forms.Button();
            this.btn_delete_memory = new System.Windows.Forms.Button();
            this.btn_refresh_memory = new System.Windows.Forms.Button();
            this.btn_load_memory = new System.Windows.Forms.Button();
            this.btn_new_memory = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.ddlMemories = new System.Windows.Forms.ComboBox();
            this.lblChildName = new System.Windows.Forms.Label();
            this.txtChildName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtuserID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.cmdResume = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_lang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ddlSessions = new System.Windows.Forms.ComboBox();
            this.cmdFinish = new System.Windows.Forms.Button();
            this.cmdPause = new System.Windows.Forms.Button();
            this.cmdIntro = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupStatus.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_scene);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnVAD);
            this.groupBox1.Controls.Add(this.lbl_task_id);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_task_type);
            this.groupBox1.Location = new System.Drawing.Point(12, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 53);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interaction Controls";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(362, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Scene:";
            // 
            // lbl_scene
            // 
            this.lbl_scene.AutoSize = true;
            this.lbl_scene.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scene.Location = new System.Drawing.Point(427, 25);
            this.lbl_scene.Name = "lbl_scene";
            this.lbl_scene.Size = new System.Drawing.Size(11, 15);
            this.lbl_scene.TabIndex = 18;
            this.lbl_scene.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(78, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Type:";
            // 
            // btnVAD
            // 
            this.btnVAD.Enabled = false;
            this.btnVAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVAD.ForeColor = System.Drawing.Color.Black;
            this.btnVAD.Location = new System.Drawing.Point(633, 15);
            this.btnVAD.Name = "btnVAD";
            this.btnVAD.Size = new System.Drawing.Size(106, 32);
            this.btnVAD.TabIndex = 15;
            this.btnVAD.Text = "Correct Word";
            this.btnVAD.UseVisualStyleBackColor = true;
            this.btnVAD.Click += new System.EventHandler(this.btnVAD_Click);
            // 
            // lbl_task_id
            // 
            this.lbl_task_id.AutoSize = true;
            this.lbl_task_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_task_id.Location = new System.Drawing.Point(49, 25);
            this.lbl_task_id.Name = "lbl_task_id";
            this.lbl_task_id.Size = new System.Drawing.Size(11, 15);
            this.lbl_task_id.TabIndex = 3;
            this.lbl_task_id.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(5, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Task:";
            // 
            // lbl_task_type
            // 
            this.lbl_task_type.AutoSize = true;
            this.lbl_task_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_task_type.Location = new System.Drawing.Point(127, 25);
            this.lbl_task_type.Name = "lbl_task_type";
            this.lbl_task_type.Size = new System.Drawing.Size(11, 15);
            this.lbl_task_type.TabIndex = 0;
            this.lbl_task_type.Text = "-";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnResetGaze);
            this.groupBox2.Controls.Add(this.btnQi);
            this.groupBox2.Controls.Add(this.txtSay);
            this.groupBox2.Controls.Add(this.btnSay);
            this.groupBox2.Controls.Add(this.btncrouch);
            this.groupBox2.Location = new System.Drawing.Point(12, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 122);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Robot Controls";
            // 
            // btnResetGaze
            // 
            this.btnResetGaze.Enabled = false;
            this.btnResetGaze.Location = new System.Drawing.Point(9, 50);
            this.btnResetGaze.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetGaze.Name = "btnResetGaze";
            this.btnResetGaze.Size = new System.Drawing.Size(164, 23);
            this.btnResetGaze.TabIndex = 13;
            this.btnResetGaze.Text = "Reset gaze direction";
            this.btnResetGaze.UseVisualStyleBackColor = true;
            this.btnResetGaze.Click += new System.EventHandler(this.btnResetGaze_Click);
            // 
            // btnQi
            // 
            this.btnQi.Enabled = false;
            this.btnQi.Location = new System.Drawing.Point(180, 21);
            this.btnQi.Name = "btnQi";
            this.btnQi.Size = new System.Drawing.Size(158, 23);
            this.btnQi.TabIndex = 9;
            this.btnQi.Text = "Motors off";
            this.btnQi.UseVisualStyleBackColor = true;
            this.btnQi.Click += new System.EventHandler(this.btnQi_Click);
            // 
            // txtSay
            // 
            this.txtSay.Location = new System.Drawing.Point(100, 83);
            this.txtSay.Multiline = true;
            this.txtSay.Name = "txtSay";
            this.txtSay.Size = new System.Drawing.Size(239, 26);
            this.txtSay.TabIndex = 8;
            this.txtSay.Text = "wacht even";
            // 
            // btnSay
            // 
            this.btnSay.Enabled = false;
            this.btnSay.Location = new System.Drawing.Point(10, 81);
            this.btnSay.Name = "btnSay";
            this.btnSay.Size = new System.Drawing.Size(84, 26);
            this.btnSay.TabIndex = 7;
            this.btnSay.Text = "Robot Speech";
            this.btnSay.UseVisualStyleBackColor = true;
            this.btnSay.Click += new System.EventHandler(this.btnSay_Click);
            // 
            // btncrouch
            // 
            this.btncrouch.Enabled = false;
            this.btncrouch.Location = new System.Drawing.Point(9, 21);
            this.btncrouch.Name = "btncrouch";
            this.btncrouch.Size = new System.Drawing.Size(164, 23);
            this.btncrouch.TabIndex = 3;
            this.btncrouch.Text = "Crouch";
            this.btncrouch.UseVisualStyleBackColor = true;
            this.btncrouch.Click += new System.EventHandler(this.btncrouch_Click);
            // 
            // groupStatus
            // 
            this.groupStatus.Controls.Add(this.label17);
            this.groupStatus.Controls.Add(this.lblStatusKinectModule);
            this.groupStatus.Controls.Add(this.label15);
            this.groupStatus.Controls.Add(this.lblStatusuwds);
            this.groupStatus.Controls.Add(this.label13);
            this.groupStatus.Controls.Add(this.lblStatusControlPanel);
            this.groupStatus.Controls.Add(this.lblStatusoutputmanager);
            this.groupStatus.Controls.Add(this.label11);
            this.groupStatus.Controls.Add(this.lblStatustabletgame);
            this.groupStatus.Controls.Add(this.label10);
            this.groupStatus.Controls.Add(this.lblStatusinteractionmanager);
            this.groupStatus.Controls.Add(this.label7);
            this.groupStatus.Location = new System.Drawing.Point(12, 82);
            this.groupStatus.Name = "groupStatus";
            this.groupStatus.Size = new System.Drawing.Size(344, 83);
            this.groupStatus.TabIndex = 39;
            this.groupStatus.TabStop = false;
            this.groupStatus.Text = "Module Status";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(193, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 17);
            this.label17.TabIndex = 23;
            this.label17.Text = "KinectVAD:";
            // 
            // lblStatusKinectModule
            // 
            this.lblStatusKinectModule.AutoSize = true;
            this.lblStatusKinectModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusKinectModule.ForeColor = System.Drawing.Color.Red;
            this.lblStatusKinectModule.Location = new System.Drawing.Point(287, 58);
            this.lblStatusKinectModule.Name = "lblStatusKinectModule";
            this.lblStatusKinectModule.Size = new System.Drawing.Size(56, 17);
            this.lblStatusKinectModule.TabIndex = 22;
            this.lblStatusKinectModule.Text = "Offline";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(193, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 17);
            this.label15.TabIndex = 21;
            this.label15.Text = "Underworlds:";
            // 
            // lblStatusuwds
            // 
            this.lblStatusuwds.AutoSize = true;
            this.lblStatusuwds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusuwds.ForeColor = System.Drawing.Color.Red;
            this.lblStatusuwds.Location = new System.Drawing.Point(287, 40);
            this.lblStatusuwds.Name = "lblStatusuwds";
            this.lblStatusuwds.Size = new System.Drawing.Size(56, 17);
            this.lblStatusuwds.TabIndex = 20;
            this.lblStatusuwds.Text = "Offline";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(193, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 17);
            this.label13.TabIndex = 19;
            this.label13.Text = "ControlPanel:";
            // 
            // lblStatusControlPanel
            // 
            this.lblStatusControlPanel.AutoSize = true;
            this.lblStatusControlPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusControlPanel.ForeColor = System.Drawing.Color.Red;
            this.lblStatusControlPanel.Location = new System.Drawing.Point(287, 22);
            this.lblStatusControlPanel.Name = "lblStatusControlPanel";
            this.lblStatusControlPanel.Size = new System.Drawing.Size(56, 17);
            this.lblStatusControlPanel.TabIndex = 18;
            this.lblStatusControlPanel.Text = "Offline";
            // 
            // lblStatusoutputmanager
            // 
            this.lblStatusoutputmanager.AutoSize = true;
            this.lblStatusoutputmanager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusoutputmanager.ForeColor = System.Drawing.Color.Red;
            this.lblStatusoutputmanager.Location = new System.Drawing.Point(131, 40);
            this.lblStatusoutputmanager.Name = "lblStatusoutputmanager";
            this.lblStatusoutputmanager.Size = new System.Drawing.Size(56, 17);
            this.lblStatusoutputmanager.TabIndex = 17;
            this.lblStatusoutputmanager.Text = "Offline";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Tabletgame:";
            // 
            // lblStatustabletgame
            // 
            this.lblStatustabletgame.AutoSize = true;
            this.lblStatustabletgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatustabletgame.ForeColor = System.Drawing.Color.Red;
            this.lblStatustabletgame.Location = new System.Drawing.Point(131, 58);
            this.lblStatustabletgame.Name = "lblStatustabletgame";
            this.lblStatustabletgame.Size = new System.Drawing.Size(56, 17);
            this.lblStatustabletgame.TabIndex = 15;
            this.lblStatustabletgame.Text = "Offline";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Outputmanager:";
            // 
            // lblStatusinteractionmanager
            // 
            this.lblStatusinteractionmanager.AutoSize = true;
            this.lblStatusinteractionmanager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusinteractionmanager.ForeColor = System.Drawing.Color.Red;
            this.lblStatusinteractionmanager.Location = new System.Drawing.Point(131, 22);
            this.lblStatusinteractionmanager.Name = "lblStatusinteractionmanager";
            this.lblStatusinteractionmanager.Size = new System.Drawing.Size(56, 17);
            this.lblStatusinteractionmanager.TabIndex = 13;
            this.lblStatusinteractionmanager.Text = "Offline";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Interactionmanager:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_unload_memory);
            this.groupBox4.Controls.Add(this.btn_save_memory);
            this.groupBox4.Controls.Add(this.btn_delete_memory);
            this.groupBox4.Controls.Add(this.btn_refresh_memory);
            this.groupBox4.Controls.Add(this.btn_load_memory);
            this.groupBox4.Controls.Add(this.btn_new_memory);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.ddlMemories);
            this.groupBox4.Controls.Add(this.lblChildName);
            this.groupBox4.Controls.Add(this.txtChildName);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtuserID);
            this.groupBox4.Location = new System.Drawing.Point(399, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(364, 105);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Child Information";
            // 
            // btn_unload_memory
            // 
            this.btn_unload_memory.Enabled = false;
            this.btn_unload_memory.Location = new System.Drawing.Point(137, 76);
            this.btn_unload_memory.Margin = new System.Windows.Forms.Padding(2);
            this.btn_unload_memory.Name = "btn_unload_memory";
            this.btn_unload_memory.Size = new System.Drawing.Size(52, 24);
            this.btn_unload_memory.TabIndex = 49;
            this.btn_unload_memory.Text = "Unload";
            this.btn_unload_memory.UseVisualStyleBackColor = true;
            this.btn_unload_memory.Click += new System.EventHandler(this.btn_unload_Click);
            // 
            // btn_save_memory
            // 
            this.btn_save_memory.Enabled = false;
            this.btn_save_memory.Location = new System.Drawing.Point(230, 76);
            this.btn_save_memory.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save_memory.Name = "btn_save_memory";
            this.btn_save_memory.Size = new System.Drawing.Size(52, 24);
            this.btn_save_memory.TabIndex = 48;
            this.btn_save_memory.Text = "Save";
            this.btn_save_memory.UseVisualStyleBackColor = true;
            this.btn_save_memory.Click += new System.EventHandler(this.btn_save_memory_Click);
            // 
            // btn_delete_memory
            // 
            this.btn_delete_memory.Enabled = false;
            this.btn_delete_memory.Location = new System.Drawing.Point(291, 76);
            this.btn_delete_memory.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete_memory.Name = "btn_delete_memory";
            this.btn_delete_memory.Size = new System.Drawing.Size(52, 24);
            this.btn_delete_memory.TabIndex = 47;
            this.btn_delete_memory.Text = "Delete";
            this.btn_delete_memory.UseVisualStyleBackColor = true;
            this.btn_delete_memory.Click += new System.EventHandler(this.btn_delete_memory_Click);
            // 
            // btn_refresh_memory
            // 
            this.btn_refresh_memory.Image = global::WoZControl.Properties.Resources.refresh_20;
            this.btn_refresh_memory.Location = new System.Drawing.Point(320, 20);
            this.btn_refresh_memory.Margin = new System.Windows.Forms.Padding(2);
            this.btn_refresh_memory.Name = "btn_refresh_memory";
            this.btn_refresh_memory.Size = new System.Drawing.Size(32, 47);
            this.btn_refresh_memory.TabIndex = 46;
            this.btn_refresh_memory.UseVisualStyleBackColor = true;
            this.btn_refresh_memory.Click += new System.EventHandler(this.btn_refresh_lists_Click);
            // 
            // btn_load_memory
            // 
            this.btn_load_memory.Enabled = false;
            this.btn_load_memory.Location = new System.Drawing.Point(76, 76);
            this.btn_load_memory.Margin = new System.Windows.Forms.Padding(2);
            this.btn_load_memory.Name = "btn_load_memory";
            this.btn_load_memory.Size = new System.Drawing.Size(52, 24);
            this.btn_load_memory.TabIndex = 45;
            this.btn_load_memory.Text = "Load";
            this.btn_load_memory.UseVisualStyleBackColor = true;
            this.btn_load_memory.Click += new System.EventHandler(this.btn_load_memory_Click);
            // 
            // btn_new_memory
            // 
            this.btn_new_memory.Enabled = false;
            this.btn_new_memory.Location = new System.Drawing.Point(15, 76);
            this.btn_new_memory.Margin = new System.Windows.Forms.Padding(2);
            this.btn_new_memory.Name = "btn_new_memory";
            this.btn_new_memory.Size = new System.Drawing.Size(52, 24);
            this.btn_new_memory.TabIndex = 44;
            this.btn_new_memory.Text = "New";
            this.btn_new_memory.UseVisualStyleBackColor = true;
            this.btn_new_memory.Click += new System.EventHandler(this.btn_new_memory_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Child-Memory:";
            // 
            // ddlMemories
            // 
            this.ddlMemories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMemories.FormattingEnabled = true;
            this.ddlMemories.Location = new System.Drawing.Point(81, 19);
            this.ddlMemories.Name = "ddlMemories";
            this.ddlMemories.Size = new System.Drawing.Size(229, 21);
            this.ddlMemories.TabIndex = 42;
            this.ddlMemories.SelectedIndexChanged += new System.EventHandler(this.ddlMemories_SelectedIndexChanged);
            // 
            // lblChildName
            // 
            this.lblChildName.AutoSize = true;
            this.lblChildName.Location = new System.Drawing.Point(132, 49);
            this.lblChildName.Name = "lblChildName";
            this.lblChildName.Size = new System.Drawing.Size(38, 13);
            this.lblChildName.TabIndex = 14;
            this.lblChildName.Text = "Name:";
            // 
            // txtChildName
            // 
            this.txtChildName.Enabled = false;
            this.txtChildName.Location = new System.Drawing.Point(172, 47);
            this.txtChildName.Name = "txtChildName";
            this.txtChildName.Size = new System.Drawing.Size(138, 20);
            this.txtChildName.TabIndex = 13;
            this.txtChildName.TextChanged += new System.EventHandler(this.txtChildName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Child ID:";
            // 
            // txtuserID
            // 
            this.txtuserID.Enabled = false;
            this.txtuserID.Location = new System.Drawing.Point(60, 47);
            this.txtuserID.Name = "txtuserID";
            this.txtuserID.Size = new System.Drawing.Size(58, 20);
            this.txtuserID.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtIP);
            this.groupBox3.Controls.Add(this.btnDisconnect);
            this.groupBox3.Controls.Add(this.btnConnect);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 64);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Network";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "IP:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(52, 28);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(86, 20);
            this.txtIP.TabIndex = 15;
            this.txtIP.Text = "127.0.0.1";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(236, 19);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(79, 35);
            this.btnDisconnect.TabIndex = 14;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(148, 19);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(82, 35);
            this.btnConnect.TabIndex = 13;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnContinue);
            this.groupBox5.Controls.Add(this.cmdResume);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.cb_lang);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.ddlSessions);
            this.groupBox5.Controls.Add(this.cmdFinish);
            this.groupBox5.Controls.Add(this.cmdPause);
            this.groupBox5.Controls.Add(this.cmdIntro);
            this.groupBox5.Location = new System.Drawing.Point(399, 123);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(364, 171);
            this.groupBox5.TabIndex = 44;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Session Control";
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(186, 23);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(168, 21);
            this.btnContinue.TabIndex = 53;
            this.btnContinue.Text = "Continue Lesson";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // cmdResume
            // 
            this.cmdResume.Enabled = false;
            this.cmdResume.Location = new System.Drawing.Point(10, 92);
            this.cmdResume.Name = "cmdResume";
            this.cmdResume.Size = new System.Drawing.Size(93, 26);
            this.cmdResume.TabIndex = 52;
            this.cmdResume.Text = "Resume";
            this.cmdResume.UseVisualStyleBackColor = true;
            this.cmdResume.Click += new System.EventHandler(this.cmdResume_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Language:";
            // 
            // cb_lang
            // 
            this.cb_lang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_lang.FormattingEnabled = true;
            this.cb_lang.Items.AddRange(new object[] {
            "Dut-Eng",
            "Ger-Eng",
            "Tur-Eng",
            "Tur-Dut"});
            this.cb_lang.Location = new System.Drawing.Point(181, 94);
            this.cb_lang.Name = "cb_lang";
            this.cb_lang.Size = new System.Drawing.Size(171, 21);
            this.cb_lang.TabIndex = 50;
            this.cb_lang.SelectedIndexChanged += new System.EventHandler(this.cb_lang_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Session-File:";
            // 
            // ddlSessions
            // 
            this.ddlSessions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSessions.FormattingEnabled = true;
            this.ddlSessions.Location = new System.Drawing.Point(181, 58);
            this.ddlSessions.Name = "ddlSessions";
            this.ddlSessions.Size = new System.Drawing.Size(172, 21);
            this.ddlSessions.TabIndex = 48;
            this.ddlSessions.SelectedIndexChanged += new System.EventHandler(this.ddlSessions_SelectedIndexChanged);
            // 
            // cmdFinish
            // 
            this.cmdFinish.Enabled = false;
            this.cmdFinish.Location = new System.Drawing.Point(9, 129);
            this.cmdFinish.Name = "cmdFinish";
            this.cmdFinish.Size = new System.Drawing.Size(345, 21);
            this.cmdFinish.TabIndex = 47;
            this.cmdFinish.Text = "Quit Lesson";
            this.cmdFinish.UseVisualStyleBackColor = true;
            this.cmdFinish.Click += new System.EventHandler(this.cmdFinish_Click);
            // 
            // cmdPause
            // 
            this.cmdPause.Enabled = false;
            this.cmdPause.Location = new System.Drawing.Point(10, 55);
            this.cmdPause.Name = "cmdPause";
            this.cmdPause.Size = new System.Drawing.Size(93, 26);
            this.cmdPause.TabIndex = 46;
            this.cmdPause.Text = "Pause";
            this.cmdPause.UseVisualStyleBackColor = true;
            this.cmdPause.Click += new System.EventHandler(this.cmdPause_Click);
            // 
            // cmdIntro
            // 
            this.cmdIntro.Location = new System.Drawing.Point(10, 23);
            this.cmdIntro.Name = "cmdIntro";
            this.cmdIntro.Size = new System.Drawing.Size(168, 21);
            this.cmdIntro.TabIndex = 45;
            this.cmdIntro.Text = "Start Lesson";
            this.cmdIntro.UseVisualStyleBackColor = true;
            this.cmdIntro.Click += new System.EventHandler(this.cmdIntro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 360);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupStatus);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupStatus.ResumeLayout(false);
            this.groupStatus.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_task_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_task_type;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnQi;
        private System.Windows.Forms.TextBox txtSay;
        private System.Windows.Forms.Button btnSay;
        private System.Windows.Forms.Button btncrouch;
        private System.Windows.Forms.GroupBox groupStatus;
        private System.Windows.Forms.Label lblStatusoutputmanager;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblStatustabletgame;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblStatusinteractionmanager;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblChildName;
        private System.Windows.Forms.TextBox txtChildName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtuserID;
        private System.Windows.Forms.Button btn_new_memory;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ddlMemories;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblStatusuwds;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblStatusControlPanel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblStatusKinectModule;
        private System.Windows.Forms.Button btn_load_memory;
        private System.Windows.Forms.Button btnResetGaze;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button cmdResume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_lang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ddlSessions;
        private System.Windows.Forms.Button cmdFinish;
        private System.Windows.Forms.Button cmdPause;
        private System.Windows.Forms.Button cmdIntro;
        private System.Windows.Forms.Button btn_refresh_memory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnVAD;
        private System.Windows.Forms.Button btn_delete_memory;
        private System.Windows.Forms.Button btn_save_memory;
        private System.Windows.Forms.Button btn_unload_memory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_scene;
        private System.Windows.Forms.Button btnContinue;
    }
}

