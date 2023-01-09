using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banken2023.Classes;

namespace Banken2023.Classes
{
    internal class Customer
    {
        public int SocialSecNumber { get; set; }
        public string Password { get; set; }
        public Saving SavingAccount { get; set; }
        public Debit DebitAccount { get; set; }

        public Customer(int socialSecNumber, string password, Saving savingAccount, Debit debitAccount)
        {
            SocialSecNumber = socialSecNumber;
            Password = password;
            SavingAccount = savingAccount;
            DebitAccount = debitAccount;
        }
    }
}
