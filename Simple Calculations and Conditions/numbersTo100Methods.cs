using System;

class MainClass
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int firstNumber = num / 10;
        int secondNumber = num % 10;
        if (num < 0 || num > 100)
        {
            Console.WriteLine("invalid number");
        }
        else if (num == 0)
        {
            Console.WriteLine("zero");
        }
        else if (num < 10 && num >= 1)
        {
            Console.WriteLine(ReturnNumbers(num));
        }
        else if (num >= 10 && num < 20)
        {
            Console.WriteLine(ReturnTeen(num));
        }
        else if (num >= 20 && num < 100)
        {
            if (num % 10 == 0)
            {
                Console.WriteLine(ReturnDecimal(firstNumber));
            }
            else
            {
                Console.WriteLine("{0} {1}", ReturnDecimal(firstNumber), ReturnNumbers(secondNumber));
            }
        }
        else if (num == 100)
        {
            Console.WriteLine("One hundred");
        }


    }

    static string ReturnTeen(int teen)
    {
        if (teen == 10) return "ten";
        else if (teen == 11) return "eleven";
        else if (teen == 12) return "twelve";
        else if (teen == 13) return "thirteen";
        else if (teen == 14) return "fourteen";
        else if (teen == 15) return "fifteen";
        else if (teen == 16) return "sixteen";
        else if (teen == 17) return "seventeen";
        else if (teen == 18) return "eighteen";
        else return "nineteen";
    }

    static string ReturnDecimal(int decimals)
    {
        if (decimals == 2) return "twenty";
        else if (decimals == 3) return "thirty";
        else if (decimals == 4) return "forty";
        else if (decimals == 5) return "fifty";
        else if (decimals == 6) return "sixty";
        else if (decimals == 7) return "seventy";
        else if (decimals == 8) return "eighty";
        else if (decimals == 9) return "ninety";
        else return null;
    }
    static string ReturnNumbers(int number)
    {
        if (number == 1) return "one";
        else if (number == 2) return "two";
        else if (number == 3) return "three";
        else if (number == 4) return "four";
        else if (number == 5) return "five";
        else if (number == 6) return "six";
        else if (number == 7) return "seven";
        else if (number == 8) return "eight";
        else if (number == 9) return "nine";
        else return null;
    }

}
