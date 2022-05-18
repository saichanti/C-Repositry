using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Account> AccountList = new List<Account>();
            CurrentAccount user1 = new CurrentAccount(111, "Saikumar", 98654, 231546);
            CurrentAccount user2 = new CurrentAccount(112, "kumar", 36567, 1257678);
            AccountList.Add(user1);
            foreach (var result in AccountList)
            {
                result.AccountDetails();
                Console.WriteLine(result);
            }
        }
    }
}
