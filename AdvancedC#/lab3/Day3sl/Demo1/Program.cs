namespace Demo1
{
    internal class Program
    {
        static int Add(int x, int y)
        {
            Console.WriteLine("add with two param");
            return x + y;
        }
     
        //add(arg1,arg2)
        //add(arg1,arg2,arg3)
        //static int Add(int x, int y,int z=0)
        //{
        //    return x + y+z;
        //}
        //Add(10,20,30)
        //Add(10,20,30,40)
        //Add(10,20)
        //Add(10)
        //Add()
        static int Add(int x=0, int y =0 ,int z=0,int a=0)
        {
            Console.WriteLine("function with optional param");
            return x + y+z+a;
        }
        static int Mul(int x,int y)
        {
            Console.WriteLine($"{x}:{y}");
            return x * y;
        }
        static void Main(string[] args)
        {
            int x = default;
            //Console.WriteLine(x);

            int a = 10, b = 20;
            Console.WriteLine(Mul(x:a,y: b));
           
            Console.WriteLine(Add(a, b));
          //  Console.WriteLine(Add(50,60,10));


            Console.WriteLine("Hello, World!");
        }
    }
}
