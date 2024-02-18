using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem {
    internal class CheckingAccount : Account {
        public override void deposit(double amount) {
            balance += amount;
        }

        public override void withdraw(double amount) {
            balance -= amount;
        }
    }
}
