namespace lab4;

public class Consumer 
{
    public static void PrintSeries(ISeries series)
    {


        Console.WriteLine($"Printing {series.GetType().Name} Series:");
        Console.WriteLine(series.Update());

       
    }
    
}