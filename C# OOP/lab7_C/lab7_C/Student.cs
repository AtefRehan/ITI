using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_C
{
    internal class Student
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string UserPassword { get; set; }
        public string Email { get; set; }

        public void Print()
        {
            Console.WriteLine($"Student ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Username: {Username}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
