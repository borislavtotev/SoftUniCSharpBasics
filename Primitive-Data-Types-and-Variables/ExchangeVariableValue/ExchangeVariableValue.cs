using System;

class ExchangeVariableValue
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        
        Console.WriteLine("a:{0}", a);
        Console.WriteLine("b:{0}", b);

        a = a + b;
        b  = a - b;
        a = a - b;
        Console.WriteLine("After swap:");
        Console.WriteLine("a:{0}",a);
        Console.WriteLine("b:{0}",b);
    }
}
