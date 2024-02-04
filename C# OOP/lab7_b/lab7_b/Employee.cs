using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_b
{
    internal abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Salary { get; set; }

        public Client[] Clients { get; set; }


        public abstract void ShowEmployeeDetails(Client[] clients);
            
    }
}
