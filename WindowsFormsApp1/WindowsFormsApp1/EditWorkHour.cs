using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EditWorkHour : Form
    {
        SqlRepository sqlRepository;
        public EditWorkHour()
        {
            InitializeComponent();
           sqlRepository = new SqlRepository(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Projekt PRG\KARANTÉNA (AKTUÁLNÍ)\projektDB (1).mdf';Integrated Security=True;Connect Timeout=30");

        }

        private void EditWorkHour_Load(object sender, EventArgs e)
        {
            sqlRepository.GetWorkHours();
            var WorkHours = sqlRepository.GetWorkHours();
            LWWorkHour.Items.Clear();
            foreach(var W in WorkHours)
            {
                LWWorkHour.Items.Add(new ListViewItem(new string[] { W.Id.ToString(), W.Employee.ToString(), W.Contract.ToString(), W.WorkType.ToString(), W.Hour.ToString(), W.Kdy.ToString() }));
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try { 
            sqlRepository.InsertWorkHour(Convert.ToInt32(TBEmployee.Text), Convert.ToInt32(TBContract.Text), Convert.ToInt32(TBWorkType.Text), Convert.ToInt32(TBHour.Text), Convert.ToDateTime(TBKdy.Text));
            }
            catch
            {
                MessageBox.Show("Něco se pokazilo"); 
            }
            sqlRepository.GetWorkHours();
            var WorkHours = sqlRepository.GetWorkHours();
            LWWorkHour.Items.Clear();
            foreach (var W in WorkHours)
            {
                LWWorkHour.Items.Add(new ListViewItem(new string[] { W.Id.ToString(), W.Employee.ToString(), W.Contract.ToString(), W.WorkType.ToString(), W.Hour.ToString(), W.Kdy.ToString() }));
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try { 
            sqlRepository.DeleteWorkHour(Convert.ToInt32(TBDelete.Text));
            }
            catch
            {
                MessageBox.Show("Něco se pokazilo");
            }
            sqlRepository.GetWorkHours();
            var WorkHours = sqlRepository.GetWorkHours();
            LWWorkHour.Items.Clear();
            foreach (var W in WorkHours)
            {
                LWWorkHour.Items.Add(new ListViewItem(new string[] { W.Id.ToString(), W.Employee.ToString(), W.Contract.ToString(), W.WorkType.ToString(), W.Hour.ToString(), W.Kdy.ToString() }));
            }

        }

        private void NUDID_ValueChanged(object sender, EventArgs e)
        {
            sqlRepository.GetWorkHour((int)NUDID.Value);
            var workHour = sqlRepository.GetWorkHour((int)NUDID.Value);
            if(workHour != null)
            {
                TBEmployeeE.Text = workHour.Employee.ToString();
                TBContractE.Text = workHour.Contract.ToString();
                TBWorkTypeE.Text = workHour.WorkType.ToString();
                TBHourE.Text = workHour.Hour.ToString();
                TBKdyE.Text = workHour.Kdy.ToString();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try { 
            sqlRepository.UpdateWorkHour((int)NUDID.Value, Convert.ToInt32(TBEmployeeE.Text), Convert.ToInt32(TBContractE.Text), Convert.ToInt32(TBWorkTypeE.Text), Convert.ToInt32(TBHourE.Text), Convert.ToDateTime(TBKdyE.Text));
            }
            catch
            {
                MessageBox.Show("Něco se nepovedlo");
            }


            sqlRepository.GetWorkHours();
            var WorkHours = sqlRepository.GetWorkHours();
            LWWorkHour.Items.Clear();
            foreach (var W in WorkHours)
            {
                LWWorkHour.Items.Add(new ListViewItem(new string[] { W.Id.ToString(), W.Employee.ToString(), W.Contract.ToString(), W.WorkType.ToString(), W.Hour.ToString(), W.Kdy.ToString() }));
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
    }

