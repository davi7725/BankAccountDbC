using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountDbC
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Run();
        }

        private void Run()
        {
            Account acc = new Account("Jane", 100);
            acc.Deposit(1);
            acc.Withdraw(-1);
        }
    }
}
