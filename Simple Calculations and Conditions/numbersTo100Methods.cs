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
        if (teen == 11) return "eleven";
        if (teen == 12) return "twelve";
        if (teen == 13) return "thirteen";
        if (teen == 14) return "fourteen";
        if (teen == 15) return "fifteen";
        if (teen == 16) return "sixteen";
        if (teen == 17) return "seventeen";
        if (teen == 18) return "eighteen";
        return "nineteen";
    }

    static string ReturnDecimal(int decimals)
    {
        if (decimals == 2) return "twenty";
        if (decimals == 3) return "thirty";
        if (decimals == 4) return "forty";
        if (decimals == 5) return "fifty";
        if (decimals == 6) return "sixty";
        if (decimals == 7) return "seventy";
        if (decimals == 8) return "eighty";
        if (decimals == 9) return "ninety";
        return null;
    }
    static string ReturnNumbers(int number)
    {
        if (number == 1) return "one";
        if (number == 2) return "two";
        if (number == 3) return "three";
        if (number == 4) return "four";
        if (number == 5) return "five";
        if (number == 6) return "six";
        if (number == 7) return "seven";
        if (number == 8) return "eight";
        if (number == 9) return "nine";
        return null;
    }
}
