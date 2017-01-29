using System;


//https://judge.softuni.bg/Contests/Practice/Index/354#1
class MainClass 
{
    static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        int kilos = int.Parse(Console.ReadLine());
        double dog = double.Parse(Console.ReadLine());
        double cat = double.Parse(Console.ReadLine());
        double turtle = double.Parse(Console.ReadLine()) / 1000;
        double neededFood = (dog + cat + turtle) * days;

        if (neededFood <= kilos)
        {
            Console.WriteLine("{0} kilos of food left.", Math.Floor(Math.Abs(kilos - neededFood)));
        }
        else
        {
            Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(Math.Abs(-kilos + neededFood)));
        }
    }
}