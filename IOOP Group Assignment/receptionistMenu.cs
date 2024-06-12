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
    public partial class receptionistMenu : Form
    {
        public static int userID;
        public static string role;
        public receptionistMenu()
        {
            InitializeComponent();
        }

        public receptionistMenu(int ID)
        {
            InitializeComponent();
            userID = ID;
        }

        private void receptionistMenu_Load(object sender, EventArgs e)
        {
            lblID.Text = "User ID: " + userID.ToString();
        }

        private void btnProfUp_Click(object sender, EventArgs e)
        {
            profileUpdate f1 = new profileUpdate(userID);
            f1.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            login f1 = new login();
            f1.Show();
            this.Hide();
        }

        private void btnCustRegister_Click(object sender, EventArgs e)
        {
            customerRegistration f1 = new customerRegistration(userID);
            f1.Show();
            this.Hide();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            serviceRequest f1 = new serviceRequest(userID);
            f1.Show();
            this.Hide();
        }

        private void btnPayProcess_Click(object sender, EventArgs e)
        {
            customerSearch f1 = new customerSearch(userID);
            f1.Show();
            this.Hide();
        }
    }
}
