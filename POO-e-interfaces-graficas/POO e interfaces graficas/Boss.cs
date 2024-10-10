using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_e_interfaces_graficas
{
    internal class Boss : Workers
    {
        public override int calcSalary(int workDays)
        {
            return workDays * 30;
        }
    }
}
