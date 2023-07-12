using System;
    
namespace EmployeeWageComputation 
{ 

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Employee Wage Computation");
            EmployeeAttendance wage = new EmployeeAttendance();
            wage.CalculationEmpWage();
        }

    }
}
