using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken2023.Classes
{
    internal class Saving : Account
    {
        public Saving(int accountNumber, int balance, AccountCategory category) : base(accountNumber, balance, category)
        {
        }
    }
}
