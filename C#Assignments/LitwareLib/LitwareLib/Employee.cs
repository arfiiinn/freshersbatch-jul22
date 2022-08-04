using System;

namespace LitwareLib
{
    interface IPrintable
    {
         void DisplayEmployee();
    }
    public class Employee : IPrintable
    {
        // Defining data members
        private int Empno;
        private string EmpName;
        private double Salary,HRA, TA, DA, PF, TDS, NetSalary, GrossSalary;

        //Accessing private members using properties
        public double _Salary
        {
            get
            {
                return Salary;
            }
        }

        public double _GrossSalary
        {
            get
            {
                return GrossSalary;
            }
        }
        public double _PF
        {
            get
            {
                return PF;
            }
        }

        public double _TDS
        {
            get
            {
                return TDS;
            }
        }

        // Constructor initializes variables to zero.
        public Employee()
        {
            Empno = 0; Salary = 0; HRA = 0; TA = 0; DA = 0;
            EmpName = "Employee Name";
        }

        public void DisplayEmployee()
        {
            Console.WriteLine("Using IPrintable to display Employee Details:");
            Console.WriteLine($"ID: {Empno}\t Name: {EmpName} \tSalary: {Salary}");
            Console.WriteLine($"Allowances: \nHouse Rent Alowance:{HRA}, Travel Allowance: {TA}, Dearness Allowance: {DA}");
            Console.WriteLine($"GrossSalary: {GrossSalary}");
            Console.WriteLine($"Provident Fund: {PF}, TDS: {TDS}");
            Console.WriteLine($"Net Salary: {NetSalary}");
        }
        // Getting information about Employee
        public void GetEmployeeData(int Empno, string EmpName, double Salary)
        {
            this.Empno = Empno;
            this.EmpName = EmpName;
            this.Salary = Salary;
            Console.WriteLine($"Employee Details:\nID: {this.Empno}\tName: {this.EmpName}\n");

        }

        // Calculating GrossSalary
        public void CalculateGrossSalary()
        {

            // Calculating various HRA, TA, DA.
            if (this.Salary < 5000)
            {
                HRA = (10 * this.Salary) / 100;
                TA = (5 * this.Salary) / 100;
                DA = (15 * this.Salary) / 100;
                GrossSalary = Salary + HRA + TA + DA;
                Console.Write($"Gross Salary: {GrossSalary}");
                
            }
            else if (this.Salary < 10000)
            {
                HRA = (15 * this.Salary) / 100;
                TA = (10 * this.Salary) / 100;
                DA = (20 * this.Salary) / 100;
                GrossSalary = Salary + HRA + TA + DA;
                Console.Write($"Gross Salary: {GrossSalary}");
            }
            else if (this.Salary < 15000)
            {
                HRA = (20 * this.Salary) / 100;
                TA = (15 * this.Salary) / 100;
                DA = (25 * this.Salary) / 100;
                GrossSalary = Salary + HRA + TA + DA;
                Console.Write($"Gross Salary: {GrossSalary}");
            }
            else if (this.Salary < 20000)
            {
                HRA = (25 * this.Salary) / 100;
                TA = (20 * this.Salary) / 100;
                DA = (30 * this.Salary) / 100;
                GrossSalary = Salary + HRA + TA + DA;
                Console.Write($"Gross Salary: {GrossSalary}");
            }
            else if (this.Salary >= 20000)
            {
                HRA = (30 * this.Salary) / 100;
                TA = (25 * this.Salary) / 100;
                DA = (35 * this.Salary) / 100;
                GrossSalary = Salary + HRA + TA + DA;
                Console.Write($"Gross Salary: {GrossSalary}");
            }

        }

        //Calculating NetSalary
        public virtual void CalculateSalary()
        {
            PF = (10 * GrossSalary) / 100;
            TDS = (18 * GrossSalary) / 100;
            NetSalary = GrossSalary - (PF + TDS);
            // Console.WriteLine($"\nPF: {PF} \t TDS: {TDS}");
            Console.WriteLine($"\nNet Salary: {NetSalary}");
        }

    }

    public class Manager : Employee
    {
        private double PetrolAllowance, FoodAllowance, OtherAllowances;
        public double newGrossSalary;

        
        public void ManagerGrossSalary()
        {
            CalculateGrossSalary();
            PetrolAllowance = (8 * _Salary) / 100;
            FoodAllowance = (13 * _Salary) / 100;
            OtherAllowances = (3 * _Salary) / 100;
            newGrossSalary = _GrossSalary + (PetrolAllowance + FoodAllowance + OtherAllowances);
            Console.WriteLine($"\nGross Salary of Manager: {newGrossSalary}");
        }

        public override void CalculateSalary()
        {
            double newPF = _PF;
            double newTDS = _TDS;
            double newNetSalary;
            newPF = (10 * _GrossSalary) / 100;
            newTDS = (18 * newGrossSalary) / 100;
            newNetSalary = newGrossSalary - (newPF + newTDS);
            // Console.WriteLine($"\nPF: {PF} \t TDS: {TDS}");
            Console.WriteLine($"\nNet Salary: {newNetSalary}");
        }
    }

    public class MarketingExecutive : Employee
    {
        private double KilometerTravel = 0;
        private double TourAllowance;

        public double _TA
        {
            get
            {
                return TourAllowance;
            }
        }
       
        
        private double TelephoneAllowance = 1000;
        public double newGrossSalary;

        public void MEGrossSalary(double TourAllowance)
        {
            CalculateGrossSalary();
            double newGrossSalary = TourAllowance + TelephoneAllowance + _GrossSalary;
            Console.WriteLine($"\nGross Salary of Marketing Executive: {newGrossSalary}");
        }

        public override void CalculateSalary()
        {
            double newPF = _PF;
            double newTDS = _TDS;
            double newNetSalary;
            newPF = (10 * _GrossSalary) / 100;
            newTDS = (18 * newGrossSalary) / 100;
            newNetSalary = newGrossSalary - (newPF + newTDS);
            // Console.WriteLine($"\nPF: {PF} \t TDS: {TDS}");
            Console.WriteLine($"\nNet Salary: {newNetSalary}");
        }
    }

}
