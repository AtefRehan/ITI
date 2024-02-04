using System;

public static class ExtensionMethod
{
    public static double Add(this double a, double b) => a + b;
    public static double Subtract(this double a, double b) => a - b;
    public static double Multiply(this double a, double b) => a * b;
    public static double Divide(this double a, double b) => b != 0 ? a / b : double.NaN;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double sum = num1.Add(num2);
        double difference = num1.Subtract(num2);
        double product = num1.Multiply(num2);
        double division = num1.Divide(num2);

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {difference}");
        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Division: {division}");

        Console.ReadLine();
    }
}