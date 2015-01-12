using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Triangle
{
    static void Main(string[] args)
    {
        int Ax = int.Parse(Console.ReadLine());
        int Ay = int.Parse(Console.ReadLine());
        int Bx = int.Parse(Console.ReadLine());
        int By = int.Parse(Console.ReadLine());
        int Cx = int.Parse(Console.ReadLine());
        int Cy = int.Parse(Console.ReadLine());

        double a = Math.Sqrt((Bx - Cx) * (Bx - Cx) + (By - Cy) * (By - Cy));
        double b = Math.Sqrt((Ax - Cx) * (Ax - Cx) + (Ay - Cy) * (Ay - Cy));
        double c = Math.Sqrt((Bx - Ax) * (Bx - Ax) + (By - Ay) * (By - Ay));

        if ((a+b)>c && (a+c)>b && (b+c)>a)
        {
            Console.WriteLine("Yes");
            double p = (a+b+c)/2;
            double Area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("{0:0.00}",Area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:0.00}",c);
        }
    }
}

