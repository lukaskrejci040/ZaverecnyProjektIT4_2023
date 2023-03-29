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
    public partial class ContractList : Form
    {
        SqlRepository sqlRepository;
        public ContractList()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\krejci.lukas\Desktop\Projekt\KARANTÉNA (AKTUÁLNÍ)\projektDB (1).mdf';Integrated Security=True;Connect Timeout=30");

        }

        private void ContractList_Load(object sender, EventArgs e)
        {
            sqlRepository.GetContract();
            var contract = sqlRepository.GetContract();
            LWContract.Items.Clear();
            foreach (var c in contract)
            {

                LWContract.Items.Add(new ListViewItem(new string[] { c.Id.ToString(), c.Customer, c.Description }));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
