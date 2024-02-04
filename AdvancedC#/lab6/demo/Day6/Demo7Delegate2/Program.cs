using System.Threading.Channels;

namespace Demo7Delegate2
{
    internal class Program
    {
        static void fun1()
        {
            Console.WriteLine("fun1");
        }
        static void Main(string[] args)

        {
            Action a3 =  ()=> Console.WriteLine("hello");
            a3?.Invoke();
            
            /*Action<int> a1 =   delegate (int x)
            {
                Console.WriteLine($"{x}-fun1");
            };*/
            Action<int> a1 =  x=> Console.WriteLine($"{x}-fun1");
            
            /*Func<int,int, int> a2 = delegate (int x, int y)
            {
                return x + y;
            };*/
            Func<int, int, int> a2 =  (x,  y )=>  x + y;
            
            Console.WriteLine( a2.Invoke(20, 30));
            a1.Invoke(10);
            a1.Invoke(20);
            Console.WriteLine("Hello, World!");
        }
    }
}
