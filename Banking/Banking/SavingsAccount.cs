using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class SavingsAccount : Account
    {
        private string Accholder;
        private double balance;
        private string accounttype = "Savings Account";
        private int account_number;
        private int transcation_count = 0;
        public SavingsAccount(int userid, string name, int accNumber, double bal)
        {
            this.userId = userid;
            this.Accholder = name;
            this.balance = bal;
            this.account_number = accNumber;

        }
        public override void AccountDetails()
        {
            Console.WriteLine(" Account UserId = " + this.userId);
            Console.WriteLine(" Account Holder Name = " + this.Accholder);
            Console.WriteLine("Account number  = " + this.account_number);
            Console.WriteLine("Account type = " + this.accounttype);
            Console.WriteLine(" Account balance = " + this.balance);

        }

        public override void Deposite(int depositeAmmount)
        {
            this.balance += depositeAmmount;

        }

    }
}