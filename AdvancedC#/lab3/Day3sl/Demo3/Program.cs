namespace Demo3
{
    internal class Program
    {
        static void Main()
        {
            //== does not exist by default in struct
            //== exists in class , refrence
            // equals case struct value check
            //equals case class : refrence
            Complex c1=new Complex() { Real=1,Img=2};
            Complex c2 = new Complex() { Real = 1, Img = 2 };
            //c1 = c2;
            if(object.Equals(c1, c2))
                Console.WriteLine("equals: static");
            else
                Console.WriteLine("not equlas: static");
            /*if (object.ReferenceEquals(c1, c2))
                Console.WriteLine(" refrence equlas");
            else
                Console.WriteLine("refrence not equlas");
            */
            //c1 = c2;
            if (c1== c2)
            {
                Console.WriteLine("eqlals from ==");
            }
            else
                Console.WriteLine("not equls from == op");
            if (c1 .Equals( c2))
            {
                Console.WriteLine("equal");
            }
            else
                Console.WriteLine("not equal");



            //Emp e1=new Emp() { Id=1,Name="aly",Salary=1000};
            //Emp e2 = new Emp() { Id = 1, Name = "aly", Salary = 1000 };
            //e1 = e2;
            //if (e1 == e2)
            //{
            //    Console.WriteLine("equal");
            //}
            //else
            //    Console.WriteLine("Not Equal");

        }
        static void Main1(string[] args)
        {
            Person p1=new Person() { Id=10,Name="Aly"};
            Emp e1=new Emp() { Id=20,Name="sara",Salary=5000};
            Student s1=new Student() { Id=30,Name="ahmed",Grade='A'};
            //p1 = e1;
            //p1 = s1;
            Emp e2;
            if(p1 is Emp)
            {
                e2 = (Emp)p1;
                Console.WriteLine("p1 refrence to emp");
            }
            else
            {
                e2 = null;
                Console.WriteLine("p1 does not refrence to emp");

            }
            // e2 = (Emp)p1;
            //e2 = (Emp)p1;
            // e2= p1 as Emp;
            //e2=(Emp) p1;
            //if(e2!=null)

            // Console.WriteLine(e2?.ToString());

            // p1 = e1;//implicit cast
            //p1 = s1;//implicit cast


        }
    }
}
