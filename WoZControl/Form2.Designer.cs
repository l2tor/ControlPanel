namespace WoZControl {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.lblschool = new System.Windows.Forms.Label();
            this.txtL1 = new System.Windows.Forms.TextBox();
            this.lbll1 = new System.Windows.Forms.Label();
            this.brithday = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhonName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.conditionllist = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Enabled = false;
            this.btn_ok.Location = new System.Drawing.Point(15, 224);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(88, 23);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(191, 224);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(88, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(5, 44);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(78, 41);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 20);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(78, 90);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(169, 20);
            this.txtID.TabIndex = 5;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(5, 93);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(44, 13);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "Child-ID";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(78, 115);
            this.txtGender.Margin = new System.Windows.Forms.Padding(2);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(169, 20);
            this.txtGender.TabIndex = 7;
            this.txtGender.TextChanged += new System.EventHandler(this.txtGender_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gender";
            // 
            // txtSchool
            // 
            this.txtSchool.Location = new System.Drawing.Point(78, 139);
            this.txtSchool.Margin = new System.Windows.Forms.Padding(2);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.Size = new System.Drawing.Size(169, 20);
            this.txtSchool.TabIndex = 9;
            this.txtSchool.TextChanged += new System.EventHandler(this.txtSchool_TextChanged);
            // 
            // lblschool
            // 
            this.lblschool.AutoSize = true;
            this.lblschool.Location = new System.Drawing.Point(5, 142);
            this.lblschool.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblschool.Name = "lblschool";
            this.lblschool.Size = new System.Drawing.Size(40, 13);
            this.lblschool.TabIndex = 8;
            this.lblschool.Text = "School";
            // 
            // txtL1
            // 
            this.txtL1.Location = new System.Drawing.Point(78, 163);
            this.txtL1.Margin = new System.Windows.Forms.Padding(2);
            this.txtL1.Name = "txtL1";
            this.txtL1.Size = new System.Drawing.Size(169, 20);
            this.txtL1.TabIndex = 11;
            this.txtL1.TextChanged += new System.EventHandler(this.txtL1_TextChanged);
            // 
            // lbll1
            // 
            this.lbll1.AutoSize = true;
            this.lbll1.Location = new System.Drawing.Point(5, 166);
            this.lbll1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbll1.Name = "lbll1";
            this.lbll1.Size = new System.Drawing.Size(19, 13);
            this.lbll1.TabIndex = 10;
            this.lbll1.Text = "L1";
            // 
            // brithday
            // 
            this.brithday.CustomFormat = "MM/dd/yyyy";
            this.brithday.Location = new System.Drawing.Point(78, 189);
            this.brithday.Name = "brithday";
            this.brithday.Size = new System.Drawing.Size(200, 20);
            this.brithday.TabIndex = 12;
            this.brithday.Value = new System.DateTime(2013, 1, 22, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Birthday";
            // 
            // txtPhonName
            // 
            this.txtPhonName.Location = new System.Drawing.Point(78, 65);
            this.txtPhonName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhonName.Name = "txtPhonName";
            this.txtPhonName.Size = new System.Drawing.Size(169, 20);
            this.txtPhonName.TabIndex = 4;
            this.txtPhonName.TextChanged += new System.EventHandler(this.txtPhonName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Phon. Name";
            // 
            // conditionllist
            // 
            this.conditionllist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conditionllist.FormattingEnabled = true;
            this.conditionllist.Items.AddRange(new object[] {
            "Robot + Iconic",
            "Robot + Non-Iconic",
            "Tablet Only"});
            this.conditionllist.Location = new System.Drawing.Point(79, 12);
            this.conditionllist.Name = "conditionllist";
            this.conditionllist.Size = new System.Drawing.Size(202, 21);
            this.conditionllist.TabIndex = 46;
            this.conditionllist.SelectedIndexChanged += new System.EventHandler(this.conditionllist_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Condition:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 257);
            this.Controls.Add(this.conditionllist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhonName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.brithday);
            this.Controls.Add(this.txtL1);
            this.Controls.Add(this.lbll1);
            this.Controls.Add(this.txtSchool);
            this.Controls.Add(this.lblschool);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "New Memory";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSchool;
        private System.Windows.Forms.Label lblschool;
        private System.Windows.Forms.TextBox txtL1;
        private System.Windows.Forms.Label lbll1;
        private System.Windows.Forms.DateTimePicker brithday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhonName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox conditionllist;
        private System.Windows.Forms.Label label4;
    }
}