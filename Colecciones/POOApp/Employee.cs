using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace POOApp
{
    internal class Employee : Workers, Vacation
    {
        public override int calcSalary(int workDays)
        {
            return workDays * 15;
        }

        public int calcVacation(int months)
        {
            int vacation;
            vacation = months;
            if(vacation == 12)
            {
                vacation = months + 3;
            }
            return vacation;
        }
    }
}
