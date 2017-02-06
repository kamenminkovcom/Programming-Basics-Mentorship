using System;

class MainClass
{
    static void Main()
    {
        //https://judge.softuni.bg/Contests/Practice/Index/233#3
        double money = double.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        double neededMoney = 0;
        for (int i = 1800; i <= year; i++)
        {
            if (i%2==0)
            {
                neededMoney += 12000;
            }
            else
            {
                double moneyForOddYear = 12000 + 50 * (18 + i - 1800);
                neededMoney = neededMoney + moneyForOddYear; 
            }
        }

        if (neededMoney <= money)
        {
            Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", Math.Abs(money - neededMoney));
        }
        else
        {
            Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(money - neededMoney));
        }
    }
}

