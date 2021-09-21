using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class NewAccount:IAction
    {
        public void DoAction()
        {
            string name = "";
            int passKey = 0;
            try
            {
                Console.Clear();
                Console.Write("Account holder Name:");
                var AccountHolderName = Console.ReadLine();
                if (!Manager.ListofAccounts.ContainsKey(AccountHolderName))
                {
                    name = AccountHolderName;
                    Manager.ListofAccounts.Add(AccountHolderName, 0.00m);
                    passKey = this.CreatePassword(AccountHolderName);
                    Manager.Audit.Add(AccountHolderName, new List<string>());
                    List<string> list = Manager.Audit[AccountHolderName];
                    list.Add("Account added and balance 0.00");
                }
                else
                    Console.WriteLine("Account is already existed by this name");
            }
            catch
            {
                Console.WriteLine("Please try again");
                return;
            }
            Console.WriteLine("Account has been created on {0}", name);
            Console.WriteLine("Password of the account on {0} {1}", name,passKey);
            Console.Read();
        }
        public int CreatePassword(string Name)
        {
            var flag = true;
            while(flag)
            {
                int password = GenerateRandomNo();
                if(!Manager.ListofAccounts.ContainsValue(password))
                {
                    Manager.ListofPasswords.Add(Name, password);
                    return password;
                }
            }
            return 0;
        }
        public int GenerateRandomNo()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }
    }
}
