using System;

class MainClass
{
    static void Main()
    {
        string hours = Console.ReadLine();
        string minutes = Console.ReadLine();
        string time = hours + ":" + minutes;
        var formatedTime = DateTime.ParseExact(time, "H:m", null).AddMinutes(15);
        Console.WriteLine(formatedTime.ToString("H:mm"));
    }
}

