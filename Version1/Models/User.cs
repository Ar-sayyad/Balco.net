using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace Version1.Models
{
    public class User
    {

        public int Id { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserType { get; set; }

        public string Content { get; set; }

        public User Login(User user)
        {
            SqlCommand cmd;
            SqlConnection connection = null;

            User objUserModel = null;

            //string connectionString = @"SERVER=SERVER2008\AFINSTANCE; UID = jayesh; pwd = jayesh; DATABASE=Balcopower_db";

            connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            //string connectionString = @"Data Source=ASHIF-DMGLBQI\Ashif;Initial Catalog=Balcopower_db;Integrated Security=False;UID=ashif;pwd=Ecgit@123;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

            //connection = new SqlConnection(connectionString);

            connection.Open();
            //objSqlDataReader = new SqlDataReader();
            SqlDataReader objSqlDataReader = null;
            try
            {
                var pass = Encode(user.Password);
                string sql = "select * from users where username = '" + user.UserName + "' and password = '" + pass + "'";

                cmd = new SqlCommand(sql, connection);

                objSqlDataReader = cmd.ExecuteReader();//connection, CommandType.StoredProcedure, "OES_ACA_SP_Get_1095CReportRun", objSqlParameter)
                while (objSqlDataReader.Read())
                {
                    objUserModel = new User();
                    objUserModel.Id = Convert.ToInt32(objSqlDataReader["user_id"]);
                    objUserModel.FirstName = Convert.ToString(objSqlDataReader["fname"]);
                    objUserModel.LastName = Convert.ToString(objSqlDataReader["lname"]);
                    objUserModel.UserType = Convert.ToString(objSqlDataReader["userType"]);
                    objUserModel.UserName = Convert.ToString(objSqlDataReader["username"]);
                }
            }
            catch (Exception)
            {
                return objUserModel;
            }
            connection.Close();
            return objUserModel;
        }
        public static string Encode(string Metin)
        {
            MD5CryptoServiceProvider MD5Code = new MD5CryptoServiceProvider();
            byte[] byteDizisi = System.Text.Encoding.UTF8.GetBytes(Metin);
            byteDizisi = MD5Code.ComputeHash(byteDizisi);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (byte ba in byteDizisi)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            return sb.ToString();
        }

    }
}