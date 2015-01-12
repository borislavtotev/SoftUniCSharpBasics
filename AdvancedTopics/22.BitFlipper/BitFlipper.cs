using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class BitFlipper
{
    static void Main(string[] args)
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        //string nStr = Convert.ToString(n, 2).PadLeft(64, '0');
        //Console.WriteLine(nStr);

        for (int i = 0; i < 62; i++)
        {
            if ( GetBit(n,i)==GetBit(n,i+1) && GetBit(n,i+1)==GetBit(n,i+2) )
            {
                n = ChangeBit(n, i);
                n = ChangeBit(n, i+1);
                n = ChangeBit(n, i+2);
                i += 2;
            }
        }
        Console.WriteLine(n);
    }
    private static string GetBit(BigInteger NewInt, int position)
    {
        BigInteger NewDummy = NewInt >> (64 - position - 1);
        //Console.WriteLine(Convert.ToString(NewDummy, 2).PadLeft(8, '0'));

        BigInteger NewValue = NewDummy & 1;
        //Console.WriteLine("{0}:{1}", position, Convert.ToString(NewValue));
        return Convert.ToString(NewValue);
    }
    private static BigInteger ChangeBit(BigInteger NewInt, int position)
    {
        BigInteger NewDummy = (BigInteger)1 << (64 - position - 1);
        //Console.WriteLine(Convert.ToString(NewDummy, 2).PadLeft(64, '0'));

        BigInteger NewValue = NewInt ^ NewDummy;
        //Console.WriteLine("{0}:{1}", position, Convert.ToString(NewValue));
        return NewValue;
    }

}

