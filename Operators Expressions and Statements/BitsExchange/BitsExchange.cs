using System;

class BitsExchange
{
    static void Main(string[] args)
    {
        Console.Write("n=");
        UInt32 n = UInt32.Parse(Console.ReadLine());
        //Console.WriteLine(Convert.ToString(n,2).PadLeft(32,'0'));


        UInt32 NewN = new UInt32();
        for (int i = 0; i < 3; i++)
        {
            if (MyExtractBit(n, 3 + i) != MyExtractBit(n, 24 + i))
            {
                //Console.WriteLine("different values");
                NewN = ChangeValueAtGivenPosition(n, 3 + i);
                NewN = ChangeValueAtGivenPosition(NewN, 24 + i);
            }
            else
            {
                NewN = n;
            }
            n = NewN;
        }

 
        //Console.WriteLine(Convert.ToString(NewN, 2).PadLeft(32, '0'));
        Console.WriteLine("result="+ NewN);
    }


    private static UInt32 MyExtractBit(UInt32 num, int position)
    {
        UInt32 nRigthP = num >> position;
        UInt32 bit = nRigthP & 1;
        return bit;
    }

    private static UInt32 ChangeValueAtGivenPosition(UInt32 num, int position)
    {
        UInt32 v = MyExtractBit(num, position);
        UInt32 Test = 1;
        UInt32 Dummy = Test << position;
        UInt32 NewN = new UInt32();
        if (v == 1)
        {
            NewN = num & (~Dummy); 
        }
        else
        {
            NewN = num | Dummy;
        }
        //Console.WriteLine(Convert.ToString(NewN,2).PadLeft(32,'0'));
        return NewN; 
    }
}