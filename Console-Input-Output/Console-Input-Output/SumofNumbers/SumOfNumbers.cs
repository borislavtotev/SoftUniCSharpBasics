using System;

class SumOfNumbers
{
    static void Main(string[] args)
    {
        Console.Write("number1:");
        double number1 = double.Parse(Console.ReadLine());
        Console.Write("number2:");
        double number2 = double.Parse(Console.ReadLine());
        Console.Write("number3:");
        double number3 = double.Parse(Console.ReadLine());

        Console.WriteLine("number 1+2+3={0}", number1 + number2 + number3);
    }
}

