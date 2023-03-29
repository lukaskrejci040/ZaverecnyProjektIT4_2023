using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Pracant
    {
        public Pracant(int idUser, int idEmployee, string jmeno, string heslo, string passwordSalt, bool admin)
        {
            IdUser = idUser;
            IdEmployee = idEmployee;
            Jmeno = jmeno;
            Heslo = heslo;
            PasswordSalt = passwordSalt;
            Admin = admin;
        }

        public int IdUser { get; set; }
        public int IdEmployee { get; set; }
        public string Jmeno { get; set; }

        public string Heslo { get; set; }
        public string PasswordSalt { get; set; }
        public bool Admin { get; set; }
        
    }
}
