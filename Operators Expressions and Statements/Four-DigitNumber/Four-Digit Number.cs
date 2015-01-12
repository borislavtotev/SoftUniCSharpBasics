using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("abcd:");
        int abcd = int.Parse(Console.ReadLine());
        int d = abcd % 10;
        int c = (abcd / 10) % 10;
        int b = (abcd / 100) % 10;
        int a = (abcd / 1000) % 10;
        Console.WriteLine("sum:" + (a + b + c + d));
        Console.WriteLine("dcba:" + d.ToString() + c.ToString() + b.ToString() + a.ToString());
        Console.WriteLine("dabc:" + d.ToString() + a.ToString() + b.ToString() + c.ToString());
        Console.WriteLine("acbd:" + a.ToString() + c.ToString() + b.ToString() + d.ToString());
    }
}

