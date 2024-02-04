namespace Demo3DelegateV1
{
    //class struct enum interface delegate
    //1 - define new datatype of delegate type
    delegate int MathDel(int x, int y);
    delegate float MathDel2(float x, float y);
    delegate t3 Mathdelg<t1,t2,t3>(t1 x, t2 t1);
    delegate t4 Mathdelg3<t1, t2, t3,t4>(t1 x, t2 y,t3 z);


    delegate void FunDel(int x);
    internal class Program
    {
        static bool fun4(int x)
        {
            return x > 10;
        }
        static void Main()
        {
            Predicate<int> d6 = fun4;
            Console.WriteLine(d6.Invoke(5));
            Func<int, int, int> d1 = Add;

            Func<float, float, float> d2 = Add2;
            Func<int, int, int, int> d3 = Add4;
            Func<float,float,float> d4 = Add2;
            Action<int> d5 = fun1;
        }
        static int Add4(int x,int y,int z)
        {
            return x + y + z;
        }
        static void fun1(int x)
        {
            Console.WriteLine($"{x} hello from fun1");
        }
        static void fun2(int x)
        {
            Console.WriteLine($"{x} hello from fun2");
        }
        static void fun3(int x)
        {
            Console.WriteLine($"{x} hello from fun3");
        }
        static int Add(int a, int b)
        {
            int z= a + b;
            return z;
        }
        static float Add2(float a, float b)
        {
            float z = a + b;
            return z;
        }
        static int Subtract(int a, int b)
        {
            int z = a - b;
            return z;
        }
        static int Mul(int a, int b)
        {
            return a*b;
        }
        static void Main3()
        {
            MathDel d1 = Add;
           MathDel2 d2 = Add2;
        }
        static void Main2()
        {
          
           // FunDel d2 = new FunDel(fun1);
            FunDel d2 = fun1;
            d2 += fun2;
            d2 += fun3;
            d2 -= fun3;

            d2.Invoke(50);

        }
        static void Main1(string[] args)
        {
            //2-define refrence of type mathdel
            //3-initilization , point to function add
            //MathDel d1=new MathDel(Add);
            MathDel d1 = Add;
            d1 = Subtract;
            d1 = Mul;
            d1 = null;
            //4- call function whose address in d1
           // Console.WriteLine(d1(10,20));
            Console.WriteLine(d1?.Invoke(10,20));
            Console.WriteLine("Hello, World!");
        }
    }
}
