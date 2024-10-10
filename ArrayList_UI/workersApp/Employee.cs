using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workersApp
{
    internal class Employee : Worker, Vacation
    {
        public override int calcSalary(int workDays)
        {
            return workDays * 15;
        }

        public int calcVacations(int months)
        {
            int vacations;

            vacations = months;

            if (vacations == 12)
            {
                vacations = vacations + 3;
            }

            return vacations;
        }
    }
}
