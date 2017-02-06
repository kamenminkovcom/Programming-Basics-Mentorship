using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double p1 = 0;
        double p2 = 0;
        double p3 = 0;
        int index = 1;
        while(index<=n)
        {
            int number = int.Parse(Console.ReadLine());

            if (number%2==0)
            {
                p1++;
            }

            if (number % 3 == 0)
            {
                p2++;
            }
            if (number % 4 == 0)
            {
                p3++;
            }
            index++;
        }

        Console.WriteLine("{0:f2}%", p1 / n * 100);
        Console.WriteLine("{0:f2}%", p2 / n * 100);
        Console.WriteLine("{0:f2}%", p3 / n * 100);
    }
}

