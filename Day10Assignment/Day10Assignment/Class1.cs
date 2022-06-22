using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Assignment
{
    internal class Class1
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;


        public static void computeEmpWage(String company, int empRatePerHr, int numberOfWorkingDays, int maxHoursPerMonth)
        {
            int empHrs = 0;
            int totalWorkingDays = 0;
            int totalEmpHours = 0;
            int totalEmpWage = 0;
            while (totalEmpHours <= maxHoursPerMonth && totalWorkingDays < numberOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                totalEmpHours += empHrs;

                totalEmpWage = totalEmpHours * empRatePerHr;
            }
            Console.WriteLine("total employee wage is of company" + company + "is " + totalEmpWage);
        }
    }
}