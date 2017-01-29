using System;
using System.Globalization;

class MainClass
{
    static void Main(string[] args)
    {
        var t = Console.ReadLine();
        var datestring = "dd-MM-yyyy";
       // CultureInfo provider = CultureInfo.InvariantCulture;
       // You can write provider instead of null in the ParseExact method
        DateTime BirthDay = DateTime.ParseExact(t, datestring, null);
        DateTime answer = BirthDay.AddDays(999);
        Console.WriteLine("{0:dd-MM-yyyy}", answer);
    }
}
