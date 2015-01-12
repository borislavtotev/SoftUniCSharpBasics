using System;
using System.Text;

class BitSifting
{
    static void Main(string[] args)
    {
        UInt64 Number = UInt64.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        //Console.WriteLine(Convert.ToString((uint)Number, 2).PadLeft(32, '0'));

        ulong LastNumber = new ulong();

        if (N>0)
	    {
		    LastNumber = ulong.Parse(Console.ReadLine());
            //Console.WriteLine("retert");
            //Console.WriteLine(Convert.ToString((uint)LastNumber,2).PadLeft(32,'0'));
	    }
        
        
        for (int i = 1; i < N; i++)
        {
            
            UInt64 NewNumber = UInt64.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString((uint)NewNumber, 2).PadLeft(32, '0'));
            LastNumber = NewNumber | LastNumber;
            //Console.WriteLine("result");
            //Console.WriteLine(Convert.ToString((uint)LastNumber, 2).PadLeft(32, '0'));
        }

        LastNumber = ~LastNumber;
        //Console.WriteLine(Convert.ToString((uint)LastNumber, 2).PadLeft(32, '0'));
        UInt64 FinalNumber = Number & LastNumber;
        //Console.WriteLine("final:");
        //Console.WriteLine(Convert.ToString((uint)FinalNumber, 2).PadLeft(32, '0'));

        int NumberOfOne = new int();

        for (int i = 0; i < 64; i++)
        {
            ulong DummyNumber = FinalNumber >> i;
            if ((DummyNumber & 1) == 1)
            {
                NumberOfOne++;    
            }
        }
        Console.WriteLine(NumberOfOne);
    }
}

