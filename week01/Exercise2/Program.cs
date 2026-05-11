using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade?: ");
        string grade = Console.ReadLine();
        int answer = int.Parse(grade);
        string letter ="";
        
        if (answer >= 90)
        {
            letter="A";
        }
        else if (answer >= 80)
        {
            letter="B";
        }
        else if (answer >= 70)
        {
            letter="C";
        }
        else if(answer >= 60)
        {
            letter ="D";
        }
        else
        {
            letter="F";
        }
        Console.WriteLine($"Your grade is: {answer}, you have an {letter}.");

        if (answer > 70)
        {
            Console.WriteLine("Well Done you passed.");
        }
        else
        {
            Console.WriteLine("Better luck the next time.");
        }

    }
}