using System;


namespace CSharpAssignment1
{
    class averageMarks
    {
        public static void Main()
        {
            int[] marks = new int[5];
            int highestAverage = 0;
            Console.WriteLine("Enter average marks for 5 students:");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"Enter avg marks for {i + 1} student:");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Average Marks entered for 5 students are :");
            foreach (int mark in marks)
            {
                Console.Write($"{mark} ");
            }
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] > highestAverage)
                {
                    highestAverage = marks[i];
                }

            }
            Console.WriteLine($"\n Highest Average is: {highestAverage}");

        }
    }
}
