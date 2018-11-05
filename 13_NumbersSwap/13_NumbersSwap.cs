using System;

class Program
{
    static void Main()
    {
        int a = 5;
        Console.WriteLine($"First number:{a}");
        int b = 10;
        Console.WriteLine($"Second number:{b}");

        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine($"First number:{a}");
        Console.WriteLine($"Second number:{b}");

    }
}

