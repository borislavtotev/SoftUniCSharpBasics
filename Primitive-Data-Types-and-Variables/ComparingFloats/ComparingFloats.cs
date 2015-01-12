using System;

class ComparingFloats
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please add number a:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Please add number b:");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("The System will StringComparer a and b with 0.000001 precious and the result is:");

        double eps = 0.000001;
        Boolean Equal = false;

        if (Math.Abs(a-b) < eps )
        {
            Equal = true;
        }

        Console.WriteLine(Equal);
    }
}

