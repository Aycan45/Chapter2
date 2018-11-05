using System;

class Program
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object obj = hello +""+ world;
        string str = (string)obj;
        Console.WriteLine($"{str}");
    }
}

