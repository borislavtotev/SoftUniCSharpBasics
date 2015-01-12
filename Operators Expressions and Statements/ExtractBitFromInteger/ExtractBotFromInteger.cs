using System;

class ExtractBotFromInteger
{
    static void Main(string[] args)
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        
        Console.Write("p=:");
        int p = int.Parse(Console.ReadLine());

        int nRigthP = n >> p;
        int bit = nRigthP & 1;
        Console.WriteLine("bit@p=" + bit);
    }
}

