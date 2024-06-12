using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace IOOP_Group_Assignment
{
    internal class Customer
    {
        private int receiptID;
        private int userID;
        private string service;
        private string urgency;
        private int payAmount;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ToString());

        public Customer()
        {

        }

        public Customer(int uid)
        {
            userID = uid;
        }

        public Customer(int uid,int rid)
        {
            userID = uid;
            receiptID = rid;
        }

        public DataTable disCustTrade()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from request where custID='" + userID + "'", con);
            DataTable custTrade = new DataTable();
            da.Fill(custTrade);
            con.Close();
            return custTrade;
        }
        public string updateRequest(string x, string y, int z)
        {
            string status;
            con.Open();
            service = x;
            urgency = y;
            payAmount = z;

            SqlCommand cmd = new SqlCommand("update request set service='" + service + "', urgency='" + urgency + "',payAmount='" + payAmount + "' where receiptID='" + receiptID + "'", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Update Successfully.";
            else
                status = "Unable to update.";
            con.Close();
            return status;
        }
    }

    
    
}
