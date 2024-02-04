using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    internal class Emp:Person
    {
        public int Salary { get; set; }
        public override string ToString()
        {
            return $"Emp Data:{Id}:{Name}:{Salary}";
        }
    }
}
