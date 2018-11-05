using System;

class Program
{
    static void Main()
    {
        Console.Write("Name:");
        string name = Console.ReadLine();
        Console.Write("Surname:");
        string surname = Console.ReadLine();
        Console.Write("Age:");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Sex:");
        char symbolOne ='m';
        char symbolTwo ='f';
            
        Console.WriteLine($"{symbolOne}");
        Console.WriteLine($"{symbolTwo}");

        Console.Write("Number of worker:");
        int uniqueNumber = int.Parse(Console.ReadLine());
        if (uniqueNumber <= 27569999 && uniqueNumber >= 27560000)
        {
            Console.WriteLine("He is our worker");
        }
        else
        {
            Console.WriteLine("He is not out worker");
        }   
    }
}

