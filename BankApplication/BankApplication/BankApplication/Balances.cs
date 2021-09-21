using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Balances:IAction
    {
        public void DoAction()
        {
            Console.Clear();
            Console.WriteLine("Name \t\t Currenct Balances");
            Console.WriteLine("-----------------------------------");
            foreach (var item in Manager.ListofAccounts)
                Console.WriteLine(item.Key + "\t\t" + item.Value);
            Console.Read();
        }
    }
}
