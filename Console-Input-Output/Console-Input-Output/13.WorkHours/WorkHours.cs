using System;


class WorkHours
{
    static void Main(string[] args)
    {
        long h = long.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        long WorkHours = (long)(d * 0.9 * 12 * p / 100);
        if (WorkHours >= h)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
        Console.WriteLine(WorkHours - h);
    }
}

