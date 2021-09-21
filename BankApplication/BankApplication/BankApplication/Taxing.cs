using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Taxing : IAction
    {
        decimal toaltax = 0.00m;
        decimal taxpercentage;
        public void DoAction()
        {
            Console.Clear();
            Console.Write("How much tax(in %) should be  subtracted from each account?");
            string input = Console.ReadLine();
            Console.Clear();

            if (decimal.TryParse(input, out taxpercentage))
            {
                Console.WriteLine("Subtracted {0}%tax from each account", taxpercentage);
                Console.WriteLine("\n Name \t\t Taxes");
                Console.WriteLine("---------------------------");
                var taxvalue = taxpercentage / 100;
                var listofValues =Manager.ListofAccounts.Select(x => x.Value * (1 - taxvalue));
                foreach (var item in listofValues)
                {
                    Console.WriteLine(item);
                    toaltax = toaltax + item;
                }
                Console.WriteLine("\n Total tax from all the accounts is {0}", toaltax);

            }
            else
                Console.WriteLine("Provide proper number");
                Console.Read();
        }
    }
}
