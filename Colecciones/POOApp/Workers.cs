using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOApp
{
    internal abstract class Workers
    {
        private string name;
        private string dni;
        public abstract int calcSalary(int workDays);

        public string Name { get; set; }
        public string Dni { get; set; }
    }
}
