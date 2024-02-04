using System.Collections;

namespace Demo3Compare
{
    class personCompare : IComparer
    {
        public int Compare(object x, object y)
        {
            Person p1 = x as Person;
            Person p2 = y as Person;
            return p1.Name.CompareTo(p2.Name);
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string s1 = "aly", s2 = "lya";
            
            Person[] arr = [
                new Person() { Id = 1 ,Name="Aly",Age=30},
                new Person() { Id = 5, Name = "sara", Age = 10 },
                new Person() { Id = 3, Name = "mohamed", Age = 15 },
                new Person() { Id = 0, Name = "zeyad", Age = 15 },


            ];
            personCompare comp1 = new personCompare();
           // comp1.Compare(arr[0], arr[1]);

            Array.Sort(arr,comp1);

            foreach (Person p in arr)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("Hello, World!");
        }
    }
}
