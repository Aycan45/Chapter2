using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("You are male!");


        bool isMale = bool.Parse(Console.ReadLine());

        if (isMale == true)
        {
            Console.WriteLine("Yes, you are");
        }
        else if (isMale == false)
        {
            Console.WriteLine("Then you are a female!");
        }
    }
}

