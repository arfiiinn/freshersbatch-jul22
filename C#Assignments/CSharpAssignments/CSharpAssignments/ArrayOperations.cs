//Assignment 5 Q1.
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAssigments
{
    class ArrayOperations
    {
        public void IntegerOperations()
        {
            Console.Write("Enter size of 1st array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            int[] arr2 = new int[size];

            Console.WriteLine("Enter elements in the 1st array: ");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("1st Array Elements:");
            foreach (int elements in arr)
            {
                Console.Write($"{elements} ");
            } 

            // Copying array to another array.
            Array.Copy(arr, arr2, size);

            Console.WriteLine("\nElements copied from 1st to 2nd array are:");
            foreach (int elements in arr2)
            {
                Console.Write($"{elements} ");
            }

            //Sorting elements in an Array.
            Array.Sort(arr);
            Console.WriteLine("\nSorted Elements: ");
            foreach (int sortedElement in arr)
            {
                Console.Write($"{sortedElement} ");
            }

            //Clear Arrays
            Array.Clear(arr, 2, 2);
            Console.WriteLine("\nClear Elements: ");
            foreach (int elements in arr)
            {
                Console.Write($"{elements} ");
            }

            //Reversing Array
            Array.Reverse(arr);
            Console.WriteLine("\nReversed Elements: ");
            foreach (int b in arr)
            {
                Console.Write($"{b} ");
            }
        }


        public void StringOperations()
        {
            Console.Write("\nEnter Size of an Array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            string[] str = new string[size];
            string[] str2 = new string[size];

            Console.WriteLine("Enter string elements in 1st array: ");
            for (int i = 0; i < size; i++)
            {
                str[i] = Console.ReadLine();
            }

            Console.WriteLine("\nString Elements in 1st Array: ");
            foreach (string elements in str)
            {
                Console.Write($"{elements} ");
            }

            Array.Copy(str, str2, size);
            Console.WriteLine("\nCopying strings from 1st array to 2nd array: \nString Elements in 2nd Array ");
            foreach (string elements in str2)
            {
                Console.Write($"{elements} ");
            }

            //Sorting String
            Array.Sort(str);
            Console.WriteLine("\nSort Strings:");

            foreach (string a in str)
            {
                Console.Write($"{a} ");
            }

            Array.Clear(str, 1, 2);
            Console.WriteLine("\nClear Strings:");

            foreach (string n in str)
            {
                Console.Write($"{n} ");
            }

            Array.Reverse(str);
            Console.WriteLine("\nReverse Strings:");

            foreach (string b in str)
            {
                Console.WriteLine(b);
            }

        }
        public static void Main(string[] args)
        {
            ArrayOperations MyArray = new ArrayOperations();
            MyArray.IntegerOperations();
            Console.WriteLine("\n---------------\n");
            MyArray.StringOperations();
  
        }
    }
}