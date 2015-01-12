using System;

class StringsAndObjects
{
    static void Main(string[] args)
    {
        string Word1 = "Hello";
        string Word2 = "World";
        object Sentance = Word1 + " " + Word2;
        Console.WriteLine(Sentance);
        string StrSentance = (string)Sentance;
        Console.WriteLine(StrSentance);
    }
}
