using System;

class CirclePerimeterArea
{
    static void Main(string[] args)
    {
        double r = double.Parse(Console.ReadLine());
        double pi = 3.14;
        Console.WriteLine("perimeter:{0:0.00}",2*pi*r);
        Console.WriteLine("area:{0:0.00}", pi * r * r);
    }
}

