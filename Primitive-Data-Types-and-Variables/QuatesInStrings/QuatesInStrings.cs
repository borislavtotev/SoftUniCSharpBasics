using System;

class QuatesInStrings
{
    static void Main(string[] args)
    {
        string FirstString = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(FirstString);
        string SecondString = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(SecondString);
    }
}

