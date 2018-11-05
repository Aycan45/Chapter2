using System;

class ComparingTwoNumbers
{
    static void Main()
    {
        Console.Write("a=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b=");
        double b = double.Parse(Console.ReadLine());
           

        bool result = Math.Abs(a - b) < 0.000001;
        Console.WriteLine($"{result}");
    }
}

