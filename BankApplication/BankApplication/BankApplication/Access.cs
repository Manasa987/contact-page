using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Access:IAction
    {
        string user;
        int password;
        DateTime now = DateTime.Now;
        public void DoAction()
        {
            Console.Clear();
            Console.WriteLine("Pls enter Bank Account holder name");
            user = Console.ReadLine();
            if(Manager.ListofAccounts.ContainsKey(user))
            {
                Console.WriteLine("Pls enter password");
                try
                {
                    password = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex) { }
                if (Manager.ListofAccounts[user] == password)
                {
                    Console.WriteLine("Access Granted");
                    List<string> list = Manager.Audit[user];
                    list.Add("Account has been Accessed");
                }
                else
                    Console.WriteLine("Enter Valid password");
            }
            else
                Console.WriteLine("user doesn't exit");
            Console.Read();
        }
    }
}
