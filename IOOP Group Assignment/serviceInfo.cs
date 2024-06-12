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
    public partial class serviceInfo : Form
    {
        public serviceInfo()
        {
            InitializeComponent();
        }
        public static int userID;
        public static int receiptID;
        public static int custID;
        public serviceInfo(int uid, int cid,int rid)
        {
            InitializeComponent();
            userID = uid;
            receiptID = rid;
            custID = cid;

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerMenu f1 = new customerMenu();
            f1.Show();
        }

        private void serviceInfo_Load(object sender, EventArgs e)
        {
            lblID.Text = "User ID: " + userID.ToString();
            request o1 = new request(receiptID);
            request.getRD(o1);
            lblRcptID.Text = receiptID.ToString();
            lblCustName.Text = o1.CustName;
            lblCustID.Text = custID.ToString();
            lblEmail.Text = o1.Email;
            lblTel.Text = o1.Tel;
            cbService.Text = o1.Service;
            if (o1.Urgency == "Normal")
            { rBtn1.Checked = true; }
            else
            { rBtn2.Checked = true; }
            
            lblOdrDate.Text = o1.OrderDate;
            lblPayAmount.Text = "RM " + o1.PayAmount.ToString();
            lblPayStatus.Text = o1.PayStatus;
            lblCollectDate.Text = o1.CollectionDate;
            lblDescript.Text = o1.Description;

            if (lblCollectDate.Text != "N/A")
            {
                cbService.Visible = false;
                rBtn1.Visible = false;
                rBtn2.Visible = false;
                lblService.Visible = true;
                lblUrgent.Visible = true;
                lblService.Text = o1.Service;
                lblUrgent.Text = o1.Urgency;
            }
            else
            {
                cbService.Visible = true;
                rBtn1.Visible = true;
                rBtn2.Visible = true;
                lblService.Visible = false;
                lblUrgent.Visible = false;
            }
            
            

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerTradingHistory f1   = new customerTradingHistory();
            f1.Show();

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lblCollectDate.Text == "N/A")
            {
                int fee;
                string urgency;
                fee = 0;
                urgency = "N/A";

                if (cbService.SelectedIndex == 0 && rBtn1.Checked)
                {
                    fee = 50;
                    urgency = "Normal";
                }
                else if (cbService.SelectedIndex == 0 && rBtn2.Checked)
                {
                    fee = 80;
                    urgency = "Urgent";
                }
                else if (cbService.SelectedIndex == 1 && rBtn1.Checked)
                {
                    fee = 60;
                    urgency = "Normal";
                }
                else if (cbService.SelectedIndex == 1 && rBtn2.Checked)
                {
                    fee = 90;
                    urgency = "Urgent";
                }
                else if (cbService.SelectedIndex == 2 && rBtn1.Checked)
                {
                    fee = 380;
                    urgency = "Normal";
                }
                else if (cbService.SelectedIndex == 2 && rBtn2.Checked)
                {
                    fee = 430;
                    urgency = "Urgent";
                }
                else if (cbService.SelectedIndex == 3 && rBtn1.Checked)
                {
                    fee = 160;
                    urgency = "Normal";
                }
                else if (cbService.SelectedIndex == 3 && rBtn2.Checked)
                {
                    fee = 200;
                    urgency = "Urgent";
                }
                else if (cbService.SelectedIndex == 4 && rBtn1.Checked)
                {
                    fee = 180;
                    urgency = "Normal";
                }
                else if (cbService.SelectedIndex == 4 && rBtn2.Checked)
                {
                    fee = 210;
                    urgency = "Urgent";
                }
                else if (cbService.SelectedIndex == 5 && rBtn1.Checked)
                {
                    fee = 100;
                    urgency = "Normal";
                }
                else if (cbService.SelectedIndex == 5 && rBtn2.Checked)
                {
                    fee = 150;
                    urgency = "Urgent";
                }
                else if (cbService.SelectedIndex == 6 && rBtn1.Checked)
                {
                    fee = 80;
                    urgency = "Normal";
                }
                else if (cbService.SelectedIndex == 6 && rBtn2.Checked)
                {
                    fee = 130;
                    urgency = "Urgent";
                }
                else if (cbService.SelectedIndex == 7 && rBtn1.Checked)
                {
                    fee = 70;
                    urgency = "Normal";
                }
                else if (cbService.SelectedIndex == 7 && rBtn2.Checked)
                {
                    fee = 100;
                    urgency = "Urgent";
                }
                else
                {
                    MessageBox.Show("Please select a service.");
                }
                lblPayAmount.Text = "RM " + fee.ToString();
                Customer o1 = new Customer(userID, receiptID);
                string stat;
                stat = o1.updateRequest(cbService.Text, urgency, fee);
                MessageBox.Show(stat);
                this.Hide();
                customerTradingHistory f1 = new customerTradingHistory();
                f1.Show();
            }
            else
            {
                MessageBox.Show("You are not allowed to change the service since it is completed");
            }
            
        }


    }
}
