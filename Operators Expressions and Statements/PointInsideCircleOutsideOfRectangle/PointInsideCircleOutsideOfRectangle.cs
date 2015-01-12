using System;

class PointInsideCircleOutsideOfRectangle
{
    static void Main(string[] args)
    {
        Console.Write("x:");
        float x = float.Parse(Console.ReadLine());
        Console.Write("y:");
        float y = float.Parse(Console.ReadLine());

        Boolean InTheCircle = new Boolean();
        InTheCircle = (Math.Sqrt( (x-1) * (x-1) + (y-1) * (y-1) ) <= 1.5) ? true : false;

        Boolean IsNotInTheRectangle = new Boolean();
        IsNotInTheRectangle = (!(x >= -1 && x <= 5 && y >= -1 && y <= 1)) ? true : false;

        if (InTheCircle && IsNotInTheRectangle)
        {
            Console.WriteLine("yes"); 
        }
        else
        {
            Console.WriteLine("no"); 
        }
    }
}

