using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Group_Assignment
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtPass.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int ID;
            if (int.TryParse(txtID.Text, out ID))
            {
                string stat;
                user obj1 = new user(ID, txtPass.Text);
                stat = obj1.login(ID);
                if (stat != null)
                { MessageBox.Show(stat); }
                else
                {
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Please enter integer value for User ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtID.Text = string.Empty;
            txtPass.Text = string.Empty;
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }
    }
}
