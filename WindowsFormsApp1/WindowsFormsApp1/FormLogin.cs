using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        SqlRepository sqlRepository;
        public FormLogin()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=projektDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(TBjmeno != null || TBHeslo != null)
            {
                sqlRepository.Login(TBjmeno.Text, TBHeslo.Text);
            }

        }
    }
}
