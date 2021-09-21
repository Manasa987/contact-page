using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Total:IAction
    {
        public void DoAction()
        {
            Console.Clear();
            Double totalBalance = 0;
            foreach (double item in Manager.ListofAccounts.Values)
                totalBalance += item;
            Console.WriteLine("Banks total Account balances is{0} : ", totalBalance);
            Console.Read();
        }
    }
}
