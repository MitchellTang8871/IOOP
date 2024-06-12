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
    public partial class serviceRequest : Form
    {
        public serviceRequest()
        {
            InitializeComponent();
        }
        public static int userID;
        public serviceRequest(int ID)
        {
            InitializeComponent();
            userID = ID;
        }

        private void serviceRequest_Load(object sender, EventArgs e)
        {
            lblID.Text = "User ID: " + userID.ToString();
            getNewID();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            receptionistMenu f1 = new receptionistMenu();
            f1.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtCustID.Text != "" && cmbService.SelectedIndex != -1)
            {
                if (int.TryParse(txtCustID.Text, out int ID))
                {
                    if (rbtnNormal.Checked || rbtnUrgent.Checked)
                    {
                        string urgency;
                        int pa,sn,un;
                        if (rbtnNormal.Checked)
                        {
                            urgency = "Normal";
                            un = 0;
                        }
                        else
                        {
                            urgency = "Urgent";
                            un = 1;
                        }
                        if (cmbService.SelectedIndex == 0)
                        { sn = 0; }
                        else if (cmbService.SelectedIndex == 1)
                        { sn = 1; }
                        else if (cmbService.SelectedIndex == 2)
                        { sn = 2; }
                        else if (cmbService.SelectedIndex == 3)
                        { sn = 3; }
                        else if (cmbService.SelectedIndex == 4)
                        { sn = 4; }
                        else if (cmbService.SelectedIndex == 5)
                        { sn = 5; }
                        else if (cmbService.SelectedIndex == 6)
                        { sn = 6; }
                        else
                        { sn = 7; }
                        request obj1 = new request(sn, un);
                        pa = obj1.getPA();
                        if (pa != -1)
                        {
                            request obj2 = new request(ID, cmbService.Text, pa, dtpDate.Text, urgency);
                            MessageBox.Show("Total payment amount: " + pa, "Payment Amount", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show(obj2.addRequest());
                        }
                        else
                        {
                            MessageBox.Show("Calculation for pay amount went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        clear();
                        getNewID();
                    }
                    else
                    {
                        MessageBox.Show("Please select the urgency!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter integer value for Customer ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void clear()
        {
            txtCustID.Text = "";
            dtpDate.Value = DateTime.Now;
            cmbService.SelectedIndex = -1;
            rbtnNormal.Checked = false;
            rbtnUrgent.Checked = false;
        }

        void getNewID()
        {
            request o2 = new request();
            request.getNewID(o2);
            lblReceiptID.Text = o2.NewID.ToString();
        }
    }
}
