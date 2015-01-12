using System;

class CheckBitAtGivenPosition
{
    static void Main(string[] args)
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("p=");
        int p = int.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString(n,2).PadLeft(16,'0'));
        int nRightP = n >> p;
        Console.WriteLine(Convert.ToString(nRightP, 2).PadLeft(16, '0'));
        int bit = nRightP & 1;
        Console.WriteLine("bit=" + bit);
        Boolean BitIs1 = (bit == 1) ? true : false;
        Console.WriteLine("bit@p==1:"+BitIs1);
    }
}

