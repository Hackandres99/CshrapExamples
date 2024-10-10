using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workersApp
{
    internal abstract class Worker
    {
        private string name;
        private string dni;
        public abstract int calcSalary(int workDays);

        public  string Name { get; set; }
        public string Dni { get; set; }
    }
}
