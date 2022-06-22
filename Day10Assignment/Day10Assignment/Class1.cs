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

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpwageArray;

        public Class1()
        {
            this.companyEmpwageArray = new CompanyEmpWage[5];


        }

        public void addCompanyEmpWage(string company, int empRatePerHr, int numberOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpwageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHr, numberOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }

        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpwageArray[i].setTotalEmpWage(this.computeEmpwage(this.companyEmpwageArray[i]));
                Console.WriteLine(this.companyEmpwageArray[i].toString());


            }
        }

        public int computeEmpwage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= companyEmpWage.MaxHoursPerMonth && totalWorkingDays < companyEmpWage.NoOfWorkingDays)
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

                totalEmpHrs += empHrs;
                Console.WriteLine("Days" + totalWorkingDays + "Emp hrs " + empHrs);
            }

            return totalEmpHrs * companyEmpWage.empRatePerHr;
        }
    }
}