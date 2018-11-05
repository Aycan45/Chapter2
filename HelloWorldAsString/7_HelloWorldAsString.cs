using System;

class HelloWorldAsString
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object helloWorld = hello + " " + world;
        Console.WriteLine($"{helloWorld}");
    }
}

