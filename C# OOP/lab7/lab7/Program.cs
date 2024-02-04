using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duration duration = new Duration(2,2,2);
            duration.Print();
            Console.ReadKey();
        }
    }
}
