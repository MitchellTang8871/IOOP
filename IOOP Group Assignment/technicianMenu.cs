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
    public partial class technicianMenu : Form
    {
        public static int userID;
        public technicianMenu(int ID)
        {
            InitializeComponent();
            userID = ID;
        }

        public technicianMenu()
        {
            InitializeComponent();  
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblID.Text = "User ID: " + userID.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProfUp_Click(object sender, EventArgs e)
        {
            profileUpdate f1 = new profileUpdate(userID);
            f1.Show();
            this.Hide();
        }

        private void btnViewService_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerServiceRequest f1 = new customerServiceRequest(userID);
            f1.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            login f1 = new login();
            f1.ShowDialog();
        }
    }
}
