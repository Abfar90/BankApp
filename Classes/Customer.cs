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
        public string UserName { get; set; }
        public string Password { get; set; }
        public Saving SavingAccount { get; set; }
        public Debit DebitAccount { get; set; }
    }
}
