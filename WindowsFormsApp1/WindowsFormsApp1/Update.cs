using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
           
        }
        SqlRepository sqlRepository = new SqlRepository(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Projekt PRG\KARANTÉNA (AKTUÁLNÍ)\projektDB (1).mdf';Integrated Security=True;Connect Timeout=30");

        private void TBEmployeeE_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)

        {
      

                string IdKtery = numericUpDown1.Value.ToString();
                string IdEmployee = TBEmployeeE.Text;
                string UserName = TBUserNameE.Text;
                try
               {
                sqlRepository.Update(Convert.ToInt32(IdKtery),  UserName, TBPasswordE.Text, "1", Convert.ToBoolean(TBAdminE.Text),Convert.ToInt32(TBEmployeeE.Text));
                }
               catch
                {
                    MessageBox.Show("Něco se pokazilo");
                }
            
            sqlRepository.GetPracants();
            LWMain.Items.Clear();
            var pracant = sqlRepository.GetPracants();
            foreach (var p in pracant)
            {
                LWMain.Items.Add(new ListViewItem(new string[] { p.IdUser.ToString(), p.IdEmployee.ToString(), p.Jmeno.ToString(), p.Heslo.ToString(), p.PasswordSalt.ToString(), p.Admin.ToString() }));
            }
        }

        private void BtnStorno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            sqlRepository.GetPracant((int)numericUpDown1.Value);

            var pracant = sqlRepository.GetPracant((int)numericUpDown1.Value);
            if (pracant != null)
            {
                TBEmployeeE.Text = pracant.IdEmployee.ToString();
                TBUserNameE.Text = pracant.Jmeno.ToString();
                TBPasswordE.Text = pracant.Heslo.ToString();
                TBPasswordSaltE.Text = pracant.PasswordSalt.ToString();

            }

        }

        private void Update_Load(object sender, EventArgs e)
        {
            sqlRepository.GetPracants();
            LWMain.Items.Clear();
            var pracant = sqlRepository.GetPracants();
            foreach (var p in pracant)
            {
                LWMain.Items.Add(new ListViewItem(new string[] { p.IdUser.ToString(), p.IdEmployee.ToString(), p.Jmeno.ToString(), p.Heslo.ToString(), p.PasswordSalt.ToString(), p.Admin.ToString() }));
            }
        }

        
    }
} 
