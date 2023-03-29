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
    public partial class HLNabídkaForm : Form
    {
        public HLNabídkaForm()
        {
            InitializeComponent();
        }

        private void BtnEditUser_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.ShowDialog();
        }

        private void BtnEditEmployee_Click(object sender, EventArgs e)
        {
            EditEmployee editemployee = new EditEmployee();
            editemployee.ShowDialog();
        }

        private void BtnEditContract_Click(object sender, EventArgs e)
        {
            EditContract editContract = new EditContract();
            editContract.ShowDialog();
        }

        private void BtnEditWorkType_Click(object sender, EventArgs e)
        {
            EditWorkType editWorkType = new EditWorkType();
            editWorkType.ShowDialog();
        }

        private void BtnEditWorkHour_Click(object sender, EventArgs e)
        {
            EditWorkHour editWorkHour = new EditWorkHour();
            editWorkHour.ShowDialog();
        }

        private void BtnStorno_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
