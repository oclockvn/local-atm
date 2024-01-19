using LocalAtm.Lib.Services;
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
        private readonly AtmService atmService;

        public DashboardForm(AtmService atmService)
        {
            this.atmService = atmService;

            InitializeComponent();
        }

        private void btnViewBalance_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Your balance is: {atmService.GetCurrentBalance()}", "Balance", MessageBoxButtons.OK);
        }

        private void btnWidthdraw_Click(object sender, EventArgs e)
        {
            new WidthdrawForm().ShowDialog();
        }

        private void btnViewTransactions_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            if (atmService is null)
            {
                throw new ArgumentNullException(nameof(atmService));
            }

            this.lblUsername.Text = $"Hi, {atmService.GetCurrentAccountName()}";
        }
    }
}
