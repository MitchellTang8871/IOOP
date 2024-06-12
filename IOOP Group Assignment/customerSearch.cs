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
    public partial class customerSearch : Form
    {
        public customerSearch()
        {
            InitializeComponent();
        }
        public static int userID;
        public customerSearch(int ID)
        {
            InitializeComponent();
            userID = ID;
        }

        private void customerSearch_Load(object sender, EventArgs e)
        {
            lblID.Text = "User ID: " + userID.ToString();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            receptionistMenu f1 = new receptionistMenu();
            f1.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string stat;
            if (txtCustID.Text != "" && int.TryParse(txtCustID.Text, out int custID))
            {
                user obj1 = new user(custID);
                stat = obj1.searchCust();
                if (stat == null)
                {
                    customerHistory f1 = new customerHistory(userID, custID);
                    f1.Show();
                    this.Hide();
                }
                else
                { MessageBox.Show(stat); }
            }
            else
            {
                MessageBox.Show("Invalid input for Customer ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
