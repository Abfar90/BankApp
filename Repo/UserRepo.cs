using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banken2023.Classes;
using Banken2023.Repo;

namespace Banken2023.Repo
{
    internal class UserRepo: IUserRepo
    {
        public List<Customer> GetCustomers()
        {
            Saving spar1 = new Saving(5066, 10000, 2);
            Debit debit1 = new Debit(5067, 10000, 1);
            List<Customer> UserList = new List<Customer>();
            UserList.Add(new Customer(9305106589,"123456",spar1, ));
        }
    }0,

}
