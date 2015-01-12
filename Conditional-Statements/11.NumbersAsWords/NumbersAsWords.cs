using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NumbersAsWords
{
    static void Main(string[] args)
    {
        string[] Ones =
        {
            "zero",
            "one",
            "two",
            "three",
            "four",
            "five",
            "six",
            "seven",
            "eight",
            "nine"
        };

        string[] Teens =
        {
            "ten",
            "eleven",
            "twelve",
            "thirteen",
            "fourteen",
            "fifteen",
            "sixteen",
            "seventeen",
            "eighteen",
            "nineteen"
        };

        string[] Tens =
        {
            "",
            "ten",
            "twenty",
            "thirty",
            "forty",
            "fifty",
            "sixty",
            "seventy",
            "eighty",
            "ninety"
        };

        for (int i = 0; i < 50; i++)
        {


            string NumberStr = Console.ReadLine();
            int Number = Convert.ToInt16(NumberStr);

            switch (NumberStr.Length)
            {
                case 1: Console.WriteLine(Ones[Number]); break;
                case 2:
                    if (Number < 20)
                    {
                        Console.WriteLine(Teens[Number - 10]);
                    }
                    else if (Number % 10 == 0)
                    {
                        Console.WriteLine("{0}", Tens[Number / 10]);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1}", Tens[Number / 10], Ones[Number % 10]);
                    }
                    break;
                default:
                    string NewNumberStr = "";
                    int NewNumber = Number % 100;

                    if (NewNumber < 10 && NewNumber > 0)
                    {
                        NewNumberStr = ("and " + Ones[NewNumber]);                       
                    }
                    else if (NewNumber >= 10 && NewNumber < 20)
                    {
                        NewNumberStr = ("and " + Teens[NewNumber - 10]);
                    }
                    else if (NewNumber >= 10 && NewNumber % 10 == 0)
                    {
                        NewNumberStr = ("and " + Tens[NewNumber / 10]);
                    }
                    else if (NewNumber % 10 != 0 && NewNumber>20)
                    {
                        NewNumberStr = ("and " + Tens[NewNumber / 10] + " " + Ones[NewNumber % 10]);
                    }


                    Console.WriteLine("{0} hundred {1}", Ones[Number/100], NewNumberStr);
                    break;
            }
        }
    }
}

