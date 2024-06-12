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
    internal class request
    {
        private int receiptID;
        private int custID;
        private string service;
        private string urgency;
        private string description;
        private string orderDate;
        private string collectionDate;
        private int payAmount;
        private string payStatus;
        private int newID;
        private int serviceNo;
        private int urgencyNo;
        private string custName;
        private string tel;
        private string email;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ToString());

        public int NewID { get => newID; set => newID = value; }
        public string Service { get => service; set => service = value; }
        public string Urgency { get => urgency; set => urgency = value; }
        public string Description { get => description; set => description = value; }
        public string OrderDate { get => orderDate; set => orderDate = value; }
        public string CollectionDate { get => collectionDate; set => collectionDate = value; }
        public int PayAmount { get => payAmount; set => payAmount = value; }
        public string PayStatus { get => payStatus; set => payStatus = value; }
        public string CustName { get => custName; set => custName = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Email { get => email; set => email = value; }

        public request(int ID, string sv, int pa, string od, string ugc)
        {
            custID = ID;
            service = sv;
            payAmount = pa;
            orderDate = od;
            urgency = ugc;
        }
        
        public request()
        { }

        public request(int sn, int un)
        {
            serviceNo = sn;
            urgencyNo = un;
        }

        public request(int ID)
        {
            receiptID = ID;
            custID = ID;
        }

        public string addRequest()
        {
            string status;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("select role from users where userID='" + custID + "'", con);
            string userRole = cmd2.ExecuteScalar().ToString();
            if (userRole != "customer")
            {
                status = "ID entered is not a customer!";
                con.Close();
                return status;
            }

            SqlCommand cmd = new SqlCommand("insert into request (custID,service,urgency,description,orderDate,collectionDate,payAmount,payStatus) values(@ID,@sv,@ugc,'N/A',@od,'N/A',@pa,'InComplete')", con);
            cmd.Parameters.AddWithValue("@ID", custID);
            cmd.Parameters.AddWithValue("@sv", service);
            cmd.Parameters.AddWithValue("@ugc", urgency);
            cmd.Parameters.AddWithValue("@od", orderDate);
            cmd.Parameters.AddWithValue("@pa", payAmount);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Registration Successful.";
            else
                status = "Unable to register.";
            con.Close();
            return status;
        }

        public static void getNewID(request o2)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select MAX(receiptID) from request", con);
            try { o2.newID = Convert.ToInt32(cmd.ExecuteScalar().ToString()) + 1; }
            catch { o2.newID = 1; }
            con.Close();
        }

        public int getPA()
        {
            int pa;
            if (serviceNo >= 0 && serviceNo <= 7 && urgencyNo >= 0 && urgencyNo <= 1)
            {
                if (serviceNo == 0)
                {
                    if (urgencyNo == 1)
                    { pa = 80; }
                    else
                    { pa = 50; }
                }
                else if (serviceNo == 1)
                {
                    if (urgencyNo == 1)
                    { pa = 90; }
                    else
                    { pa = 60; }
                }
                else if (serviceNo == 2)
                {
                    if (urgencyNo == 1)
                    { pa = 430; }
                    else
                    { pa = 380; }
                }
                else if (serviceNo == 3)
                {
                    if (urgencyNo == 1)
                    { pa = 200; }
                    else
                    { pa = 160; }
                }
                else if (serviceNo == 4)
                {
                    if (urgencyNo == 1)
                    { pa = 210; }
                    else
                    { pa = 180; }
                }
                else if (serviceNo == 5)
                {
                    if (urgencyNo == 1)
                    { pa = 150; }
                    else
                    { pa = 100; }
                }
                else if (serviceNo == 6)
                {
                    if (urgencyNo == 1)
                    { pa = 130; }
                    else
                    { pa = 80; }
                }
                else
                {
                    if (urgencyNo == 1)
                    { pa = 100; }
                    else
                    { pa = 70; }
                }
                return pa;
            }
            pa = -1;
            return pa;
        }

        public DataTable disCustHis()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from request where custID='" + custID + "' order by payStatus DESC", con);
            DataTable custHis = new DataTable();
            da.Fill(custHis);
            con.Close();
            return custHis;
        }

        public static void getRD(request o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from request where receiptID='" + o1.receiptID + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.custID = rd.GetInt32(1);
                o1.service = rd.GetString(2);
                o1.urgency = rd.GetString(3);
                o1.description = rd.GetString(4);
                o1.orderDate = rd.GetString(5);
                o1.collectionDate = rd.GetString(6);
                o1.payAmount = rd.GetInt32(7);
                o1.payStatus = rd.GetString(8);
            }
            rd.Close();
            SqlCommand cmd2 = new SqlCommand("select * from users where userID='" + o1.custID + "'", con);
            SqlDataReader rd2 = cmd2.ExecuteReader();
            while (rd2.Read())
            {
                o1.custName = rd2.GetString(1);
                o1.tel = rd2.GetString(6);
                o1.email = rd2.GetString(7);
            }
            con.Close();
        }

        public string acceptPay()
        {
            string status;
            con.Open();

            SqlCommand cmd = new SqlCommand("update request set payStatus='Completed' where receiptID='" + receiptID + "'", con);
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
