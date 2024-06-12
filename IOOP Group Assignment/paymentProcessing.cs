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
    public partial class paymentProcessing : Form
    {
        public paymentProcessing()
        {
            InitializeComponent();
        }
        public static int userID;
        public static int custID;
        public static int receiptID;
        public paymentProcessing(int uID, int cID, int rID)
        {
            InitializeComponent();
            userID = uID;
            custID = cID;
            receiptID = rID;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            receptionistMenu f1 = new receptionistMenu();
            f1.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            customerHistory f1 = new customerHistory(userID, custID);
            f1.Show();
            this.Hide();
        }

        private void paymentProcessing_Load(object sender, EventArgs e)
        {
            lblID.Text = "User ID: " + userID.ToString();
            getRD();
        }

        void getRD()
        {
            request o1 = new request(receiptID);
            request.getRD(o1);
            lblRcptID.Text = receiptID.ToString();
            lblCustName.Text = o1.CustName;
            lblCustID.Text = custID.ToString();
            lblEmail.Text = o1.Email;
            lblTel.Text = o1.Tel;
            lblService.Text = o1.Service;
            lblDescript.Text = o1.Description;
            lblOdrDate.Text = o1.OrderDate;
            lblCollectDate.Text = o1.CollectionDate;
            lblPayAmount.Text = "RM " + o1.PayAmount.ToString();
            lblPayStatus.Text = o1.PayStatus;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        Bitmap bitmap;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            btnAccept.Visible = false;
            btnBack.Visible = false;
            btnMenu.Visible = false;
            btnPrint.Visible = false;
            lblID.Visible = false;
            lblTitle.Text = "Laptop Repair Services Management System";

            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

            btnAccept.Visible = true;
            btnBack.Visible = true;
            btnMenu.Visible = true;
            btnPrint.Visible = true;
            lblID.Visible = true;
            lblTitle.Text = "Payment Processing";
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (lblPayStatus.Text == "InComplete" && lblCollectDate.Text != "N/A")
            {
                request o2 = new request(receiptID);
                MessageBox.Show(o2.acceptPay());
            }
            else if (lblPayStatus.Text == "Completed")
            {
                MessageBox.Show("Payment has already been accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lblCollectDate.Text == "N/A")
            {
                MessageBox.Show("Repairing service is not completed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Something went wrong! Error code: 404", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            getRD();
        }
    }
}
