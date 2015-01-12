using System;

class GravitationOfTheMoon
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please add  your weight on the Earth:");
        double Weigth = double.Parse(Console.ReadLine());
        double MoonWeight = 0.17*Weigth;
        Console.WriteLine("Your weight on the Moon is:" + MoonWeight);
    }
}
