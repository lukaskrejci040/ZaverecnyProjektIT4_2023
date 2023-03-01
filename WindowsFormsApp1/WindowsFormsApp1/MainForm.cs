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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        SqlRepository sqlRepository;
        public MainForm()
        {
            InitializeComponent();
             sqlRepository = new SqlRepository(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Projekt PRG\ZaverecnyProjektIT4_2023 (aktuální)\projektDB.mdf"";Integrated Security=True;Connect Timeout=30");
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
                LWMain.Items.Add(new ListViewItem(new string[] { p.IdUser.ToString(), p.IdEmployee.ToString(), p.Jmeno.ToString(), p.Heslo.ToString(), p.PasswordSalt.ToString() }));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlRepository.Delete(Convert.ToInt32(TBDelete.Text));
        }
    }
}
