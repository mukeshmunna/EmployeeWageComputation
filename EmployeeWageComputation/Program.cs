using EmployeeWageComputation;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Employee Wages");
        EmployeeAttendance employeeAttendance = new EmployeeAttendance();
        employeeAttendance.CalculateEmpWage();

    }
}
