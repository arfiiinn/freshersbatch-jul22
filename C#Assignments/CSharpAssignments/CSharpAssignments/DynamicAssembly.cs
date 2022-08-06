using System;
using System.Reflection;

namespace Reflectionexample
{
    class Employee
    {
        public int empno
        {
            get;
            set;
        }

        public string empName
        {
            get;
            set;
        }
        public double salary
        {
            get;
            set;
        }

        public Employee()
        {
            empno = 0;
            empName = string.Empty;
            salary = 0;
        }

        // Parameterised Constructor
        public Employee(int eno, string n, double sal)
        {
            empno = eno;
            empName = n;
            salary = sal;
        }
        public void displayData()
        {
            Console.WriteLine($"Employee Number : {empno}" );
            Console.WriteLine($"Eployee Name : {empName}");
            Console.WriteLine($"Employee Salary :{salary}");
        }
    }

    class DynamicAssembly
    {
        public static void Main()
        {

            Assembly executing = Assembly.GetExecutingAssembly();

            Type[] types = executing.GetTypes();
            foreach (var item in types)
            {

                Console.WriteLine("Class : {0}", item.Name);


                MethodInfo[] methods = item.GetMethods();
                foreach (var method in methods)
                {

                    Console.WriteLine("--> Method : {0}", method.Name);


                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var arg in parameters)
                    {

                        Console.WriteLine("----> Parameter : {0} Type : {1}",
                                                arg.Name, arg.ParameterType);
                    }
                }
            }
        }
    }
}
