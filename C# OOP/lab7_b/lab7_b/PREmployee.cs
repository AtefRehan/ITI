using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_b
{
    internal class PREmployee : Employee
    {

        public PREmployee(int id, string name, int salary, Client[] clients)
        {
            ID = id;
            Name = name;
            Salary = salary;
            Clients = clients;
        }

        public override void ShowEmployeeDetails(Client[] clients)
        {
            for (int i = 0; i < clients.Length; i++)
            {
                clients[i].PrintClientDetails();
            }
        }
    }
}
