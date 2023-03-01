using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class SqlRepository
    {
        string connection;
        private byte[] PasswordHash;
        public SqlRepository(string connection)
        {
            this.connection = connection;
        }
        public void Login(string userName, string password)
        {
            if(userName != null || password != null)
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    using(SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select * from Pracanti where Jmeno=@userName and Heslo=@password";
                        cmd.Parameters.AddWithValue("userName", userName);
                       /* using (var hmac = new HMACSHA512())
                        {
                            var PasswordSalt = hmac.Key;
                            var PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                        }*/
                        cmd.Parameters.AddWithValue("password", password);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MessageBox.Show(reader["Jmeno"].ToString());
                            }
                        }
                    }
                    conn.Close();
                }
            }
        }

      /*  private void HashPassword(string password)
        {
            using(var hmac = new HMACSHA512())
            {
                byte[] PasswordSalt = hmac.Key;
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }*/
        public void Register(string userName, string password)
        {

        }

        public List<Pracant> GetPracants()
        {
            List<Pracant> pracants = new List<Pracant>();
            using(SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using(SqlCommand command = conn.CreateCommand()) {
                    command.CommandText = "select * from Users";
                using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pracants.Add(new Pracant((int) reader["IdUser"], (int)reader["IdEmployee"], reader["Jmeno"].ToString(),  reader["Heslo"].ToString(), reader["PasswordSalt"].ToString()));

                        }
                    }
                }
                conn.Close();
            }
            return pracants;
            
        }
        public void Delete(int IdDelete)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "Delete from Users where IdUser =@IdUser";
                    cmd.Parameters.AddWithValue("IdUser", IdDelete);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public void Insert(int IdDelete)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT into Users values(@IdEmployee,@UserName,Password"; //tady pokračuj
                    cmd.Parameters.AddWithValue("IdUser", IdDelete);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

    }
}
