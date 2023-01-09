using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken2023.Classes
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public int Balance { get; set; }
        public AccountCategory category { get; set; }

        public int GetBalance()
        {
            return Balance;
        }
        public void MakeDeposit()
        {

        }

        public void MakeTransaction()
        {

        }

        public Account(int accountNumber, int balance, AccountCategory category)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            this.category = category;
        }
    }
}
