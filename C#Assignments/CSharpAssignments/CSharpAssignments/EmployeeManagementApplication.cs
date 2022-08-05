using System;
using System.Collections;
using LitwareLib;

namespace CSharpAssigments
{
    public class EmployeeManagementApplication
    {
        public static void Main()
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Employee emp3 = new Employee();

            int id;
            string name;
            double salary;

            ArrayList mylist = new ArrayList();
            mylist.Add(emp1); mylist.Add(emp2); mylist.Add(emp3);
            foreach(Employee employee in mylist)
            { 
                Console.Write("Enter ID: ");
                id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Name: ");
                name = Console.ReadLine();
                Console.Write("Enter Salary: ");
                salary = Convert.ToDouble(Console.ReadLine());
                employee.GetEmployeeData(id,name,salary);
            }
            Console.WriteLine("Displaying employee details from Employee ArrayList - \n");
            foreach(Employee employee in mylist)
            {
                Console.WriteLine($"ID: {employee._Empno} \t Name: {employee._EmpName} \t Salary: {employee._Salary}");
            }
        }
    }
}
