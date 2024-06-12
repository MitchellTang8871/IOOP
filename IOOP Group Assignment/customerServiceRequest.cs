using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // this one is a testing also

namespace IOOP_Group_Assignment
{
    public partial class customerServiceRequest : Form
    {      
        public static int userID;
        public customerServiceRequest(int ID)
        {
            InitializeComponent();
            userID = ID;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            technicianMenu f1 = new technicianMenu(userID);
            f1.ShowDialog();
        }

        private void customerServiceRequest_Load(object sender, EventArgs e)
        {
            lblID.Text = "User ID: " + userID.ToString();
            request1 o1 = new request1();
            ServiceList.DataSource = o1.disCustReq();
        }

        private void ServiceList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int receiptID;
            int custID;
            receiptID = int.Parse(ServiceList.Rows[e.RowIndex].Cells["receiptID"].Value.ToString());
            custID = int.Parse(ServiceList.Rows[e.RowIndex].Cells["custID"].Value.ToString());
            technicianServiceUpdate f1 = new technicianServiceUpdate(userID, custID, receiptID);
            f1.Show();
            this.Hide();
        }
    }
}
