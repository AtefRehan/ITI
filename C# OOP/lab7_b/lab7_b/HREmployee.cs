using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab7_b
{
    internal class HREmployee : Employee
    {
        public HREmployee(int id ,string name , int salary, Client[] clients )
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



        public static Client[] ConcatedClients(Client[] clients1, Client[] clients2)
        {
          
            for (int i = 0; i < clients1.Length; i++)
            {
                clients1[i].ID = clients1[i].ID + clients2[i].ID;
                clients1[i].Name = clients1[i].Name + clients2[i].Name;
                clients1[i].City = clients1[i].City + clients2[i].City;
            }
            Client[] result = clients1;
            
            return result;
        }

        public static HREmployee operator + (HREmployee left, HREmployee right)
        {
            if(left.Clients.Length == right.Clients.Length)
            {
                Client[] result = ConcatedClients(left.Clients, right.Clients);
                return new HREmployee (left.ID + right.ID, left.Name + right.Name, left.Salary + right.Salary, result);

            }
            else
            {
                Console.WriteLine("Arrays dimensions aren't equal");
                return null;

            }

        }
        public void Print(HREmployee emp)
        {
            Console.WriteLine($"ID is {emp.ID} name is : {emp.Name} salary is {emp.Salary} ");
            Client[] clints = emp.Clients; 
            for(int i=0 ;i<clints.Length ; i++)
            {
                Console.WriteLine($"Clients ID {clints[i].ID}  name is {clints[i].Name} city is {clints[i].City}");
            }
        }

        public static bool operator > (HREmployee first, HREmployee second)
        {
            return first.Salary > second.Salary;
        }
        public static bool operator < (HREmployee first, HREmployee second)
        {
            return !(first.Salary > second.Salary);
        }

        public static bool operator >=(HREmployee first, HREmployee second)
        {
            return first.Salary >= second.Salary;
        }
        public static bool operator <=(HREmployee first, HREmployee second)
        {
            return !(first.Salary >= second.Salary);
        }


       


    }
}
