using System;

class OddOrEvenIntegers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please add a number:");
        int n = int.Parse(Console.ReadLine());
        Boolean Odd = (!(n % 2 == 0)) ? true : false;
        Console.WriteLine(Odd);
    }
}

