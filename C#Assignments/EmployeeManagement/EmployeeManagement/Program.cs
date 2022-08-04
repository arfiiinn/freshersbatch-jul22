using System;
using LitwareLib;

class Test
{
    public static void Main()
    {
        int EmpNo;
        string EmpName;
        double Salary;
        Console.WriteLine("Welcome to Employee Management System!");
        Console.Write("Enter Employee Number: ");
        EmpNo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Employee Name: ");
        EmpName = Console.ReadLine();
        Console.Write("Enter Salary: ");
        Salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Are you an/a 1. Employee\t 2. Manager\t 3. Marketing Executive \nEnter your choice in Number: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Employee employee = new Employee();
                employee.GetEmployeeData(EmpNo,EmpName,Salary);
                employee.CalculateGrossSalary();
                employee.CalculateSalary();
                employee.DisplayEmployee();
                break;
            case 2:
                Manager manager = new Manager();
                manager.GetEmployeeData(EmpNo, EmpName, Salary);
                manager.ManagerGrossSalary();
                manager.CalculateSalary();
                manager.DisplayEmployee();

                break;
            case 3:
                MarketingExecutive me = new MarketingExecutive();
                me.GetEmployeeData(EmpNo, EmpName, Salary);
                Console.WriteLine("Enter Kilometer Travel allowed");
                int km = Convert.ToInt32(Console.ReadLine());
                double TA = 5 * km;
                me.MEGrossSalary(TA);
                me.CalculateSalary();
                me.DisplayEmployee();
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
        

    }
}

