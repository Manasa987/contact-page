using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Audit:IAction
    {
        int value;
        bool flag;
        public void DoAction()
        {
            Console.Clear();
            Console.WriteLine("pls enter Amount which the audit to be done ");
            try
            {
                value = Int32.Parse(Console.ReadLine());
                flag = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Enter the numeric Data");
            }
            if (flag)
            {
                var listofUsers = Manager.ListofAccounts.Where(x => x.Value >= value);
                var users = listofUsers.Select(x => x.Key);
                Console.Clear();
                foreach (var item in users)
                {
                    Console.WriteLine("{0} {1}", item, Manager.ListofAccounts[item]);
                    var AuditData = Manager.Audit[item];
                    if (AuditData.Count == 0)
                    {
                        Console.WriteLine("No transactionsdone by the user");
                    }
                    foreach (var data in AuditData)
                        Console.WriteLine(data);
                    Console.WriteLine("----------------------------");
                }
                Console.Read();
            }
        }
    }
}
