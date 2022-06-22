using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Assignment
{
    public class CompanyEmpWage
    {
        public String company;
        public int empRatePerHr;
        public int NoOfWorkingDays;
        public int MaxHoursPerMonth;

        public int totalEmpWage;

        public CompanyEmpWage(String company, int empRatePerHr, int noOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.NoOfWorkingDays = noOfWorkingDays;
            this.MaxHoursPerMonth = maxHoursPerMonth;
        }

        public void setTotalEmpWage(int totalEmpwage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public String toString()
        {
            return "total emp wage for company: " + this.company + "is " + this.totalEmpWage;
        }

    }
}