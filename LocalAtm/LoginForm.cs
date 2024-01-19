using LocalAtm.Lib.Services;

namespace LocalAtm
{
    public partial class LoginForm : Form
    {
        private AtmService atmService = new();

        public LoginForm()
        {
            InitializeComponent();
            btnLogin.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var cardNumber = txtCardNumber.Text?.Trim();
            var pin = txtPin.Text?.Trim();

            if (string.IsNullOrWhiteSpace(cardNumber) || string.IsNullOrWhiteSpace(pin))
            {
                // show error
                return;
            }

            if (!int.TryParse(pin, out var pinNumber))
            {
                // show pin error
                return;
            }

            var valid = atmService.Login(cardNumber, pinNumber);
            if (!valid)
            {
                return;
            }

            Hide();
            new DashboardForm(atmService).ShowDialog();
        }

        private async void LoginForm_Load(object sender, EventArgs e)
        {
            await atmService.LoadAccountsAsync("bank.json");
            btnLogin.Enabled = true;
        }
    }
}
