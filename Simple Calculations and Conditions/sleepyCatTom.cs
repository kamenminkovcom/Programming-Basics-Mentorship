using System;

class MainClass
{
    static void Main()
    {
        //https://judge.softuni.bg/Contests/Practice/Index/181#1
        int daysOff = int.Parse(Console.ReadLine());
        int norm = 30000;
        int playingInWorkingDays = (365 - daysOff) * 63;
        int playingDaysOff = daysOff * 127;
        int totalPlaying = playingDaysOff + playingInWorkingDays;

        if (totalPlaying > norm)
        {
            int diff = Math.Abs(norm - totalPlaying);
            Console.WriteLine("Tom will run away");
            Console.WriteLine("{0} hours and {1} minutes more for play", diff/60, diff%60);
        }
        else
        {
            int diff = Math.Abs(norm - totalPlaying);
            Console.WriteLine("Tom sleeps well");
            Console.WriteLine("{0} hours and {1} minutes less for play", diff / 60, diff % 60);
        }

    }
}

