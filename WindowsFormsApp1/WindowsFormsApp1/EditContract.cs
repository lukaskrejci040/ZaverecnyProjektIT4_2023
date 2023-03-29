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
    public partial class EditContract : Form
    {
        SqlRepository sqlRepository;
        public EditContract()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""C:\USERS\KREJCI.LUKAS\DESKTOP\PROJEKT\KARANTÉNA (AKTUÁLNÍ)\PROJEKTDB (1).MDF"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }

        private void EditContract_Load(object sender, EventArgs e)
        {
            sqlRepository.GetContract();
            var contract = sqlRepository.GetContract();
            LWContract.Items.Clear();
            foreach (var c in contract)
            {
                
                LWContract.Items.Add(new ListViewItem(new string[] { c.Id.ToString(), c.Customer, c.Description }));
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try { 
            sqlRepository.DeleteContract(Convert.ToInt32(TBDelete.Text));
            }
            catch
            {
                MessageBox.Show("Něco se pokazilo");
            }
            sqlRepository.GetContract();
            var contract = sqlRepository.GetContract();
            LWContract.Items.Clear();
            foreach (var c in contract)
            {

                LWContract.Items.Add(new ListViewItem(new string[] { c.Id.ToString(), c.Customer, c.Description }));
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try { 
            sqlRepository.InsertContract(TBCustomer.Text, TBDescription.Text);
            }
            catch
            {
                MessageBox.Show("Něco se pokazilo");
            }
            sqlRepository.GetContract();
            var contract = sqlRepository.GetContract();
            LWContract.Items.Clear();
            foreach (var c in contract)
            {

                LWContract.Items.Add(new ListViewItem(new string[] { c.Id.ToString(), c.Customer, c.Description }));
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try { 
            sqlRepository.UpdateContract(TBCustomerEdit.Text, TBDescriptionEdit.Text, Convert.ToInt32(NUDID.Value));
            }
            catch
            {
                MessageBox.Show("Něco se pokazilo");
            }
            sqlRepository.GetContract();
            var contract = sqlRepository.GetContract();
            LWContract.Items.Clear();
            foreach (var c in contract)
            {

                LWContract.Items.Add(new ListViewItem(new string[] { c.Id.ToString(), c.Customer, c.Description }));
            }
        }

        private void NUDID_ValueChanged(object sender, EventArgs e)
        {
            sqlRepository.GetContrac((int)NUDID.Value);
            var contac = sqlRepository.GetContrac((int)NUDID.Value);
            
            if(contac != null)
            {
                TBCustomerEdit.Text = contac.Customer;
                TBDescriptionEdit.Text= contac.Description;
            }
        }
    }
}
