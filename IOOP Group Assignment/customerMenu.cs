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
    public partial class customerMenu : Form
    {
        public customerMenu()
        {
            InitializeComponent();
        }
        public static int userID;
        public customerMenu(int ID)
        {
            InitializeComponent();
            userID = ID;
        }

        private void btnServiceInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerTradingHistory f1 = new customerTradingHistory(userID);
            f1.Show();
           
        }

        private void btnProfUp_Click(object sender, EventArgs e)
        {
            // profile update
            this.Hide();
            profileUpdate f1 = new profileUpdate(userID);
            f1.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            login f1 = new login();
            f1.Show();
        }

        private void customerMenu_Load_1(object sender, EventArgs e)
        {
            lblID.Text = "User ID: " + userID.ToString();
        }
    }
}
