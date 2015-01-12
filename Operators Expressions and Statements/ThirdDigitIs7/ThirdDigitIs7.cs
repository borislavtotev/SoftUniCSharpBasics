using System;

class ThirdDigitIs7
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please add the number:");
        int Number = int.Parse(Console.ReadLine());
        Boolean Proper = new Boolean();
        Proper = (Math.Abs(Number/100) % 10 == 7) ? true : false;
        Console.WriteLine("The Third Digit is 7:" + Proper);
    }
}

