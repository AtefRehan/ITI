using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_b
{
    internal class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public Client(int iD, string name, string city)
        {
            ID = iD;
            Name = name;
            City = city;
        }



        public void PrintClientDetails()
        {
            Console.WriteLine($"Client ID is {ID} ,Client Name is {Name} ,Client City is {City} ");
        }

        //public Client[] ConcatClients(Client[] left, Client[] right)
        //{
        //    Client[] result = new Client[] {};
        //    result=l
            
        //}
        //public static Client[] operator + ( Client left, Client right )
        //{
        //    //return new Client[] (left.ID+right.ID,left.Name+right.Name,left.City+right.City);
        //    return new Client[] {[left.ID+right.ID,left.Name+right.Name,left.City+right.City]};
        //}
    }
}
