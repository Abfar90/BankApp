using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken2023.Classes
{
    internal class Debit : Account
    {
        public Debit(int accountNumber, int balance, AccountCategory category) : base(accountNumber, balance, category)
        {
        }
    }
}
