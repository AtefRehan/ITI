using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_b
{
    internal class Program
    {

        public static Employee GetEmployeeWithLongestClientsArray(Employee[] employees)
        {
            Employee employeeWithLongestClientsArray = null;
            int maxClientCount = -1;

            for (int i = 0; i < employees.Length; i++)
            {
                Employee employee = employees[i];

                if (employee.Clients.Length > maxClientCount)
                {
                    maxClientCount = employee.Clients.Length;
                    employeeWithLongestClientsArray = employee;
                }
            }

            return employeeWithLongestClientsArray;
        }
        public static void PrintEmployee(Employee emp)
        {
            Console.WriteLine(emp.ID + " " + emp.Name);
        }


        
        static void Main(string[] args)
        {

            Client client1 = new Client(100,"Omar","Alex");
            Client client2 = new Client(200,"ahmed","PortSaid");
            Client client3= new Client(300,"saad","Cairo");
            Client client4 = new Client(400,"Ali","Mansora");
            Client client5 = new Client(500,"Maged","Cairo");
            Client client6 = new Client(700,"Sayed","Cairo");
            Client client7 = new Client(800,"Amr","Fayoum");

            Client[] pRClients = { client1, client2, client3,client1};
            Client[] hRClients = { client4, client5, client6,client7 };
            

            HREmployee hREmployee1 = new HREmployee(1, "Atef", 10000,pRClients);
            HREmployee hREmployee2 = new HREmployee(2,"Ahmed",20000,hRClients);
            HREmployee hREmployee3 = new HREmployee(3,"Mohamed",30000, hRClients);

            PREmployee pREmployee1 = new PREmployee(10,"Sara",5000, pRClients);
            PREmployee pREmployee2 = new PREmployee(20,"Noha",8000, pRClients);

            Employee[] emps = new Employee[] {hREmployee1,hREmployee2,hREmployee3,pREmployee1,pREmployee2 };

            HREmployee hrThree = hREmployee1 + hREmployee2;
            hrThree.Print(hrThree);
            PrintEmployee(GetEmployeeWithLongestClientsArray(emps));
            Console.ReadKey();
        }
    }
}
