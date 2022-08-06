using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingDomainApplication
{
    public class Account
    {
        private double _AccountNumber;
        private string _CustomerName;
        private double _Balance;

        public double AccountNumber
        {
            get { return _AccountNumber; }
            set { _AccountNumber = value; }
        }
        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }
        public double Balance
        {
            get { return _Balance; }
            set { _Balance = value; }
        }
        public void getAccountHolderData(double AccountNumber, string CustomerName)
        {
            this.AccountNumber = AccountNumber;
            this.CustomerName = CustomerName;
        }
        public void Withdraw(double amount)
        {
            double AmountToBeWithdrawn = amount;
            if(amount <= Balance) 
            { 
            Balance = Balance - AmountToBeWithdrawn;
            this._Balance = Balance;
            Console.WriteLine($"Your balance has been debited with Rs. {AmountToBeWithdrawn}.");
            }
            else
            {
                Console.WriteLine("Transaction Failed! Amount to be withdrawn greater than Account Balance");
            }
        }

        public void Deposit(double amount)
        {
            double AmountToBeDeposited = amount;
            if(amount <= 0)
            {
                Console.WriteLine("Transaction Failed, Deposit amount greater than 0.");
            }
            else { 
            Balance = Balance + AmountToBeDeposited;
            this._Balance = Balance;
            Console.WriteLine($"Your balance has been credited with Rs. {AmountToBeDeposited}.");
            }
        }

        public double DisplayBalance()
        {
            return Balance;
        }

        public static void Main()
        {
            Account AccountHolder = new Account();
            Console.Write("Enter Account Number: ");
            double AccountNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name: ");
            string CustomerName = Console.ReadLine();
            AccountHolder.getAccountHolderData(AccountNumber, CustomerName);
            if (AccountHolder.Balance == 0)
            {
                Console.WriteLine($"Balance: {AccountHolder.Balance} \n");
                Console.WriteLine("Kindly maintain 50 as minimum balance");
            }
                 BalanceEventsClass info2 = new HDFCBank(); //<---- 6.5
                 info2.UnderBalance += whenUnderBalance;
        Loop:
            Console.Write("What would you like to do? \n1. Deposit \t2. Withdraw \t3. View Balance \nEnter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter amount to be deposited: ");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    AccountHolder.Deposit(amount);
                    break;
                case 2:
                    Console.Write("Enter amount to be withdrawed: ");
                    double amountwithdrawn = Convert.ToDouble(Console.ReadLine());
                   if( AccountHolder.Balance - amountwithdrawn < 1000)
                    {
                        info2.isUnderBalance();
                        break;
                    }
                    AccountHolder.Withdraw(amountwithdrawn);
                    break;
                case 3:
                    double balance = AccountHolder.DisplayBalance();
                    Console.Write($"Balance: {balance}");
                    
                    break;
                default:
                    Console.Write("Invalid Input! Try again later.");
                    break;
            }

            //Registering 2 events
           // BalanceEventsClass info = new BalanceEventsClass();   <--- FOR 6.3
            BalanceEventsClass info = new ICICIBank();
            info.UnderBalance += whenUnderBalance; //Registering an event.

            // BalanceEventsClass info1 = new BalanceEventsClass();  <--- FOR 6.3
            BalanceEventsClass info1 = new ICICIBank();
            info1.ZeroBalance += whenZeroBalance; //Registering an event.


            


            //Event Handlers

            static void whenUnderBalance()
            {
                Console.WriteLine("Balance under the mentioned limit, Under Balance Event Raised!");
            }

            static void whenZeroBalance()
            {
                Console.WriteLine("Balance is Zero, Zero Balance Event Raised!");
            }

            Console.Write("\nDo you wish to perform more operations? (Y/N): ");
            char wish = Convert.ToChar(Console.ReadLine());
            if (wish == 'Y' || wish == 'y')
            {
                if (AccountHolder.Balance == 0)
                {
                    info1.isZeroBalance();
                }
                 else if (AccountHolder.Balance < 50)
                 {   
                        info.isUnderBalance();
                  }
                 else { goto Loop; }
            }
            else if( wish == 'N' || wish == 'n')
            {
                Console.WriteLine("GoodBye");
            }
 
           
        }

    }

    //*--       EVENT HANDLING STARTS HERE        --*

    //Delegate Declaration.
    public delegate void BalanceEvents();

    public class BalanceEventsClass // Event Class Declaration    
    {
        public event BalanceEvents UnderBalance; // Declaring Events

        public void isUnderBalance()
        {
            OnUnderBalance();
        }
        protected virtual void OnUnderBalance()
        {
            UnderBalance?.Invoke();
        }

        public event BalanceEvents ZeroBalance; // Declaring Events

        public void isZeroBalance()
        {
            OnZeroBalance();
        }
        protected virtual void OnZeroBalance()
        {
            ZeroBalance?.Invoke();
        }
    }

    public class ICICIBank : BalanceEventsClass
    {
        protected override void OnUnderBalance()
        {  
            Console.WriteLine("Transaction cannot be continued as balance is insufficient in Account");
        }

        protected override void OnZeroBalance()
        {
            Console.WriteLine("Transaction cannot be continued as balance is insufficient/zero in Account");
        }
    }

    public class HDFCBank : BalanceEventsClass
    {
        protected override void OnUnderBalance()
        {
            Console.WriteLine("Transaction cannot be continued below specified limit of	Rs.-1000");
        }

        protected override void OnZeroBalance()
        {
            Console.WriteLine("Transaction cannot be continued as balance is insufficient/zero in Account");
        }
    }
}
