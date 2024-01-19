using LocalAtm.Lib;
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
    public partial class WidthdrawForm : Form
    {
        private readonly AtmService atmService;

        public WidthdrawForm(AtmService atmService)
        {
            this.atmService = atmService;
            InitializeComponent();
        }

        private async void btnAccept_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAmount.Text.Trim(), out var amount))
            {
                return; // not a number
            }

            var widthdrawSuccess = atmService.Widthdraw(amount);
            if (!widthdrawSuccess)
            {
                return; // show error
            }

            await atmService.WriteAccountsAsync(Constants.BANK_PATH);
            Close();
        }
    }
}
