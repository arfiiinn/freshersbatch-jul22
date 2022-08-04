using System;
using LitwareLib;

class Program
{
    public static void Main()
    {
        int empid;
        string empname;
        double salary;
        Console.WriteLine("Welcome to Litware Organization");
        Console.Write("Enter your Employee ID: ");
        empid = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your Name: ");
        empname = Console.ReadLine();
        Console.Write("Enter your Salary: ");
        salary = Convert.ToDouble(Console.ReadLine());
        Employee employee = new Employee();
        employee.GetEmployeeData(empid, empname, salary);
        employee.CalculateSalary();
    }
}
