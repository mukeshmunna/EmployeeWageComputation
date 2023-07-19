﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeAttendance

    {
        const int WAGE_PER_HR = 20, FULL_DAY_HR = 8, PART_DAY_HR = 4, IS_FULL_TIME = 0, IS_PART_TIME = 1, TOTAL_WORKING_HRS = 100, TOTAL_WORKING_DAYS = 20;
        int totalEmpWage = 0, empHrs = 0;
        Random random = new Random();
        public void EmpAttendance()
        {

            int empCheck = random.Next(0, 2);
            if (empCheck == 0)
                Console.WriteLine("Employee Is Present");
            else
                Console.WriteLine("Employee Is Absent");
        }
        public void CalculateEmpWage()
        {

            for (int day = 0; day < TOTAL_WORKING_DAYS && empHrs < TOTAL_WORKING_HRS; day++)
            {
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs += FULL_DAY_HR;
                        break;

                    case IS_PART_TIME:
                        empHrs += PART_DAY_HR;
                        break;
                    default:
                        empHrs += 0;
                        break;


                }
            }

            int totalEmpWage = empHrs * WAGE_PER_HR;
            Console.WriteLine(totalEmpWage);

        }
    }
}