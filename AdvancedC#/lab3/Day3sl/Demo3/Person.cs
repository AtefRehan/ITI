using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override bool Equals(object obj)
        {
            if(obj == null) return false;
            if(obj.GetType() != this.GetType())
                return false;
            Person other = (Person)obj;
            if(Id==other.Id && Name==other.Name) 
                return true;
            else 
                return false;
        }
        public  override string ToString()
        {
            return base.ToString();
        }

    }
}
