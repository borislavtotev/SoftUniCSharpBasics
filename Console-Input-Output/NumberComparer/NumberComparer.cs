using System;

class NumberComparer
{
    static void Main(string[] args)
    {
        Console.Write("a="); 
        double a = double.Parse(Console.ReadLine());
        Console.Write("b=");
        double b = double.Parse(Console.ReadLine());

        double c = a >= b ? a : b;
        Console.WriteLine("The greater one is:{0}",c);
    }
}

