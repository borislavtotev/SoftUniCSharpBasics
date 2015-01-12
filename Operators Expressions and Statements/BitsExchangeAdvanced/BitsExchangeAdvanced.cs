using System;

class BitsExchange
{
    static void Main(string[] args)
    {

        Console.Write("n=");
        UInt32 n = UInt32.Parse(Console.ReadLine());

        Console.Write("p=");
        int p = int.Parse(Console.ReadLine());

        Console.Write("q=");
        int q = int.Parse(Console.ReadLine());

        Console.Write("k=");
        int k = int.Parse(Console.ReadLine());
      
        if (p==q || (p<q && (p+k-1) >= q) || (p>q && (q+k-1)>=p) )
	    {
		    Console.WriteLine("overlapping"); 
	    }
        else if (p<0 || p>31 || q<0 || q>31 || (p+k-1)>31 || (q+k-1)>31)
	    {
		    Console.WriteLine("out of range"); 
	    }
        else
	    {
            //Console.WriteLine(Convert.ToString(n,2).PadLeft(32,'0'));


            UInt32 NewN = new UInt32();
            for (int i = 0; i < k; i++)
            {
                if (MyExtractBit(n, (p + i)) != MyExtractBit(n, q + i))
                {
                    //Console.WriteLine("different values");
                    NewN = ChangeValueAtGivenPosition(n, p + i);
                    NewN = ChangeValueAtGivenPosition(NewN, q + i);
                }
                else
                {
                    NewN = n;
                }
                n = NewN;
            }


            //Console.WriteLine(Convert.ToString(NewN, 2).PadLeft(32, '0'));
            Console.WriteLine("result=" + NewN);
        }
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