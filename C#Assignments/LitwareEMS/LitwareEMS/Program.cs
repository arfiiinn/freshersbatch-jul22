using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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
        // Serializing Employee object.
        FileStream f = new FileStream(@"C:\Users\arfin\Desktop\FileIO\EmployeeDetails.txt", FileMode.Open, FileAccess.Write);
        BinaryFormatter b = new BinaryFormatter();
        b.Serialize(f, employee);
        f.Close();

        //Deserializing Employee object.
        FileStream fr = new FileStream(@"C:\Users\arfin\Desktop\FileIO\EmployeeDetails.txt", FileMode.Open, FileAccess.Read);
        BinaryFormatter br = new BinaryFormatter();
        br.Deserialize(fr);
        fr.Close();

    }
}
