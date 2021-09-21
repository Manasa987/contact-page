using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Withdrawl:IAction
    {
        string user;
        int password, Amount;
        decimal balance;
        bool flag,amountFlag;
        public void DoAction()
        {
            Console.Clear();
            Console.Write("Account holder name:");
            user = Console.ReadLine();
            if(Manager.ListofPasswords.ContainsKey(user))
            {
                Console.Write("Password:");
                try
                {
                    password = Int32.Parse(Console.ReadLine());
                    flag = true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Enter the numeric Data");
                }
                if(flag && Manager.ListofPasswords[user] == password)
                {
                    Console.WriteLine("Access Granted");
                    Console.Write("Amount to get deducted:");
                    try
                    {
                        Amount = Int32.Parse(Console.ReadLine());
                        amountFlag = true;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Enter valid number for the amount");
                    }
                    if (amountFlag)
                    {
                        balance = Manager.ListofAccounts[user];
                        if (Amount > balance)
                        {
                            Console.WriteLine("No sufficient balance");
                        }
                        else
                        {
                            Manager.ListofAccounts[user] = Manager.ListofAccounts[user] - Amount;
                            List<string> list = Manager.Audit[user];
                            list.Add("Amount has been Withdrawn from your account");
                            Console.WriteLine(" Account balance of {0} is {1}", user, Manager.ListofAccounts[user]);
                        }
                    }
                }
                else
                    Console.WriteLine("Enter valid password");
            }
            else
                Console.WriteLine("User doesn't exists");
                Console.Read();
        }
    }
}
