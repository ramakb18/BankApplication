using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class AccountOwner : Person
    {
        public int CustomerId { get; }

        public AccountOwner(int customerId, string firstName, string lastName)
            : base(firstName, lastName)
        {
            CustomerId = customerId;
        }
    }
}
