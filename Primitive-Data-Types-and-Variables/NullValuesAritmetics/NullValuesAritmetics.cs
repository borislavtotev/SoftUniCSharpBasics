using System;

class NullValuesAritmetics
{
    static void Main(string[] args)
    {
        int? IntValue = null;
        double? DoubleValue = null;
        Console.WriteLine("IntValue:" + IntValue);
        Console.WriteLine("DoubleValue:" + DoubleValue);
        IntValue += 5;
        DoubleValue += 5;
        Console.WriteLine("Add 5 to them:");
        Console.WriteLine("IntValue:" + IntValue);
        Console.WriteLine("DoubleValue:" + DoubleValue);
    }
}

