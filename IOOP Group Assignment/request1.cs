using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Group_Assignment
{
    internal class request1
    {
        private int receiptID;
        private int userID;
        private string description;
        private string collectionDate;
 
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ToString());

        public request1()
        {

        }
        public request1(int uid,int rid)
        {
            userID = uid;
            receiptID = rid;
           
        }
        public DataTable disCustReq()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from request where collectionDate = 'N/A' order by urgency desc", con);
            DataTable custReq = new DataTable();
            da.Fill(custReq);
            con.Close();
            return custReq;
        }

        public string updateRequest(string x, string y)
        {
            string status;
            con.Open();
            description = x;
            collectionDate = y;

            SqlCommand cmd = new SqlCommand("update request set description='" + description + "', collectionDate='" + collectionDate + "' where receiptID='" + receiptID + "'", con);
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
