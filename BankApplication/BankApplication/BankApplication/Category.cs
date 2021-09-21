using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class AccountDetails
    {
        public string AccountHolderName { get; set; }
        public decimal Balance { get; set; }
    }
    public class AccountPassword
    {
        public string AccountHolderName { get; set; }
        public int Password { get; set; }
    }

}
