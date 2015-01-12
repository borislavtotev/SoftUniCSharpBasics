using System;

class Trapezoids
{
    static void Main(string[] args)
    {
        Console.Write("a=");
        float a = float.Parse(Console.ReadLine());
        Console.Write("b=");
        float b = float.Parse(Console.ReadLine());
        Console.Write("h=");
        float h = float.Parse(Console.ReadLine());
        Console.WriteLine("area:=" + ((a+b)*h/2).ToString());
    }
}

