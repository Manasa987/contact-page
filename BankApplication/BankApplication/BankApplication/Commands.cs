using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Commands
    {
        public enum cmd
        {
            newaccount, balances, total, tax, open, withdrawal, lowest, audit
        }
    }

}
