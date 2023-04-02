using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        SqlRepository sqlRepository;
        public string Uzivatel;
        
        public FormLogin()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Projekt PRG\KARANTÉNA (AKTUÁLNÍ)\projektDB (1).mdf';Integrated Security=True;Connect Timeout=30");
            
        }
        
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(TBjmeno != null || TBHeslo != null)
            {
                sqlRepository.Prihlasen(TBjmeno.Text);
                sqlRepository.Prihlaseni(TBjmeno.Text, TBHeslo.Text);
                
            }
            
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            HLNabídkaForm hlNabídkaForm = new HLNabídkaForm();
            hlNabídkaForm.ShowDialog();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            Uzivatel uzivatel = new Uzivatel();
            uzivatel.ShowDialog();
        }
    }
}
