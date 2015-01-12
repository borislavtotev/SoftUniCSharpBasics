using System;

class ModifyBitAtGivenPosition
{
    static void Main(string[] args)
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("p=");
        int p = int.Parse(Console.ReadLine());
        Console.Write("v=");
        int v = int.Parse(Console.ReadLine());

        int Dummy = 1 << p;
        int NewN = new int();
        if (v==1)
        {
            NewN = n | Dummy;             
        }
        else
        {
            NewN = n & (~Dummy);
        }
        //Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));
        //Console.WriteLine(Convert.ToString(NewN,2).PadLeft(16,'0'));
        Console.WriteLine(NewN);
    }
}

