using System;


class Rectangles
{
    static void Main(string[] args)
    {
        Console.Write("weigth:");
        float weigth = float.Parse(Console.ReadLine());

        Console.Write("heigth:");
        float height = float.Parse(Console.ReadLine());

        Console.WriteLine("perimerer:" + 2*(weigth+height));
        Console.WriteLine("area:"+weigth*height);
    }
}

