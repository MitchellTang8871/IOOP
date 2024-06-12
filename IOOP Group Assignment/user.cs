using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Group_Assignment
{
    internal class user
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

        public user(int x, string y)
        {
            userID = x;
            password = y;
        }

        public user(int x)
        {
            userID = x;
        }

        public user(string nm, string pass, string rl, bool gen, string date, string num, string em, string adrs)
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

        public string login(int ID)
        {
            string status = null;
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from users where userID='" + userID + "' and password ='" + password + "'", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("select role from users where userID ='" + userID + "'and password = '" + password + "'", con);
                string userRole = cmd2.ExecuteScalar().ToString();

                if (userRole == "admin")
                {
                    adminMainMenu s = new adminMainMenu(ID);
                    s.Show();
                }
                else if (userRole == "receptionist")
                {
                    receptionistMenu s = new receptionistMenu(ID);
                    s.Show();
                }
                else if (userRole == "customer")
                {
                    customerMenu s = new customerMenu(ID);
                    s.Show();
                }
                else if (userRole == "technician")
                {
                    technicianMenu s = new technicianMenu(ID);
                    s.Show();
                }
            }
            else
            {
                status = "Incorrect userID/password";
            }
            con.Close();
            return status;
        }

        public static void prof(user o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from users where userID='" + o1.userID + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.name = rd.GetString(1);
                o1.role = rd.GetString(3);
                o1.gender = rd.GetBoolean(4);
                o1.dob = rd.GetString(5);
                o1.tel = rd.GetString(6);
                o1.email = rd.GetString(7);
                o1.address = rd.GetString(8);
            }
            con.Close();
        }
        public string updateProfile(string x, string y, string z)
        {
            string status;
            con.Open();
            tel = x;
            email = y;
            address = z;

            SqlCommand cmd = new SqlCommand("update users set tel='" + tel + "', email='" + email + "' , address='" + address + "' where userID='" + userID + "'", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Update Successfully.";
            else
                status = "Unable to update.";
            con.Close();
            return status;
        }

        public static void getNewID(user o2)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select MAX(userID) from users", con);
            o2.newID = Convert.ToInt32(cmd.ExecuteScalar().ToString()) + 1;
            con.Close();
        }

        public string addUser()
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

        public string searchCust()
        {
            string status = null;
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from users where userID='" + userID + "' and role='customer'", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            if (count == 0)
            {
                status = "ID searched do not exist or ID searched not customer.";
            }
            con.Close();
            return status;
        }

        public string getRole()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select role from users where userID='" + userID + "'", con);
            string role = cmd.ExecuteScalar().ToString();
            con.Close();
            return role;
        }
    }
}
