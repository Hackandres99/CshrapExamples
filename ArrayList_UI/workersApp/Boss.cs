using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workersApp
{
    internal class Boss : Worker,  Vacation
    {
        public override int calcSalary(int workDays)
        {
            return workDays * 30;
        }

        public int calcVacations(int months)
        {
            return months * 2;
        }
    }
}
