using System;

namespace BankingDomainApplication
{
    public class Customer
    {
        public int AccountNumber;
        public string CustomerName;

        public void getData(int AccountNumber, string CustomerName)
        {
            this.AccountNumber = AccountNumber;
            this.CustomerName = CustomerName;
        }
        public static void Main()
        {
            try
            {
                Customer MyCustomer = new Customer();
                Console.Write("Enter Account Number: ");
                int AccountNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Name: ");
                string CustomerName = Console.ReadLine();
                MyCustomer.getData(AccountNumber, CustomerName);
                string path = @"C:\Users\arfin\Desktop\FileIO\CustomerDetails.txt";
                // Writing Customer Details
                StreamWriter sw = File.CreateText(path);
                sw.WriteLine($"Account number: {AccountNumber}");
                sw.WriteLine($"Name of Customer: {CustomerName}");
                sw.WriteLine("New Customer, Balance = 0");
                sw.Close();

                //Reading Customer Details
                using (StreamReader file = new StreamReader(path))
                {
                    int counter = 0;
                    string ln;
                    while ((ln = file.ReadLine()) != null)
                    {
                        Console.WriteLine(ln);
                        counter++;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType().Name);
            }

        }

    }
}
