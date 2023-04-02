using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Deployment.Internal;
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
       
            if (userName != null || password != null)
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select * from Users where UserName=@userName and Password=@password";
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
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand command = conn.CreateCommand())
                {
                    command.CommandText = "select * from Users";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pracants.Add(new Pracant((int)reader["IdUser"], (int)reader["IdEmployee"], reader["UserName"].ToString(), reader["Password"].ToString(), reader["PasswordSalt"].ToString(), Convert.ToBoolean(reader["Admin"])));

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
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "Delete from Users where IdUser =@IdUser";
                    cmd.Parameters.AddWithValue("IdUser", IdDelete);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public void Insert(int IdEmployee, string UserName, string Password, string PasswordSalt, bool Admin)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT into Users values(@IdEmployee,@UserName,@Password,@PasswordSalt,@Admin)";
                    cmd.Parameters.AddWithValue("IdEmployee", IdEmployee);
                    cmd.Parameters.AddWithValue("UserName", UserName);
                    cmd.Parameters.AddWithValue("Password", Password);
                    cmd.Parameters.AddWithValue("PasswordSalt", PasswordSalt);
                    cmd.Parameters.AddWithValue("Admin", Admin);
                    try {
                        cmd.ExecuteNonQuery();
                    }
                    catch {
                        MessageBox.Show("Zaměstnanec s tímto ID neexistuje");
                    }
                }
                conn.Close();
                conn.Close();
            }
        }
        public void Update(int IdUser,/* int IdEmployee,*/ string UserName, string Password, string PasswordSalt, bool Admin, int IdEmployee)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "Update Users set UserName=@UserName, IdEmployee=@IdEmployee, Password = @Password, PasswordSalt=@PasswordSalt, Admin=@Admin where IdUser=@IdUser";

                    // cmd.Parameters.AddWithValue("IdEmployee", IdEmployee);   // špatnej syntax u IdEmployee, nvm
                    cmd.Parameters.AddWithValue("UserName", UserName);
                    cmd.Parameters.AddWithValue("Password", Password);
                    cmd.Parameters.AddWithValue("PasswordSalt", PasswordSalt);
                    cmd.Parameters.AddWithValue("IdUser", IdUser);
                    cmd.Parameters.AddWithValue("Admin", Admin);
                    cmd.Parameters.AddWithValue("IdEmployee", IdEmployee);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }



        public Pracant GetPracant(int IdUser)
        {
            Pracant pracant;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Users where IdUser=@IdUser";
                    cmd.Parameters.AddWithValue("IdUser", IdUser);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pracant = new Pracant((int)reader["IdUser"], (int)reader["IdEmployee"], reader["UserName"].ToString(), reader["Password"].ToString(), reader["PasswordSalt"].ToString(), Convert.ToBoolean(reader["Admin"]));
                        }
                        else
                        {
                            pracant = null;
                        }
                    }
                    conn.Close();
                }
                return pracant;
            }

            /*public Pracant GetPracant(int IdUser)
            {
                Pracant pracants;
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    using (SqlCommand command = conn.CreateCommand())
                    {
                        command.CommandText = "select * from Users where IdUser=@IdUser";
                        command.Parameters.AddWithValue("IdUser", IdUser);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                pracants = new Pracant(reader["IdUser"], reader["IdEmployee"], reader["UserName"] );
                            }
                        }
                    }
                    conn.Close();
                }
                return pracants;

            }*/

        }
        public List<Employee> GetEmployees()
        {
            List<Employee> Employees = new List<Employee>();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand command = conn.CreateCommand())
                {
                    command.CommandText = "select * from Employees";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employees.Add(new Employee((int)reader["IdEmployee"], reader["FirstName"].ToString(), reader["LastName"].ToString(), Convert.ToDateTime(reader["BirthDate"]), reader["Email"].ToString(), reader["Phone"].ToString()));

                        }
                    }
                }
                conn.Close();
            }
            return Employees;

        }
        public void DeleteEmployee(int IdDelete)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "Delete from Employees where IdEmployee =@IdEmployee";
                    cmd.Parameters.AddWithValue("IdEmployee", IdDelete);
                    try {
                        cmd.ExecuteNonQuery();
                    }
                    catch {
                        MessageBox.Show("Zadali jste nesprávnou hodnotu");
                    }


                }
                conn.Close();
            }
        }
        public void InsertEmployee(string FirstName, string LastName, DateTime BirthDate, string Email, string Phone)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT into Employees values(@Firstname,@LastName,@BirthDate,@Email, @Phone)";
                    cmd.Parameters.AddWithValue("FirstName", FirstName);
                    cmd.Parameters.AddWithValue("LastName", LastName);
                    cmd.Parameters.AddWithValue("BirthDate", BirthDate);
                    cmd.Parameters.AddWithValue("Email", Email);
                    cmd.Parameters.AddWithValue("Phone", Phone);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Některá z hodnot je neplatná");
                    }
                }
                conn.Close();

            }
        }
        public void UpdateEmployee(int IdEmployee, string FirstName, string LastName, DateTime BirthDate, string Email, string Phone)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "Update Employees set FirstName=@FirstName, LastName=@LastName, BirthDate=@BirthDate, Email = @Email, Phone=@Phone where IdEmployee=@IdEmployee";

                    cmd.Parameters.AddWithValue("FirstName", FirstName);
                    cmd.Parameters.AddWithValue("LastName", LastName);
                    cmd.Parameters.AddWithValue("BirthDate", BirthDate);
                    cmd.Parameters.AddWithValue("Email", Email);
                    cmd.Parameters.AddWithValue("Phone", Phone);
                    cmd.Parameters.AddWithValue("IdEmployee", IdEmployee);


                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public Employee GetEmployee(int IdEmployee)
        {
            Employee employee;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Employees where IdEmployee=@IdEmployee";
                    cmd.Parameters.AddWithValue("IdEmployee", IdEmployee);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employee = new Employee((int)reader["IdEmployee"], reader["FirstName"].ToString(), reader["LastName"].ToString(), Convert.ToDateTime(reader["BirthDate"]), reader["Email"].ToString(), reader["Phone"].ToString());
                        }
                        else
                        {
                            employee = null;
                        }
                    }
                    conn.Close();
                }
                return employee;
            }




        }
        public List<Contract> GetContract()
        {
            List<Contract> Contract = new List<Contract>();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand command = conn.CreateCommand())
                {
                    command.CommandText = "select * from Contract";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Contract.Add(new Contract((int)reader["Id"], reader["Customer"].ToString(), reader["Description"].ToString()));

                        }
                    }
                }
                conn.Close();
            }
            return Contract;

        }
        public void DeleteContract(int Id)
        {
            using(SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "Delete from Contract where Id=@Id";
                    cmd.Parameters.AddWithValue("Id", Id);

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void InsertContract(string Customer, string Description)
        {
            using(SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText="INSERT INTO Contract values(@Customer, @Description)";
                    cmd.Parameters.AddWithValue("Customer", Customer);
                    cmd.Parameters.AddWithValue ("Description", Description);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();

            }
        }
        public void UpdateContract(string Customer, string Description, int Id)
        {
            using( SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Contract set Customer=@Customer, Description = @Description where Id=@Id";
                    cmd.Parameters.AddWithValue("Customer", Customer);
                    cmd.Parameters.AddWithValue("Description", Description);
                    cmd.Parameters.AddWithValue("Id", Id);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public Contract GetContrac(int Id)
        {
            Contract contract;
            using(SqlConnection conn = new SqlConnection(connection)) {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * From Contract WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("Id", Id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            contract =(new Contract((int)reader["Id"], reader["Customer"].ToString(), reader["Description"].ToString()));
                        }
                        else
                        {
                            contract = null;
                        }
                    }
                    conn.Close();

                }
                return contract;
            }


        }
        public List<WorkType> GetWorkTypes()
        {
            List<WorkType> workTypes = new List<WorkType>();
            using(SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM WorkType";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            workTypes.Add(new WorkType((int)reader["Id"], reader["Name"].ToString(), reader["Description"].ToString()));


                        }
                    }
                    conn.Close();
                }
            }
            return workTypes;
        }

        public void DeleteWorkType(int Id)
        {
            using(SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM WorkType WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("Id", Id);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public void InsertWorkType(string Name, string Description)
        {
            using(SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO WorkType values (@Name, @Description)";
                    cmd.Parameters.AddWithValue("Name", Name);
                    cmd.Parameters.AddWithValue("Description", Description);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public void UpdateWorkType(int Id, string Name, string Description)
        {
            using(SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE WorkType SET Name=@Name, Description=@Description WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("Name", Name);
                    cmd.Parameters.AddWithValue("Description", Description);
                    cmd.Parameters.AddWithValue("Id", Id);
                    cmd.ExecuteNonQuery();

                }
                conn.Close();
            }
        }
        public WorkType GetWorkType(int Id)
        {
            WorkType workType;
            using(SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM WorkType WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("Id", Id);
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            workType = new WorkType( (int)reader["Id"], reader["Name"].ToString(), reader["Description"].ToString());
                        }
                        else
                        {
                            workType = null;
                        }
                    }
                }
                conn.Close();

            }
            return workType;

        }

        public List<WorkHour> GetWorkHours()
        {
            List<WorkHour> workHours = new List<WorkHour>();
            using(SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "Select * FROM WorkHour";
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            workHours.Add(new WorkHour((int)reader["Id"], (int)reader["Employee"], (int)reader["Contract"], (int)reader["WorkType"], (int)reader["Hour"], Convert.ToDateTime(reader["Kdy"])));
                        }
                    }
                    conn.Close();
                }
            }
            return workHours;
        }

        public void InsertWorkHour(int Employees, int Contract, int WorkType, int Hour, DateTime Kdy)
        {
            using(SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand()) {
                    cmd.CommandText = "INSERT INTO WorkHour VALUES (@Employees, @Contract, @WorkType, @Hour, @Kdy)";
                    cmd.Parameters.AddWithValue("Employees", Employees);
                    cmd.Parameters.AddWithValue("Contract", Contract);
                    cmd.Parameters.AddWithValue("WorkType", WorkType);
                    cmd.Parameters.AddWithValue("Hour",Hour);
                    cmd.Parameters.AddWithValue("Kdy",Kdy);
                    cmd.ExecuteNonQuery();

                }
                conn.Close();
            }
        }
        public void DeleteWorkHour(int Id)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM WorkHour WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("Id", Id);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }

        }
        public void UpdateWorkHour(int Id, int Employee, int Contract, int WorkType, int Hour, DateTime Kdy)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE WorkHour SET Employee=@Employee, Contract=@Contract, WorkType=@WorkType, Hour=@Hour, Kdy=@Kdy WHERE Id=@Id";
                   
                    cmd.Parameters.AddWithValue("Employee", Employee);
                    cmd.Parameters.AddWithValue("Contract", Contract);
                    cmd.Parameters.AddWithValue("WorkType", WorkType);
                    cmd.Parameters.AddWithValue("Hour", Hour);
                    cmd.Parameters.AddWithValue("Kdy", Kdy);
                    cmd.Parameters.AddWithValue("Id", Id);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public WorkHour GetWorkHour(int Id)
        {
            WorkHour workHour;
            using(SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM WorkHour WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("Id", Id);
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            workHour = new WorkHour((int)reader["Id"], (int)reader["Employee"], (int)reader["Contract"], (int)reader["WorkType"], (int)reader["Hour"], Convert.ToDateTime(reader["Kdy"]));
                        }
                        else
                        {
                            workHour = null;
                        }
                    }
                }

                conn.Close();
            }
            return workHour;
        }
        public List<WorkHour> GetWorkHoursUser(int Employee)
        {
           
            List<WorkHour> workhour = new List<WorkHour>();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * from WorkHour where Employee = @Employee";
                    cmd.Parameters.AddWithValue("Employee", Employee);
                    
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {                       
                            workhour.Add(new WorkHour((int)reader["Id"], (int)reader["Employee"], (int)reader["Contract"], (int)reader["WorkType"], (int)reader["Hour"], Convert.ToDateTime(reader["Kdy"])));
                        }
                    }
                }
                conn.Close();
            }
            return workhour;

        }

        public string Prihlaseni(string UserName, string Password)
        {
            string employee=null;
            using(SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM users WHERE UserName = @UserName and Password = @Password"; //and Password = @Password
                    cmd.Parameters.AddWithValue("UserName", UserName);
                    cmd.Parameters.AddWithValue("Password", Password);
                    //  cmd.Parameters.AddWithValue("Password", Password);


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bool Admin = Convert.ToBoolean(reader["Admin"]);
                            if (Admin == true)
                            {
                                HLNabídkaForm hLNabídkaForm = new HLNabídkaForm();
                                hLNabídkaForm.ShowDialog();
                            }
                            else
                            {
                                Uzivatel uzivatel = new Uzivatel();
                                uzivatel.ShowDialog();
                            }
                        }
                        else
                       {
                           MessageBox.Show("Špatné údaje");
                       }

                        using (SqlCommand command = new SqlCommand(connection))
                        {
                            
                            //command.CommandText = "SELECT * FROM Employees WHERE IdEmployee = @IdEmployee";
                            //command.Parameters.AddWithValue("IdEmployee", reader["IdEmployee"]);
                            
                            

                            /*using(SqlDataReader rdr = command.ExecuteReader())
                            {
                                if (rdr.Read())
                                {
                                    employee = rdr["LastName"].ToString();
                                }
                                
                                
                            }
                            */

                        }

                    }
                   conn.Close();
                }
                return employee;
                
               
            }
           
        }

        public void Prihlasen(string User)
        {
            using(SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                using(SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Obechcani SET IdUser=@IdUser WHERE Id=1";
                    cmd.Parameters.AddWithValue("IdUser", User);
                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }
        public string AktUziv()
        {
            string AktUziv;
            using(SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                using(SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = "SELECT * FROM Obechcani WHERE Id=1";
                    using(SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            AktUziv = reader["IdUser"].ToString();
                        }
                        else
                        {
                            AktUziv = null;
                        }
                        
                    }
                }
                sqlConnection.Close();
            }
            return AktUziv;
        }

        public int IdEmployee(string UserName)
        {
            int IdEmployee = 0;
            int Employee = 0;
            using(SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Users WHERE UserName=@UserName";
                    cmd.Parameters.AddWithValue("UserName", UserName);

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                             Employee = (int)reader["IdEmployee"];
                        }

                    }
                    using (SqlCommand cmd2 = conn.CreateCommand())
                    {
                        cmd2.CommandText = "SELECT * FROM Employees WHERE IdEmployee = @IdEmployee";
                        cmd2.Parameters.AddWithValue("IdEmployee", Employee);
                            using (SqlDataReader reader2 = cmd2.ExecuteReader())
                            {
                                if (reader2.Read())
                                {
                                    IdEmployee = (int)reader2["IdEmployee"];
                                }
                            }
                    }
                    
                }
                conn.Close();
                return IdEmployee;
                
            }
        }


        public void UzivInsert(int Employee, int Contract, int WorkType, int Hour, DateTime Kdy)
        {
            using(SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO WorkHour VALUES (@Employee, @Contract, @WorkType, @Hour, @Kdy)";
                    cmd.Parameters.AddWithValue("Employee", Employee);
                    cmd.Parameters.AddWithValue("Contract", Contract);
                    cmd.Parameters.AddWithValue("WorkType", WorkType);
                    cmd.Parameters.AddWithValue("Hour", Hour);
                    cmd.Parameters.AddWithValue("Kdy", Kdy);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void UzivDelete(int Id)
        {
            DateTime Datum;
            DateTime DatumDnes;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM WorkHour WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("Id", Id);
                    using(SqlCommand cmd2 = conn.CreateCommand())
                    {
                        cmd2.CommandText = "SELECT * FROM WorkHour WHERE Id=@Id";
                        cmd2.Parameters.AddWithValue("Id", Id);
                        using (SqlDataReader reader = cmd2.ExecuteReader())
                        {
                            
                            if (reader.Read())
                            {
                                Datum = Convert.ToDateTime(reader["Kdy"]);
                                Datum.ToString("d");
                                
                                DatumDnes = System.DateTime.Today;
                                DatumDnes.ToString("d");
                                Datum.ToString("d");
                                
                            }
                            else
                            {
                                Datum = Convert.ToDateTime(reader["Kdy"]);
                                Datum.ToString("d");

                                DatumDnes = System.DateTime.Today;
                                DatumDnes.ToString("d");
                                Datum.ToString("d");
                            }
                        }
                        if (Datum == DatumDnes)
                        {

                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Můžete mazat jen dnešní záznam");
                        }
                    }
                    
                }
                conn.Close();
            }
        }

        public void UzivEdit(int Contract, int WorkType, int Hour, int Id, int Employee)
        {
            DateTime Datum;
            DateTime DatumDnes;
            using(SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "UPDATE WorkHour SET Contract = @Contract, WorkType=@WorkType, Hour=@Hour WHERE Id=@Id and Employee =@Employee";
                    cmd.Parameters.AddWithValue("Contract", Contract);
                    cmd.Parameters.AddWithValue("WorkType", WorkType);
                    cmd.Parameters.AddWithValue("Hour", Hour);
                    cmd.Parameters.AddWithValue("Id", Id);
                    cmd.Parameters.AddWithValue("Employee", Employee);
                    //  cmd.Parameters.AddWithValue("Employee", Employee);

                    using (SqlCommand cmd2 = conn.CreateCommand())
                {
                    cmd2.CommandText = "SELECT * FROM WorkHour WHERE Id=@Id";
                    cmd2.Parameters.AddWithValue("Id", Id);
                        using (SqlDataReader reader = cmd2.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Datum = Convert.ToDateTime(reader["Kdy"]);
                            Datum.ToString("d");
                            DatumDnes = System.DateTime.Today;
                            DatumDnes.ToString("d");                           
                        }
                        else
                        {
                            Datum = Convert.ToDateTime(reader["Kdy"]);
                            Datum.ToString("d");
                            DatumDnes = System.DateTime.Today;
                            DatumDnes.ToString("d");
                        }
                    }
                }
                if(Datum == DatumDnes)
                {
                        cmd.ExecuteNonQuery();
                }
                    else
                    {
                        MessageBox.Show("Můžete editovat jen dnešní záznamy");
                    }
                }

            }
        }

        public WorkHour GetWorkHou(int Id)
        {
            WorkHour workHour;
            using(SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM WorkHour WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("Id", Id);
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            workHour = new WorkHour((int)reader["Id"], (int)reader["Employee"], (int)reader["Contract"], (int)reader["WorkType"], (int)reader["Hour"], Convert.ToDateTime(reader["Kdy"]));
                            
                        }
                        else
                        {
                            workHour = null;
                        }
                    }
                }
                conn.Close();
                return workHour;
                
            }
            


        }


        

    } 
}
