using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Pracant
    {
        public Pracant(int idUser, int idEmployee, string jmeno, string heslo, string passwordSalt)
        {
            IdUser = idUser;
            IdEmployee = idEmployee;
            Jmeno = jmeno;
            Heslo = heslo;
            PasswordSalt = passwordSalt;
        }

        public int IdUser { get; set; }
        public int IdEmployee { get; set; }
        public string Jmeno { get; set; }

        public string Heslo { get; set; }
        public string PasswordSalt { get; set; }
    }
}
