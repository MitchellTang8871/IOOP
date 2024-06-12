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
    public partial class customerRegistration : Form
    {
        public customerRegistration()
        {
            InitializeComponent();
        }
        public static int userID;
        public customerRegistration(int ID)
        {
            InitializeComponent();
            userID = ID;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void customerRegistration_Load(object sender, EventArgs e)
        {
            lblID.Text = "User ID: " + userID.ToString();
            getNewID();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtCustName.Text != "" && txtEmail.Text != "" && txtPass.Text != "" && txtAddress.Text != "")
            {
                if (int.TryParse(txtTel.Text, out int value))
                {
                    if (rbtnM.Checked || rbtnF.Checked)
                    {
                        bool gender;
                        string role = "customer";
                        if (rbtnM.Checked)
                        {
                            gender = true;
                        }
                        else
                        {
                            gender = false;
                        }
                        user obj1 = new user(txtCustName.Text, txtPass.Text, role, gender, dtpDOB.Text, txtTel.Text, txtEmail.Text, txtAddress.Text);
                        MessageBox.Show(obj1.addUser());
                        clear();
                        getNewID();
                        
                    }
                    else
                    {
                        MessageBox.Show("Please select the gender!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter integer value for Tel.No!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            getNewID();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            receptionistMenu f1 = new receptionistMenu();
            f1.Show();
            this.Hide();
        }

        void getNewID()
        {
            user o2 = new user(userID);
            user.getNewID(o2);
            lblUserID.Text = o2.NewID.ToString();
        }

        void clear()
        {
            txtCustName.Clear();
            txtEmail.Clear();
            txtPass.Clear();
            txtTel.Clear();
            txtAddress.Clear();
            dtpDOB.Value = DateTime.Now;
            rbtnM.Checked = false;
            rbtnF.Checked = false;
        }
    }
}
