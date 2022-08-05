using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAssignments
{
    using System;

    namespace CSharpAssigments
    {

        public class MyStack<Type>
        {
            public Type[]? array;
            public int top, SizeOfArray;

            public MyStack(int SizeOfArray)
            {
                this.SizeOfArray = SizeOfArray;
                array = new Type[this.SizeOfArray];
                top = -1;
            }

            public void Push(Type num)
            {
                if (top < array.Length - 1)
                {
                    ++top;
                    array[top] = num;
                    Console.WriteLine($"Pushed Element: {num}");
                }
                else
                {
                    throw (new StackException("Stack Overflow: Stack is full, Can't Push!"));
                    /*Console.WriteLine("Stack Overflow");
                    Environment.Exit(1);*/
                }

            }

            public void Pop()
            {
                try
                {
                    if (top >= 0)
                    {
                        Type x = array[top];
                        --top;
                        Console.WriteLine($"Popped Element: {x}");
                    }
                    else
                    {
                        throw (new StackException("Stack Underflow: Stack is Empty, Can't Pop!"));
                    }
                }
                catch (StackException exception)
                {
                    Console.WriteLine(exception);
                }

            }

            public void ViewStack()
            {
                foreach (Type element in array)
                {
                    Console.WriteLine(element);
                }
            }

        }

        public class Program
        {


            public static void Main()
            {

                Console.Write("Enter size of the array: ");
                int SizeofArray = Convert.ToInt32(Console.ReadLine());
                MyStack<int> stack = new MyStack<int>(SizeofArray);
            Loop:
                Console.WriteLine("What action would you like to perform?\n1. Push \t2.Pop \t\t3. View Stack");
                Console.Write("Enter your choice in number: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        stack.Push(1);
                        break;
                    case 2:
                        stack.Pop();
                        break;
                    case 3:
                        stack.ViewStack();
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        goto Loop;
                        break;
                }
                Console.Write("Do you wish to continue? (Y/N): ");
                char wish = Convert.ToChar(Console.ReadLine());
                if (wish == 'y' || wish == 'Y')
                {
                    goto Loop;
                }
                else if (wish == 'n' || wish == 'N')
                {
                    Console.WriteLine("Stack: ");
                    stack.ViewStack();
                    Console.WriteLine("Thanks!");
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                }

            }
        }

        public class StackException : Exception
        {
            public StackException(string message) : base(message)
            {
            }
        }
    }

}
