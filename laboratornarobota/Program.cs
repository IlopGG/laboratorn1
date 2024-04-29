using System;

public class FunctionCalculator
{
    public static double Calculate(double x)
    {
        return Math.Pow(x, 3) - 4  * Math.Pow(x, 2) - 5 * x + 9 + Math.Cos(x);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        double x;
        Console.WriteLine("Ведіть значення x:");

        
        while (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Неправильні дані. Введіть дійсні дані для x:");
        }

        double y = FunctionCalculator.Calculate(x);
        Console.WriteLine("For x = {0}, y = {1}", x, y);
    }
}