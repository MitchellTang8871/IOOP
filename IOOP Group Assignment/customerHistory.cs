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
    public partial class customerHistory : Form
    {
        public customerHistory()
        {
            InitializeComponent();
        }
        public static int userID;
        public static int custID;
        public customerHistory(int uID,int cID)
        {
            InitializeComponent();
            userID = uID;
            custID = cID;
        }

        private void customerHistory_Load(object sender, EventArgs e)
        {
            lblID.Text = "User ID: " + userID.ToString();
            lblCustID.Text = custID.ToString();
            request o1 = new request(custID);
            dgv1.DataSource = o1.disCustHis();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            receptionistMenu f1 = new receptionistMenu();
            f1.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            customerSearch f1 = new customerSearch(userID);
            f1.Show();
            this.Hide();
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int receiptID;
            receiptID = int.Parse(dgv1.Rows[e.RowIndex].Cells["receiptID"].Value.ToString());
            paymentProcessing f1 = new paymentProcessing(userID, custID, receiptID);
            f1.Show();
            this.Hide();
        }
    }
}
