using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoZControl {
    public partial class Form2 : Form {
        private Form1 parentForm = null;
        public Form2(Form1 form1) {
            parentForm = form1;
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e) {
            if (parentForm.memoryList != null) {
                foreach (string item in parentForm.memoryList) {
                    string tmpName = string.Format("{0}_{1}.mem", this.txtName.Text.Trim(), this.txtID.Text.Trim());
                    Console.WriteLine(";" + item + ";" + tmpName + ";");
                    if (item == tmpName) {

                        MessageBox.Show("This combanation of Child-ID and -Name already exists! Please choose another ID or Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                AsynchronousClient client = parentForm.getTCP();
                client.Send("call:tablet.interactionmanager.create_memory|{\"id\":\"" + this.txtID.Text.Trim() + "\", \"condition\":\"" + conditionllist.SelectedItem + "\", \"name\":\"" + this.txtName.Text.Trim() + "\", \"phon_name\":\"" + this.txtPhonName.Text.Trim() + "\", \"L1\":\"" + this.txtL1.Text.Trim() + "\",  \"gender\":\"" + this.txtGender.Text.Trim() + "\",  \"school\":\"" + this.txtSchool.Text.Trim() + "\",  \"birthday\":\"" + this.brithday.Value.ToString("MM/dd/yyyy").Replace(".", "/") + "\"}");
                this.Dispose();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private Boolean formValid() {
            return this.conditionllist.SelectedIndex != -1 && this.txtName.Text.Trim() != "" && this.txtPhonName.Text.Trim() != "" && this.txtID.Text.Trim() != "" && this.txtL1.Text.Trim() != "" && this.txtGender.Text.Trim() != "" && this.txtSchool.Text.Trim() != "";
        }

        private void txtName_TextChanged(object sender, EventArgs e) {
            this.btn_ok.Enabled = formValid();
        }

        private void txtID_TextChanged(object sender, EventArgs e) {
            this.btn_ok.Enabled = formValid();
        }

        private void Form2_Load(object sender, EventArgs e) {
            this.ActiveControl = this.txtName;
        }

        private void txtGender_TextChanged(object sender, EventArgs e) {
            this.btn_ok.Enabled = formValid();
        }

        private void txtSchool_TextChanged(object sender, EventArgs e) {
            this.btn_ok.Enabled = formValid();
        }

        private void txtL1_TextChanged(object sender, EventArgs e) {
            this.btn_ok.Enabled = formValid();
        }

        private void txtPhonName_TextChanged(object sender, EventArgs e) {
            this.btn_ok.Enabled = formValid();
        }

        private void conditionllist_SelectedIndexChanged(object sender, EventArgs e) {
            this.btn_ok.Enabled = formValid();
        }
    }
}
