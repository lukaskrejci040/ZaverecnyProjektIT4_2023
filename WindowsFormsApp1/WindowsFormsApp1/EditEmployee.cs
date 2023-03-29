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
    public partial class EditEmployee : Form
    {
        SqlRepository sqlRepository;
        public EditEmployee()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""C:\USERS\KREJCI.LUKAS\DESKTOP\PROJEKT\KARANTÉNA (AKTUÁLNÍ)\PROJEKTDB (1).MDF"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }

        private void EditEmployee_Load(object sender, EventArgs e)
        {
            LWEmployee.Items.Clear();
            var Employees = sqlRepository.GetEmployees();
            foreach (var E in Employees)
            {
                LWEmployee.Items.Add(new ListViewItem(new string[] { E.IdEmployee.ToString(), E.FirstName.ToString(), E.LastName.ToString(), E.BirthDate.ToString(), E.Email.ToString(), E.Phone.ToString() }));
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try {
                sqlRepository.DeleteEmployee(Convert.ToInt32(TBDelete.Text));
            }
            catch {
                MessageBox.Show("Zadejte správnou hodnotu");
            }
            LWEmployee.Items.Clear();
            var Employees = sqlRepository.GetEmployees();
            foreach (var E in Employees)
            {
                LWEmployee.Items.Add(new ListViewItem(new string[] { E.IdEmployee.ToString(), E.FirstName.ToString(), E.LastName.ToString(), E.BirthDate.ToString(), E.Email.ToString(), E.Phone.ToString() }));
            }


        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try {
                sqlRepository.InsertEmployee(TBFirstName.Text, TBLastName.Text, Convert.ToDateTime(TBBirthDate.Text), TBEmail.Text, TBPhone.Text);
            }
            catch
            {
                MessageBox.Show("Něco se pokazilo");
            }
            LWEmployee.Items.Clear();
            var Employees = sqlRepository.GetEmployees();
            foreach (var E in Employees)
            {
                LWEmployee.Items.Add(new ListViewItem(new string[] { E.IdEmployee.ToString(), E.FirstName.ToString(), E.LastName.ToString(), E.BirthDate.ToString(), E.Email.ToString(), E.Phone.ToString() }));
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try { 
            sqlRepository.UpdateEmployee(Convert.ToInt32(NUDID.Value), TBFirstNameEdit.Text, TBLastNameEdit.Text, Convert.ToDateTime(TBBirthDateEdit.Text), TBEmailEdit.Text, TBPhoneEdit.Text);
            }
            catch
            {
                MessageBox.Show("Neplatné údaje");
            }
            LWEmployee.Items.Clear();
            var Employees = sqlRepository.GetEmployees();
            foreach (var E in Employees)
            {
                LWEmployee.Items.Add(new ListViewItem(new string[] { E.IdEmployee.ToString(), E.FirstName.ToString(), E.LastName.ToString(), E.BirthDate.ToString(), E.Email.ToString(), E.Phone.ToString() }));
            }
        }



        private void NUDID_ValueChanged(object sender, EventArgs e)
        {
            sqlRepository.GetEmployee((int)NUDID.Value);
            var employee = sqlRepository.GetEmployee((int)NUDID.Value);
            if(employee != null)
            {
                TBFirstNameEdit.Text=employee.FirstName;
                TBLastNameEdit.Text = employee.LastName;
                TBBirthDateEdit.Text = employee.BirthDate.ToString();
                TBEmailEdit.Text = employee.Email;
                TBPhoneEdit.Text = employee.Phone;
            }
        }
    }
}
