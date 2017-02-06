using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers0_100ToText
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int firstNumber = number / 10;
            int secondNumber = number % 10;

            if (number<10)
            {
                switch(secondNumber)
                {
                    case 0:
                        Console.WriteLine("Zero");
                        break;
                    case 1:
                        Console.WriteLine("One");
                        break;
                    case 2:
                        Console.WriteLine("Two");
                        break;
                    case 3:
                        Console.WriteLine("Three");
                        break;
                    case 4:
                        Console.WriteLine("Four");
                        break;
                    case 5:
                        Console.WriteLine("Five");
                        break;
                    case 6:
                        Console.WriteLine("Six");
                        break;
                    case 7:
                        Console.WriteLine("Seven");
                        break;
                    case 8:
                        Console.WriteLine("Eight");
                        break;
                    case 9:
                        Console.WriteLine("Nine");
                        break;
                }
            }
            else if (number<20)
            {
                switch (number)
                {
                    case 10:
                        Console.WriteLine("Ten");
                        break;
                    case 11:
                        Console.WriteLine("Eleven");
                        break;
                    case 12:
                        Console.WriteLine("Twelve");
                        break;
                    case 13:
                        Console.WriteLine("Thirteen");
                        break;
                    case 14:
                        Console.WriteLine("Fourteen");
                        break;
                    case 15:
                        Console.WriteLine("Fifteen");
                        break;
                    case 16:
                        Console.WriteLine("Sixteen");
                        break;
                    case 17:
                        Console.WriteLine("Seventeen");
                        break;
                    case 18:
                        Console.WriteLine("Eighteen");
                        break;
                    case 19:
                        Console.WriteLine("Nineteen");
                        break;
                }
            }
            else if (number >= 20)
            {
                switch (firstNumber)
                {
                    case 2:
                        Console.Write("Twenty");
                        break;
                    case 3:
                        Console.Write("Thirty");
                        break;
                    case 4:
                        Console.Write("Fourty");
                        break;
                    case 5:
                        Console.Write("Fifty");
                        break;
                    case 6:
                        Console.Write("Sixty");
                        break;
                    case 7:
                        Console.Write("Seventy");
                        break;
                    case 8:
                        Console.Write("Eighty");
                        break;
                    case 9:
                        Console.Write("Ninety");
                        break;
                }
                switch (secondNumber)
                {

                    case 1:
                        Console.WriteLine(" One");
                        break;
                    case 2:
                        Console.WriteLine(" Two");
                        break;
                    case 3:
                        Console.WriteLine(" Three");
                        break;
                    case 4:
                        Console.WriteLine(" Four");
                        break;
                    case 5:
                        Console.WriteLine(" Five");
                        break;
                    case 6:
                        Console.WriteLine(" Six");
                        break;
                    case 7:
                        Console.WriteLine(" Seven");
                        break;
                    case 8:
                        Console.WriteLine(" Eight");
                        break;
                    case 9:
                        Console.WriteLine(" Nine");
                        break;
                }
            }
            else
            {
                Console.WriteLine("one hundred");
            }
        }

    }
}

    

