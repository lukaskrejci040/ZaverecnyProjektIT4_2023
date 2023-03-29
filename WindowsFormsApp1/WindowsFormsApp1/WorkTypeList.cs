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
    public partial class WorkTypeList : Form
    {
        SqlRepository sqlRepository;
        public WorkTypeList()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\krejci.lukas\Desktop\Projekt\KARANTÉNA (AKTUÁLNÍ)\projektDB (1).mdf';Integrated Security=True;Connect Timeout=30");
        }

        private void WorkTypeList_Load(object sender, EventArgs e)
        {
            sqlRepository.GetWorkTypes();
            var workType = sqlRepository.GetWorkTypes();
            LWWorkType.Items.Clear();
            foreach (var w in workType)
            {

                LWWorkType.Items.Add(new ListViewItem(new string[] { w.Id.ToString(), w.Name, w.Description }));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
