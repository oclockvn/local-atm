using LocalAtm.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LocalAtm.Lib.Services
{
    public class AtmService
    {
        private List<Account> accounts = [];
        private Account? currentAccount = null;

        public async Task LoadAccountsAsync(string path)
        {
            ArgumentNullException.ThrowIfNullOrWhiteSpace(path, nameof(path));

            if (!File.Exists(path))
            {
                return;
            }

            var json = await File.ReadAllTextAsync(path);
            accounts = JsonSerializer.Deserialize<List<Account>>(json,
                new JsonSerializerOptions(JsonSerializerDefaults.Web)) ?? [];
        }

        public bool Login(string cardNumber, int pin)
        {
            currentAccount = accounts.SingleOrDefault(a => a.CardNumber == cardNumber && a.Pin == pin);
            return currentAccount != null;
        }
    }
}
