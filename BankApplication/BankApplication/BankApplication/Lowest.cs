using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Lowest:IAction
    {
        public void DoAction()
        {
            Console.Clear();
            Console.WriteLine("List of users having lower balances");
            Console.WriteLine("-----------------------------------");
            var sortedDict = (from item in Manager.ListofAccounts
                              orderby item.Value
                              ascending
                              select item).Take(3);
            foreach (var item in sortedDict)
                Console.WriteLine(item.Key + "\t\t" + item.Value);
            Console.Read();
        }
    }
}
