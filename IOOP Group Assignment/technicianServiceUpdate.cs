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
    public partial class technicianServiceUpdate : Form
    {
        public technicianServiceUpdate()
        {
            InitializeComponent();
        }

        public static int userID;
        public static int receiptID;
        public static int custID;

        public technicianServiceUpdate(int uid, int cid, int rid )
        {
            InitializeComponent();
            userID = uid;
            receiptID = rid;
            custID = cid;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblID.Text = "User ID: " + userID.ToString();
            request o1 = new request(receiptID);
            request.getRD(o1);
            lblRecptID.Text = receiptID.ToString();
            lblCustName.Text = o1.CustName;
            lblCustID.Text = custID.ToString();
            lblEmail.Text = o1.Email;
            lblTel.Text = o1.Tel;
            lblService.Text = o1.Service;
            lblOdrDate.Text = o1.OrderDate;
            lblPayAmount.Text = "RM " + o1.PayAmount.ToString();
            lblPayStatus.Text = o1.PayStatus;
            txtCollectDate.Text = o1.CollectionDate;
            rtxDescript.Text = o1.Description;
            dtpCollectionDate.Value = DateTime.Now.AddDays(2);
            dtpCollectionDate.Visible = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            technicianMenu f1 = new technicianMenu(userID);
            f1.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerServiceRequest f1 = new customerServiceRequest(userID);
            f1.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (rtxDescript.Text != "N/A")
            {
                request1 o1 = new request1(userID, receiptID);
                string stat;
                stat = o1.updateRequest(rtxDescript.Text, dtpCollectionDate.Text);
                if (stat != "Unable to update.")
                {
                    MessageBox.Show(stat);
                    customerServiceRequest f1 = new customerServiceRequest(userID);
                    this.Hide();
                    f1.ShowDialog();
                }
                else
                {
                    MessageBox.Show(stat);
                }
            }
            else
            { MessageBox.Show("Please Fill in Description and Select Collection Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void lblRecptID_Click(object sender, EventArgs e)
        {

        }

        private void txtCollectDate_Click(object sender, EventArgs e)
        {
            dtpCollectionDate.Visible = true;
        }
    }
}
