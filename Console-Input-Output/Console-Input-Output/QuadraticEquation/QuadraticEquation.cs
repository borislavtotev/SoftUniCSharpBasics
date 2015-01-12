using System;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        Console.Write("a=");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b=");
        double b = double.Parse(Console.ReadLine());

        Console.Write("c=");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("The decision of {0}x2+{1}x+{2}=0 are:",a,b,c);

        double x1 = (-b + Math.Sqrt(b*b-4*a*c))/(2*a);
        double x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);

        if (x1==x2)
        {
            Console.WriteLine("x1=x2=" + x1);
        }
        else if (Double.IsNaN(x1) && Double.IsNaN(x2))
        {
            Console.WriteLine("no real roots");
        }
        else
        {
            Console.WriteLine("x1=" + x1);
            Console.WriteLine("x2=" + x2);            
        }

    }
}

