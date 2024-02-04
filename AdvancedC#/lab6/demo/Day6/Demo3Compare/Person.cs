using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3Compare
{
    internal class Person:IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(object obj)
        {
            Person person = obj as Person;
            return Id.CompareTo(person.Id);
        }

        public override string ToString()
        {
            return $"{Id}:{Name}:{Age}";
        }
    }
}
