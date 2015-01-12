using System;

class BitwiseExtractBit
{
    static void Main(string[] args)
    {
        int p = 3;
        int n = int.Parse(Console.ReadLine());
        //Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));
        int nRigthP = n >> p;
        int bit = nRigthP & 1;
        Console.WriteLine(bit);
    }
}

