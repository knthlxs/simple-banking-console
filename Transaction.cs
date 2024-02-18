namespace BankingSystem {
    internal class Transaction {
        static void Main(string[] args) {
            int choice;
            string accountNumber;
            Account acc = null;
            bool again = true;
            double amount;
            double initialBalance;

            Console.Write("Welcome to PLV Banking System! Let's create your account.\nChoose from the account type:\n1. Savings Account\n2. Checking Account\n> ");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your account number: ");
            accountNumber = Console.ReadLine();
            Console.Write("Enter your initial balance: ");
            initialBalance = Convert.ToDouble(Console.ReadLine());

            switch (choice) {
                case 1: {
                    acc = new SavingsAccount();
                    break;
                }
                case 2: {
                    acc = new CheckingAccount();
                    break;
                }
            }

            acc.balance = initialBalance;

            while (again) {
                int againChoice;
                Console.Write("What would you like to do?\n1. Check Balance\n2. Deposit\n3. Withdraw\n4. Quit/Exit\n> ");
                againChoice = Convert.ToInt32(Console.ReadLine());

                switch (againChoice) {
                    case 1: {
                        Console.WriteLine($"Account Number: {accountNumber}\nBalance: {acc.balance}");
                        break;
                    }
                    case 2: {
                        Console.Write("Enter the amount you want to deposit: ");
                        amount = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Account Number: {accountNumber}\nPrevious account balance: {acc.balance}");
                        acc.deposit(amount);
                        Console.WriteLine($"Updated account balance: {acc.balance}\n");

                        break;
                    }
                    case 3: {
                        Console.Write("Enter the amount you want to withdraw: ");
                        amount = Convert.ToDouble(Console.ReadLine());
                        if (amount <= acc.balance) {
                            Console.WriteLine($"Account Number: {accountNumber}\nPrevious account balance: {acc.balance}");
                            acc.withdraw(amount);
                            Console.WriteLine($"Updated account balance: {acc.balance}\n");
                        } else {
                                Console.WriteLine("Insufficient balance.\n");
                            }
                           
                        break;
                    }
                    case 4: {
                        again = false;
                        break;
                    }
                }
            };
            Console.WriteLine("Thank you for transacting with us!");
        }
    }
}