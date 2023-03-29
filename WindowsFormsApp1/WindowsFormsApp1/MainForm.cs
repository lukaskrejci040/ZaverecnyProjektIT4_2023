using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        SqlRepository sqlRepository;
        public MainForm()
        {
            InitializeComponent();
             sqlRepository = new SqlRepository(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""C:\USERS\KREJCI.LUKAS\DESKTOP\PROJEKT\KARANTÉNA (AKTUÁLNÍ)\PROJEKTDB (1).MDF"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        

        private void LWMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LWMain.Items.Clear();
            var pracant = sqlRepository.GetPracants();
            foreach (var p in pracant)
            {
                LWMain.Items.Add(new ListViewItem(new string[] { p.IdUser.ToString(), p.IdEmployee.ToString(), p.Jmeno.ToString(), p.Heslo.ToString(), p.PasswordSalt.ToString(), p.Admin.ToString() }));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            sqlRepository.Delete(Convert.ToInt32(TBDelete.Text));
            }
            catch{
                MessageBox.Show("Něco se pokazilo");
            }


            LWMain.Items.Clear();
            var pracant = sqlRepository.GetPracants();
            foreach (var p in pracant)
            {
                LWMain.Items.Add(new ListViewItem(new string[] { p.IdUser.ToString(), p.IdEmployee.ToString(), p.Jmeno.ToString(), p.Heslo.ToString(), p.PasswordSalt.ToString() }));
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            using (var hmac = new HMACSHA512())
            {
                byte[] PasswordSalt = hmac.Key;
                string PasswordHash = TBPassword.Text;
                try
                {
                    sqlRepository.Insert(Convert.ToInt32(TBIdEmployee.Text), TBUserName.Text.ToString(), PasswordHash, PasswordSalt, Convert.ToBoolean(TBAdmin.Text));
                }
                catch
                {
                    MessageBox.Show("Něco se pokazilo");
                }
                
            }
            LWMain.Items.Clear();
            var pracant = sqlRepository.GetPracants();
            foreach (var p in pracant)
            {
                LWMain.Items.Add(new ListViewItem(new string[] { p.IdUser.ToString(), p.IdEmployee.ToString(), p.Jmeno.ToString(), p.Heslo.ToString(), p.PasswordSalt.ToString() }));
            }

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.ShowDialog();
        }
    }
}
