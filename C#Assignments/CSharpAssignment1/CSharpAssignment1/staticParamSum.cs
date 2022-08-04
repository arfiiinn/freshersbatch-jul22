using System;

namespace CSharpAssignment1
{
    class staticParamSum
    {
        public static void Sum(params int[] ints) //Static method
        {
            int sum = 0;
            foreach (int num in ints)
            {
                sum += num;
            }
            Console.WriteLine("Sum of " + ints.Length + $" numbers: {sum}");

        }
        public static void Main()
        {
            int length;
            Loop:
            Console.Write("Enter length of the array: ");
            length = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (length == 0 || length < 0)
                    throw new IndexOutOfRangeException("Length of array lesser than or equal to zero.\n Enter appropriate length of array.");
            }
            catch
            {
                Console.WriteLine("Length of array lesser than or equal to zero.\nEnter appropriate length of array.");
                goto Loop;
            }
            Console.WriteLine($"Enter {length} elements for array:");
            int[] ints = new int[length];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Array elements: { ");
            for (int i = 0; i < ints.Length; i++)
            {
                if (i == ints.Length-1)
                    Console.Write(ints[i] + " }\n\n");
                else
                    Console.Write(ints[i] + ", ");
            }
            Sum(ints); // Calling static method in main.
        }

    }
}