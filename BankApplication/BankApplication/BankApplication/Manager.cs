using System;
using System.Collections.Generic;
using System.Linq;

namespace BankApplication
{
    class Manager
    {

        public static Dictionary<string, decimal> ListofAccounts = new Dictionary<string, decimal>();
        public static Dictionary<string, int> ListofPasswords = new Dictionary<string, int>();
        public static Dictionary<string, List<string>> Audit = new Dictionary<string, List<string>>();

        static void Main(string[] args)
        {
            loadingData();
            bool flag = true;
            while (flag)
            {
                int i = 1;
                Console.Clear();
                Console.WriteLine("Please give the command of the following or type Exit ");
                foreach (var item in Enum.GetValues(typeof(Commands.cmd)))
                    Console.WriteLine("\t" + item);
                Console.WriteLine("\n");
                string managerCommand = Console.ReadLine().ToLower();
                if (managerCommand == "exist")
                    return;
                CommandChecker cmdCheck = new CommandChecker();
                IAction Command = cmdCheck.getAction(managerCommand);
                if (Command != null)
                    Command.DoAction();
            }
        }
         public static void loadingData()
        {
            foreach (var x in DataService.GetAllAccountDetails().ToList())
            {
                ListofAccounts.Add(x.AccountHolderName, x.Balance);
                Audit.Add(x.AccountHolderName, new List<string>());
            }
            foreach (var x in DataService.GetAllAccountPassword().ToList())
            {
                ListofPasswords.Add(x.AccountHolderName, x.Password);
            }
        }
    }
}
