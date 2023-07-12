using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeAttendance
    {
        const int WAGE_PER_HR =20, FULL_DAY_HR = 8, PART_DAY_HR=4, IS_FULL_TIME =0,IS_PART_TIME=1;
        int totalEmpWage = 0, empHrs = 0;
        Random random = new Random(); 
        public void Employeewage() 
        {   
            int empCheck  = random.Next(0,2);
            if (empCheck == 0)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is Absent");

        }
        public void CalculationEmpWage()
        {
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = FULL_DAY_HR;
            }
            if(empCheck == IS_PART_TIME)
            {
                empCheck = PART_DAY_HR;
            }
            totalEmpWage = WAGE_PER_HR * empHrs;
            Console.WriteLine("total emp wages"+totalEmpWage);
        }
    }
}
