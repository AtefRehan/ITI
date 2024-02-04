using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    internal class Student:Person
    {
        public char Grade { get; set; }
        public override string ToString()
        {
            return $"Student Data- {Id}:{Name}:{Grade}";
        }
    }
}
