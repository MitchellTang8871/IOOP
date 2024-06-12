using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IOOP_Group_Assignment
{
    public partial class customerTradingHistory : Form
    {
        
       
        public customerTradingHistory()
        {
            InitializeComponent();
        }
        public static int userID;
        
        public customerTradingHistory(int ID)
        {
            InitializeComponent();
            userID = ID;
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {   this.Hide(); 
            customerMenu f1 = new customerMenu();
            f1.Show();
        }

        private void customerTradingHistory_Load(object sender, EventArgs e)
        {
            lblID.Text = "User ID: " + userID.ToString();
            Customer f1 = new Customer(userID);
            dgv1.DataSource = f1.disCustTrade();
            lblCustID.Text = userID.ToString();

        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int receiptID;
            int custID;
            receiptID = int.Parse(dgv1.Rows[e.RowIndex].Cells["receiptID"].Value.ToString());
            custID = int.Parse(dgv1.Rows[e.RowIndex].Cells["custID"].Value.ToString());
            serviceInfo f1 = new serviceInfo(userID, custID, receiptID);
            f1.Show();
            this.Hide();
        }
    }
}
