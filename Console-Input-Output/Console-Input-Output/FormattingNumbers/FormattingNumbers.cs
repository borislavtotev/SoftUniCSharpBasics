using System;

using System.Text;


class FormattingNumbers
{
    static void Main(string[] args)
    {
        Console.Write("a=");
        int a = int.Parse(Console.ReadLine());

        Console.Write("b=");
        float b = float.Parse(Console.ReadLine());

        Console.Write("c=");
        float c = float.Parse(Console.ReadLine());

        Console.Write("|{0,-10:X}",a);
        Console.Write("|{0}|", Convert.ToString(a,2).PadLeft(10,'0'));
        Console.Write("{0,10:F2}|",b);
        Console.WriteLine("{0,-10:0.###}|", c);
     }
}

