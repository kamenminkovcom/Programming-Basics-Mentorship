using System;


class MainClass
{
    static void Main()
    {
        string figure = Console.ReadLine();
        double s = 0;
        if (figure == "square")
        {
            double a = double.Parse(Console.ReadLine());
            s = a*a;
        }
        else if (figure == "rectangle")
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            s = a*b;
        }
        else if (figure == "circle")
        {
            double r = double.Parse(Console.ReadLine());
            s = r*r*Math.PI;   
        }
        else
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            s = a*h/2;
            
        }
        Console.WriteLine(s);
    }
}

