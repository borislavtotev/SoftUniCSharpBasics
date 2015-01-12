using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class InsideBuilding
{
    static void Main(string[] args)
    {
        int h = int.Parse(Console.ReadLine());
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        int x3 = int.Parse(Console.ReadLine());
        int y3 = int.Parse(Console.ReadLine());
        int x4 = int.Parse(Console.ReadLine());
        int y4 = int.Parse(Console.ReadLine());
        int x5 = int.Parse(Console.ReadLine());
        int y5 = int.Parse(Console.ReadLine());
        InOut(x1, y1, h);
        InOut(x2, y2, h);
        InOut(x3, y3, h);
        InOut(x4, y4, h);
        InOut(x5, y5, h);

    }
    static void InOut(int x1, int y1,int h)
    {
        if ((x1 >= 0 && x1 <= h && y1 >= 0 && y1 <= h) || (x1 > 2 * h && x1 <= 3 * h && y1 >= 0 && y1 <= h) || (x1 >= h && x1 <= 2 * h && y1 >= 0 && y1 <= 4 * h))
        {
            Console.WriteLine("inside");
        }
        else
        {
            Console.WriteLine("outside");
        }
    }
}

