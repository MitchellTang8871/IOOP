using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Group_Assignment
{
    public partial class SRFS : Form
    {
        public static int userID;
        public SRFS(int ID)
        {
            InitializeComponent();
            userID = ID;
        }

        private void SRFS_Load(object sender, EventArgs e)
        {
            lblID.Text = "User ID:" + userID.ToString();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);
            con.Open();

            SqlDataAdapter sdf = new SqlDataAdapter("select * from dbo.request where orderDate between '" + dtpStart.Text + "' and '" + dtpEnd.Text + "'", con);
            DataTable dt = new DataTable();
            sdf.Fill(dt);
            dgvReport.DataSource = dt;

            int sum = 0;
            for (int i = 0; i < dgvReport.Rows.Count-1; ++i)
            {
                if (dgvReport.Rows[i].Cells[8].Value.ToString() == "Completed")
                { sum += Convert.ToInt32(dgvReport.Rows[i].Cells[7].Value); }
            }
            lblTotalIncome.Text = sum.ToString();

            con.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            adminMainMenu am = new adminMainMenu(userID);
            am.Show();
            this.Hide();
        }
    }
}
