

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(int id , string name , int age)
        {
            Id = id;
            Name = name;
            Age = age;

        }
        
        public override bool Equals(object obj)
        {
            
            Console.WriteLine("equals");
            Person p = obj as Person;
            return p.Id==Id ;

        }
        public override int GetHashCode()
        {
            Console.WriteLine("hashcode");
            
            return Id.GetHashCode();
        }
        public override string ToString()
        {
            return $"{Id}:{Name}:{Age}";
        }
    }
}
