using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalAtm
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void btnViewBalance_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Your balance is: 5000USD", "Balance", MessageBoxButtons.OK);
        }

        private void btnWidthdraw_Click(object sender, EventArgs e)
        {

        }

        private void btnViewTransactions_Click(object sender, EventArgs e)
        {

        }
    }
}
