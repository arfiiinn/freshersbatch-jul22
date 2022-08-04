//Assignemnt 4 
using System;

namespace CSharpAssigments
{

    public class MyStack : ICloneable
    {
        public int[] array;
        public int top, SizeOfArray;

        public MyStack(int SizeOfArray)
        {
            this.SizeOfArray = SizeOfArray;
            array = new int[this.SizeOfArray];
            top = -1;
        }

        void Push()
        {
            if (top < array.Length-1)
            {
                Console.Write("Enter element to be pushed: ");
                int num = Convert.ToInt32(Console.ReadLine());
                ++top;
                array[top] = num;
                Console.WriteLine($"Pushed Element: {num}");
            }
            else
            {
                throw (new StackException ("Stack Overflow: Stack is full, Can't Push!"));
                /*Console.WriteLine("Stack Overflow");
                Environment.Exit(1);*/
            }

        }

        void Pop()
        {
            try
            {
                if (top >= 0)
                {
                    int x = array[top];
                    array[top] = 0;
                    --top;
                    Console.WriteLine($"Popped Element: {x}");
                }
                else
                {
                    /* Console.WriteLine("Stack Underflow");
                     Environment.Exit(1); */
                    throw (new StackException("Stack Underflow: Stack is Empty, Can't Pop!"));
                }
            }
            catch (StackException exception)
            {
                Console.WriteLine(exception);
            }
            
        }

        void ViewStack()
        {
            foreach(int element in array)
            {
                Console.WriteLine(element);
            }
        }

        public object Clone()
        {
            var stack = (MyStack)MemberwiseClone();
            return stack;
        }

        public static void Main()
        {
            
            Console.Write("Enter size of the array: ");
            int SizeofArray = Convert.ToInt32(Console.ReadLine());
            MyStack stack = new MyStack(SizeofArray);
            Loop:
            Console.WriteLine("What action would you like to perform?\n1. Push \t2.Pop \t\t3. View Stack");
            Console.Write("Enter your choice in number: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    stack.Push();
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
            if(wish == 'y' || wish == 'Y')
            {
                goto Loop;
            }
            else if(wish == 'n' || wish == 'N')
            {
                Console.WriteLine("Stack: ");
                stack.ViewStack();
                Console.WriteLine("Thanks!");
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }

            Console.WriteLine("Cloned stack using Clone from ICloneable.");
            var cloned = (MyStack)stack.Clone();
            cloned.ViewStack();

        }
    }

    public class StackException : Exception
    {
        public StackException(string message) : base(message)
        {
        }
    }
}
