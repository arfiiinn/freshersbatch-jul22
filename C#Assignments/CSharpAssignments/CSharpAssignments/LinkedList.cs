using System;
using System.Collections.Generic;
using System.Linq;
using LitwareLib;

namespace CSharpAssignments
{
    public class LinkedList
    {
        public static void Main() {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            int id;
            string name;
            double salary;

            List<Employee> EmployeeList = new List<Employee>();
            Console.WriteLine("Performing Operation: Adding new employee to List.");
            EmployeeList.Add(emp1); EmployeeList.Add(emp2);

            foreach (Employee employee in EmployeeList)
            {
                Console.Write("Enter ID: ");
                id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Name: ");
                name = Console.ReadLine();
                Console.Write("Enter Salary: ");
                salary = Convert.ToDouble(Console.ReadLine());
                employee.GetEmployeeData(id, name, salary);
            }

            Console.WriteLine("\nPerforming Operation: Displaying the list of employees in List.");
            foreach (Employee employee in EmployeeList)
            {
                Console.WriteLine($"ID: {employee._Empno} \t Name: {employee._EmpName} \t Salary: {employee._Salary}");
            }

            Console.WriteLine("\nPerforming Operation: Total number of employees in list.");
            Console.WriteLine("There are " + EmployeeList.Count +" employees in list");

            Console.WriteLine("\n Searching name: Arfin in List");
            var found = EmployeeList.FirstOrDefault(employee => employee._EmpName == "Arfin");
            if (found != null)
            {
                Console.WriteLine("Employee name exists");
            }
            else
            {
                Console.WriteLine("Employee name doesn't exists");
            }

        }
    }
}
