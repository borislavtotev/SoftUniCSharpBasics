using System;

class TheBiggestof3Numbers
{
    static void Main(string[] args)
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());

        if (a >= b && a >=c )
        {
            Console.WriteLine(a);
        }
        else if (a<=c && b<=c)
        {
            Console.WriteLine(c);
        }
        else if (b >= c && b >=a)
        {
            Console.WriteLine(b);
        }
    }
}

