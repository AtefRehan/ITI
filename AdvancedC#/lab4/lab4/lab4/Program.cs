namespace lab4;

class Program
{
    static void Main(string[] args)
    {

        Even even = new Even();
        Odd odd = new Odd();
        Fib fib = new Fib();
        
        Consumer.PrintSeries(even);
        Consumer.PrintSeries(even);
        Consumer.PrintSeries(even);
        Consumer.PrintSeries(odd);
        Consumer.PrintSeries(odd);
        Consumer.PrintSeries(odd);
        Consumer.PrintSeries(fib);
        Consumer.PrintSeries(fib);
        Consumer.PrintSeries(fib);
        Consumer.PrintSeries(fib);
        Consumer.PrintSeries(fib);
        

    }
}