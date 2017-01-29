using System;
using System.Globalization;

//https://judge.softuni.bg/Contests/Practice/Index/157#4
class MainClass
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        var datestring = "dd-MM";
        string date = string.Format("{0:00}-{1:00}", day, month);
        CultureInfo provider = CultureInfo.InvariantCulture;
        DateTime myDate = DateTime.ParseExact(date, datestring, provider);
        DateTime answer = myDate.AddDays(5);
        Console.WriteLine("{0:d.MM}", answer);
    }
}
