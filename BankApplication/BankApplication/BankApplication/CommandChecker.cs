using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class CommandChecker
    {
        public IAction getAction(string managerCommand)
        {
            switch (managerCommand)
            {
                case "newaccount":
                    return new NewAccount();
                case "balances":
                    return new Balances();
                case "tax":
                    return new Taxing();
                case "total":
                    return new Total();
                case "open":
                    return new Access();
                case "withdrawal":
                    return new Withdrawl();
                case "lowest":
                    return new Lowest();
                case "audit":
                    return new Audit();
                default:
                    Console.WriteLine("Enter Proper command");
                    return null;
             }
         }
    }

    public interface IAction
    {
        void DoAction();
    }
}
