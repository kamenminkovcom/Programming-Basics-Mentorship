using System;


class Program
{
    static void Main(string[] args)
    {
        //https://judge.softuni.bg/Contests/Practice/Index/179#1
        int V = int.Parse(Console.ReadLine());
        int P1 = int.Parse(Console.ReadLine());
        int P2 = int.Parse(Console.ReadLine());
        double H = double.Parse(Console.ReadLine());
        double full = P1 * H + P2 * H;
        //Math.Truncate truncates the the digits after the decimal point e.g.: 14.9999 => 14
        if (full <= V)
        {
            Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                Math.Truncate(full / V * 100),
                Math.Truncate(P1 * H / full * 100),
                Math.Truncate(P2 * H / full * 100));

        }
        else
        {
            Console.WriteLine("For {0} hours the pool overflows with {1} liters.", H, full - V);
        }
    }
}
