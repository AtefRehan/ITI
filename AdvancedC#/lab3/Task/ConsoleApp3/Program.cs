namespace ConsoleApp3;

class Program
{
    static void Main(string[] args)
    {
        Complex c1 = new Complex()
        {
            real = 2, img = 3
        };
        Complex c2 = new Complex()
        {
            real =2 , img = 3
        };
        
        // c1 = c2;
;
        Console.WriteLine(c1.ToString());
        Console.WriteLine(c1.Equals(c2));
        
    }
}