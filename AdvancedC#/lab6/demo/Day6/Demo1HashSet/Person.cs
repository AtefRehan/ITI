using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1HashSet
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        
        public override bool Equals(object obj)
        {
            
            Console.WriteLine("equals");
            Person p = obj as Person;
            return p.Id==Id && Name==p.Name && Age==p.Age;
            //return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            Console.WriteLine("hashcode");
            
            return ToString().GetHashCode();
        }
        public override string ToString()
        {
            return $"{Id}:{Name}:{Age}";
        }
    }
}
