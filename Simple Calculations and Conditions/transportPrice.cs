using System;

class MainClass
{
    static void Main()
    {
        //https://judge.softuni.bg/Contests/Practice/Index/169#1
        int kilometers = int.Parse(Console.ReadLine());
        string shift = Console.ReadLine();
        double minPrice = 0;
        if (kilometers < 20)
        {
            if (shift == "day")
            {
                minPrice = 0.7 + kilometers * 0.79;
            }
            else
            {
                minPrice = 0.7 + kilometers * 0.9;
            }
        }
        else if (kilometers < 100)
        {
            minPrice = kilometers * 0.09;
        }
        else
        {
            minPrice = kilometers * 0.06;
        }
        Console.WriteLine(minPrice);
    }
}

