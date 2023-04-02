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
    public partial class Uzivatel : Form
    {
        SqlRepository sqlRepository;
        public Uzivatel()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Projekt PRG\KARANTÉNA (AKTUÁLNÍ)\projektDB (1).mdf';Integrated Security=True;Connect Timeout=30");
        }

        private void Uzivatel_Load(object sender, EventArgs e)
        {

            LblUziv.Text = sqlRepository.AktUziv();
            int IdEmployee = sqlRepository.IdEmployee(LblUziv.Text);
            sqlRepository.GetWorkHoursUser(IdEmployee);
            var Uzivatele = sqlRepository.GetWorkHoursUser(IdEmployee);
            LWUziv.Items.Clear();
            foreach (var U in Uzivatele)
            {
                LWUziv.Items.Add(new ListViewItem(new string[] { U.Id.ToString(), U.Contract.ToString(), U.Hour.ToString(), U.WorkType.ToString(), U.Kdy.ToString() }));
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkTypeList workTypeList = new WorkTypeList();
            workTypeList.Show();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            
            int IdEmployee = sqlRepository.IdEmployee(LblUziv.Text);
            DateTime DatumDnes;
            DatumDnes = System.DateTime.Today;
            DatumDnes.ToString("d");
            try { 
            sqlRepository.UzivInsert(IdEmployee, Convert.ToInt32(TBContract.Text), Convert.ToInt32(NUDHour.Value), Convert.ToInt32(TBWorkType.Text), DatumDnes);
            sqlRepository.GetWorkHoursUser(IdEmployee);
            }
            catch
            {
                MessageBox.Show("Zadejte správné hodnoty");
            }
            var Uzivatele = sqlRepository.GetWorkHoursUser(IdEmployee);
            LWUziv.Items.Clear();
            foreach (var U in Uzivatele)
            {
                LWUziv.Items.Add(new ListViewItem(new string[] { U.Id.ToString(), U.Contract.ToString(), U.Hour.ToString(), U.WorkType.ToString(), U.Kdy.ToString() }));
            }
            
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {

            
            sqlRepository.UzivDelete(Convert.ToInt32(TBDelete.Text));
            LblUziv.Text = sqlRepository.AktUziv();
            }
            catch
            {
                MessageBox.Show("Zadejte správné údaje");
            }
            int IdEmployee = sqlRepository.IdEmployee(LblUziv.Text);
               
            sqlRepository.GetWorkHoursUser(IdEmployee);
            var Uzivatele = sqlRepository.GetWorkHoursUser(IdEmployee);
            
            
            LWUziv.Items.Clear();
            foreach (var U in Uzivatele)
            {
                LWUziv.Items.Add(new ListViewItem(new string[] { U.Id.ToString(), U.Contract.ToString(), U.Hour.ToString(), U.WorkType.ToString(), U.Kdy.ToString() }));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ContractList contractList = new ContractList();
            contractList.Show();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

            
            LblUziv.Text = sqlRepository.AktUziv();
            int IdEmployee = sqlRepository.IdEmployee(LblUziv.Text);
            sqlRepository.GetWorkHoursUser(IdEmployee);
            var Uzivatele = sqlRepository.GetWorkHoursUser(IdEmployee);
            try
            {
                sqlRepository.UzivEdit(Convert.ToInt32(TBContractE.Text), Convert.ToInt32(TBWorkTypeE.Text), Convert.ToInt32(NUDHourE.Value), Convert.ToInt32(NUDID.Value), IdEmployee);
                LWUziv.Items.Clear();
                foreach (var U in Uzivatele)
                {
                    LWUziv.Items.Add(new ListViewItem(new string[] { U.Id.ToString(), U.Contract.ToString(), U.Hour.ToString(), U.WorkType.ToString(), U.Kdy.ToString() }));
                }
            }
            catch
            {
                MessageBox.Show("Zadejte správné údaje");
            }
            

        }

        private void NUDID_ValueChanged(object sender, EventArgs e)
        {

            sqlRepository.GetWorkHou(Convert.ToInt32(NUDID.Value));
            var WorkHour = sqlRepository.GetWorkHou(Convert.ToInt32(NUDID.Value));
            if(WorkHour != null)
            {
                TBWorkTypeE.Text=  WorkHour.WorkType.ToString();
                TBContractE.Text=WorkHour.Contract.ToString();
                NUDHourE.Value = WorkHour.Hour;
            }
        }

        private void LWUziv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
