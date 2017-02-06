using System;

class MianClass
{
    static void Main()
    {
        //https://judge.softuni.bg/Contests/Practice/Index/179#1
        int V = int.Parse(Console.ReadLine());
        int pipe1 = int.Parse(Console.ReadLine());
        int pipe2 = int.Parse(Console.ReadLine());
        double hours = double.Parse(Console.ReadLine());
        double totalWater = (pipe1 + pipe2) * hours;
        //Math.Truncate truncates the the digits after the decimal point e.g.: 14.9999 => 14
        if (V>=totalWater)
        {
            double pipe1Percent = pipe1 * hours / totalWater * 100;
            double pipe2Percent = pipe2 * hours / totalWater * 100;
            Console.WriteLine($"The pool is {Math.Truncate((totalWater / V) * 100)}% full. Pipe 1: {Math.Truncate(pipe1Percent)}%. Pipe 2: {Math.Truncate(pipe2Percent)}%.");
        }
        else
        {
            Console.WriteLine($"For {hours} hours the pool overflows with {Math.Abs(V - totalWater)} liters.");
        }
    }
}

