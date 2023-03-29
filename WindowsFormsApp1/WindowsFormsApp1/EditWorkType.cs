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
    public partial class EditWorkType : Form
    {
        SqlRepository sqlRepository;
        public EditWorkType()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""C:\USERS\KREJCI.LUKAS\DESKTOP\PROJEKT\KARANTÉNA (AKTUÁLNÍ)\PROJEKTDB (1).MDF"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }

        private void EditWorkType_Load(object sender, EventArgs e)
        {
            sqlRepository.GetWorkTypes();
            var workType = sqlRepository.GetWorkTypes();
            LWWorkType.Items.Clear();
            foreach (var w in workType)
            {
                
                LWWorkType.Items.Add(new ListViewItem(new string[] { w.Id.ToString(), w.Name, w.Description }));
            }
        }

        

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                sqlRepository.DeleteWorkType(Convert.ToInt32(TBDelete.Text));
            }
            catch
            {
                MessageBox.Show("Něco se nepovedlo");
            }
            sqlRepository.GetWorkTypes();
            var workType = sqlRepository.GetWorkTypes();
            LWWorkType.Items.Clear();
            foreach (var w in workType)
            {

                LWWorkType.Items.Add(new ListViewItem(new string[] { w.Id.ToString(), w.Name, w.Description }));
            }

        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try {
            sqlRepository.InsertWorkType(TBName.Text, TBDescription.Text);
            }
            catch
            {
                MessageBox.Show("Něco se pokazilo");
            }
            sqlRepository.GetWorkTypes();
            var workType = sqlRepository.GetWorkTypes();
            LWWorkType.Items.Clear();
            foreach (var w in workType)
            {

                LWWorkType.Items.Add(new ListViewItem(new string[] { w.Id.ToString(), w.Name, w.Description }));
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try { 
            sqlRepository.UpdateWorkType(Convert.ToInt32(NUDID.Value), TBNameEdit.Text, TBDescriptionEdit.Text);
            }
            catch
            {
                MessageBox.Show("Něco se nepovedlo");
            }
            sqlRepository.GetWorkTypes();
            var workType = sqlRepository.GetWorkTypes();
            LWWorkType.Items.Clear();
            foreach (var w in workType)
            {

                LWWorkType.Items.Add(new ListViewItem(new string[] { w.Id.ToString(), w.Name, w.Description }));
            }
        }

        private void NUDID_ValueChanged(object sender, EventArgs e)
        {
            sqlRepository.GetWorkType((int)NUDID.Value);
            var WorkType = sqlRepository.GetWorkType((int)NUDID.Value);
            if(WorkType != null)
            {
                TBNameEdit.Text=WorkType.Name;
                TBDescriptionEdit.Text = WorkType.Description;
            }
        }
    }
}
