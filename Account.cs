using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem {
    internal abstract class Account {
        public string accountNumber;
        public double balance;

        

        public abstract void deposit(double amount);
        public abstract void withdraw(double amount);
    }
}
