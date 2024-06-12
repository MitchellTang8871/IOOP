using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace IOOP_Group_Assignment
{
    internal class employee
    {
        private int userID;
        private string password;
        private string name;
        private string role;
        private bool gender;
        private string tel;
        private string email;
        private string address;
        private string dob;
        private int newID;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ToString());

        public string Name { get => name; set => name = value; }
        public bool Gender { get => gender; set => gender = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Role { get => role; set => role = value; }
        public int NewID { get => newID; set => newID = value; }

        public employee(int x, string y)
        {
            userID = x;
            password = y;
        }

        public employee(int x)
        {
            userID = x;
        }

        public employee(string nm, string pass, string rl, bool gen, string date, string num, string em, string adrs)
        {
            name = nm;
            password = pass;
            role = rl;
            gender = gen;
            dob = date;
            tel = num;
            email = em;
            address = adrs;
        }

        public static void getNewID(employee o2)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select MAX(userID) from users", con);
            o2.newID = Convert.ToInt32(cmd.ExecuteScalar().ToString()) + 1;
            con.Close();
        }

        public string addEmployee()
        {
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into users (name,password,role,gender,dob,tel,email,address) values(@nm,@pass,@rl,@gen,@date,@num,@em,@adrs)", con);
            cmd.Parameters.AddWithValue("@nm", name);
            cmd.Parameters.AddWithValue("@pass", password);
            cmd.Parameters.AddWithValue("@rl", role);
            cmd.Parameters.AddWithValue("@gen", gender);
            cmd.Parameters.AddWithValue("@date", dob);
            cmd.Parameters.AddWithValue("@num", tel);
            cmd.Parameters.AddWithValue("@em", email);
            cmd.Parameters.AddWithValue("@adrs", address);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Registration Successful.";
            else
                status = "Unable to register.";
            con.Close();
            return status;
        }
    }
}
