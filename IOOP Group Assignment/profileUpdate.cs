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
    public partial class profileUpdate : Form
    {
        
        public profileUpdate()
        {
            InitializeComponent();
        }

        public static int userID;
        public profileUpdate(int ID)
        {
            InitializeComponent();
            userID = ID;
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            user o1 = new user(userID);
            string role = o1.getRole();
            if (role == "admin")
            {
                adminMainMenu s = new adminMainMenu(userID);
                s.Show();
            }
            else if (role == "receptionist")
            {
                receptionistMenu s = new receptionistMenu(userID);
                s.Show();
            }
            else if (role == "customer")
            {
                customerMenu s = new customerMenu(userID);
                s.Show();
            }
            else if (role == "technician")
            {
                technicianMenu s = new technicianMenu(userID);
                s.Show();
            }
            this.Hide();
        }

        private void profileUpdate_Load(object sender, EventArgs e)
        {
            lblID.Text = "User ID: " + userID.ToString();
            prof();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            prof(); 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            user o1 = new user(userID);
            MessageBox.Show(o1.updateProfile(txtTel.Text, txtEmail.Text, txtAddress.Text));
        }

        void prof()
        {
            user o1 = new user(userID);
            user.prof(o1);
            lblName.Text = o1.Name;
            lblUserID.Text = userID.ToString();
            lblIden.Text = o1.Role;
            lblDOB.Text = o1.Dob;
            if (o1.Gender == true)
            {
                lblGender.Text = "Male";
            }
            else
            {
                lblGender.Text = "Female";
            }
            txtTel.Text = o1.Tel;
            txtEmail.Text = o1.Email;
            txtAddress.Text = o1.Address;
        }
    }
}
