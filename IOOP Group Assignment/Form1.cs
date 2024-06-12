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
    public partial class adminMainMenu : Form
    {
        public adminMainMenu()
        {
            InitializeComponent();
        }

        public static int userID;
        public adminMainMenu(int ID)
        {
            InitializeComponent();
            userID = ID;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblID.Text = "User ID:" + userID.ToString();
        }

        private void btnProfUp_Click(object sender, EventArgs e)
        {
            profileUpdate pu = new profileUpdate(userID);
            pu.Show();
            this.Hide();
        }

        private void btnEmpRegister_Click(object sender, EventArgs e)
        {
            employeeRegistration er = new employeeRegistration(userID);
            er.Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            SRFS sr = new SRFS(userID);
            sr.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }
    }
}
