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
    public partial class employeeRegistration : Form
    {
        public static int userID;
        public employeeRegistration(int ID)
        {
            InitializeComponent();
            userID = ID;
    }

        private void employeeRegistration_Load(object sender, EventArgs e)
        {
            lblID.Text = "User ID:" + userID.ToString();
            getNewID();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            adminMainMenu am = new adminMainMenu(userID);
            am.Show();
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtEmail.Text != "" && txtPass.Text != "" && txtAddress.Text != "" && cmbIden.SelectedIndex != -1)
            {
                if (int.TryParse(txtTel.Text, out int value))
                {
                    if (rbtnM.Checked || rbtnF.Checked)
                    {
                        bool gender;
                        string role = cmbIden.Text;
                        if (rbtnM.Checked)
                        {
                            gender = true;
                        }
                        else
                        {
                            gender = false;
                        }
                        employee obj1 = new employee(txtName.Text, txtPass.Text, role, gender, dtpDOB.Text, txtTel.Text, txtEmail.Text, txtAddress.Text);
                        MessageBox.Show(obj1.addEmployee());
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

        void clear()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPass.Clear();
            txtTel.Clear();
            txtAddress.Clear();
            dtpDOB.Value = DateTime.Now;
            rbtnM.Checked = false;
            rbtnF.Checked = false;
        }

        void getNewID()
        {
            employee o2 = new employee(userID);
            employee.getNewID(o2);
            lblEmpID.Text = o2.NewID.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
