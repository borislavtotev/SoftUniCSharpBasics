using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class BinarytoDecimalNumber
{
    static void Main(string[] args)
    {
        string binary = Console.ReadLine();

        long sum = 0;

        for (int i = 0; i < binary.Length; i++)
        {
            BigInteger newBit = GetBitValue(binary,i);
            sum += (long)newBit * (long)Math.Pow(2,i);
        }
        Console.WriteLine(sum);
    }
    private static BigInteger GetBitValue(string binary,int position)
    {
        BigInteger binaryInt = Convert.ToInt64(binary,2);
        BigInteger Dummy = binaryInt >> position;
        BigInteger NewDummy = Dummy & 1;
        return NewDummy;
    }
}

