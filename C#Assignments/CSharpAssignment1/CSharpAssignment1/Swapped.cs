using System;

namespace CSharpAssignment1
{
    class Swapped
    {
        void swapped(int num1, int num2)
        {
            int c;
            c = num2;
            num2 = num1;
            num1 = c;
            Console.WriteLine($"\nNumbers after swapping: {num1} and {num2}");
        }
        public static void Main()
        {
            int a, b;
            Console.WriteLine("Swapping Numbers Program");
            Console.Write("Enter 1st number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Numbers before swapping: {a} and {b}");
            Swapped s = new Swapped();
            s.swapped(a, b);
        }
    }
}
