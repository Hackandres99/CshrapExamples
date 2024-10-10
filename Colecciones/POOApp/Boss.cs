using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOApp
{
    internal class Boss : Workers, Vacation
    {
        public override int calcSalary(int workDays)
        {
            return workDays * 30;
        }

        public int calcVacation(int months)
        {
            int vacation = months;
            if(vacation == 12)
            {
                vacation = (vacation * 2) + 6;
            }
            else
            {
                vacation = vacation * 2;
            }
            return vacation;
        }
    }
}
