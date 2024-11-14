using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
   public class AccountAdmin : Person 
    {
        public int EmployeeId { get; }

        public AccountAdmin(int employeeId, string firstName, string lastName)
            : base(firstName, lastName)
        {
            EmployeeId = employeeId;
        }
    }
}
