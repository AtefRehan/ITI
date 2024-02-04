namespace Demo1HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5.GetHashCode());
            Dictionary<Person,int> dic= new Dictionary<Person,int>();
            dic.Add(new Person() { Id=10,Name="aly",Age=30}, 1);
            dic.Add(new Person() { Id = 2, Name = "aly", Age = 30 }, 1);
            dic.Add(new Person() { Id = 3, Name = "aly", Age = 30 }, 1);
            //dic.Add(new Person() { Id = 10, Name = "aly", Age = 30 }, 1);

            foreach (var p in dic)
            {
                Console.WriteLine(p.Key);
            }
            Console.WriteLine("*********");
            HashSet<Person> persons = new HashSet<Person>();
            Person p1=new Person() { Id=1000,Name="yasser",Age=23};
            /*Person p2 = new Person() { Id = 1000, Name = "yasser", Age = 23 };
            Console.WriteLine(p1.GetHashCode());
           
            Console.WriteLine(p2.GetHashCode());*/

            persons.Add(p1);
            Console.WriteLine("=============");
            persons.Add(new Person() { Id=1,Name="aly",Age=30});
            Console.WriteLine("=============");

            persons.Add(new Person() { Id = 2, Name = "mohamed", Age = 20 });
            Console.WriteLine("=============");

            persons.Add(new Person() { Id = 3, Name = "islam", Age = 15 });
            Console.WriteLine("=============");

            persons.Add(new Person() { Id = 3, Name = "islam", Age = 15 });
            Console.WriteLine("=============");

           // persons.Add(p1 );
            //Console.WriteLine("=============");


            foreach (var item in persons)
            {
                Console.WriteLine(item);
            }


            HashSet<int> lst= new HashSet<int>();
            lst.Add(30);
            lst.Add(40);
            lst.Add(50);
            lst.Add(40);
            foreach (int i in lst)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(lst.Count);

            Console.WriteLine("Hello, World!");
        }
    }
}
