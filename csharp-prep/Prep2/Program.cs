using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your percentage grade? ");
        string userinput = Console.ReadLine();
        int number = int.Parse(userinput);

        Console.WriteLine($"Your grade is {number}");
        
    }
}