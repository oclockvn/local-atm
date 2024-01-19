﻿using LocalAtm.Lib.Models;
using System.Text.Json;

namespace LocalAtm.Lib.Services
{
    public class AtmService
    {
        private List<Account> accounts = [];
        private Account? currentAccount = null;

        public string GetCurrentAccountName()
        {
            return currentAccount?.FullName ?? "";
        }

        public int GetCurrentBalance()
        {
            return currentAccount?.Balance ?? 0;    
        }

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
