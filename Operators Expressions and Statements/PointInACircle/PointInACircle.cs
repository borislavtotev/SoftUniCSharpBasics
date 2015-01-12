using System;

class PointInACircle
{
    static void Main(string[] args)
    {
            Console.Write("x:");
            float x = float.Parse(Console.ReadLine());
            Console.Write("y:");
            float y = float.Parse(Console.ReadLine());
            Boolean InTheCircle = new Boolean();
            InTheCircle = (Math.Sqrt(x * x + y * y) <= 2) ? true : false;
            Console.WriteLine("The point is in the circle:" + InTheCircle);  
    }
}

