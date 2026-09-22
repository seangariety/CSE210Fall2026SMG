using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your percentage grade? ");
        string userinput = Console.ReadLine();
        int number = int.Parse(userinput);
        string grade;
        

        if (number >= 90) grade = "A";
        else if (number >= 80) grade = "B";
        else if (number >= 70) grade = "C";
        else if (number >= 60) grade = "D";
        else if (number < 60) grade = "F";
        else
        {
            Console.WriteLine("How did we even get here?");
            grade = "...Umm... something broke.";
        }



        Console.WriteLine($"Your letter grade is {grade}");
        
    }
}