using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace BankApplication
{
    public static class DataService
    {
        public static List<AccountDetails> GetAllAccountDetails()
        {
            var accountDetails = new List<AccountDetails>()
            {
                 new AccountDetails{ AccountHolderName = "Evan", Balance=7 },
                 new AccountDetails{ AccountHolderName = "Rong", Balance=370},
                 new AccountDetails{ AccountHolderName = "J", Balance=530 },
                 new AccountDetails{ AccountHolderName = "David", Balance=297 },
                 new AccountDetails{ AccountHolderName = "Dan", Balance=100},
                 new AccountDetails{ AccountHolderName = "Taylor", Balance=135}
            };

            return accountDetails;

        }

        public static List<AccountPassword> GetAllAccountPassword()
        {
            var accountPasswords = new List<AccountPassword>()
            {
                 new AccountPassword{ AccountHolderName = "Evan", Password =5232 },
                 new AccountPassword{ AccountHolderName = "Rong", Password =9999},
                 new AccountPassword{ AccountHolderName = "J", Password =1234 },
                 new AccountPassword{ AccountHolderName = "David", Password =0000 },
                  new AccountPassword{ AccountHolderName = "Dan", Password =4567 },
                 new AccountPassword{ AccountHolderName = "Taylor", Password =9753 }
            };

            return accountPasswords;

        }
    }
}