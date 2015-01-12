using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main(string[] args)
    {
        char CopyrigthSymbol = '\u00A9';
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine("   {0}",CopyrigthSymbol);
        Console.WriteLine("  {0} {1}", CopyrigthSymbol, CopyrigthSymbol);
        Console.WriteLine(" {0}   {1}", CopyrigthSymbol, CopyrigthSymbol);
        Console.WriteLine("{0} {1} {2} {3}", CopyrigthSymbol, CopyrigthSymbol, CopyrigthSymbol, CopyrigthSymbol);
  }
}

