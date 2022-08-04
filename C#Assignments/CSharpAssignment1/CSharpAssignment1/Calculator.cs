using System;

namespace CSharpAssignment1
{
    class Calculator
    {
        public static void Main()
        {
            int num1, num2, choice, result;
            Console.WriteLine("Calculator Program");
        Loop:
            Console.Write("Enter 1st number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The two numbers are: {num1} and {num2}");
            Console.WriteLine("What operation would you like to perform? \n 1. Addition \n 2. Subtraction \n 3. Multiplication \n 4. Division");
            Console.Write("Enter your choice in number (1,2,3 or 4):");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine($"Addition: {result}");
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine($"Subtraction: {result}");
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine($"Multiplication: {result}");
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Exception: Cannot divide {num1}/{num2}");
                        break;
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Division: {result}");
                        break;
                    }
                default:
                    Console.WriteLine("Enter valid option!");
                    break;

            }
            Console.Write("Do you want to exit? (Y/N):");
            char choose = Convert.ToChar(Console.ReadLine());
            if (choose == 'N' || choose == 'n')
                goto Loop;
            else
                Console.WriteLine("Goodbye!");
        }
    }
}

