namespace ConsoleApp1;

class Program
{
    public static void swap<t>(ref t x,ref t y)
    {
        t temp=x;
        x = y;
        y = temp;
        Console.WriteLine($"x value is {x} y value is {y}");

    }
    static void Main(string[] args)
    {

        // int x = 10;
        // int y = 20;
        // swap(ref x , ref y);

        StackGenerics<int> stack1 = new StackGenerics<int>(3);
        stack1.Push(1);
        stack1.Push(2);
        stack1.Push(2);

        Console.WriteLine(stack1.Pop());
        stack1.Pop();
        stack1.Pop();
        stack1.Pop();





    }
}