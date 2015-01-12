using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class DoubleDowns
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        //long test = long.MaxValue;
        //Console.WriteLine(test);
        //Console.WriteLine(Convert.ToString(test,2));
        //Console.WriteLine(Convert.ToString(test, 2).Length);

        int[] num = new int[N];

        for (int i = 0; i < N; i++)
        {
            num[i] = int.Parse(Console.ReadLine());    
        }

        BigInteger Verticals = 0;
        BigInteger RightDiagonals = 0;
        BigInteger LeftDiagonals = 0;
        
        for (int i = 0; i < N-1; i++)
        {
            Verticals += Vertical(num[i], num[i + 1]);
            RightDiagonals += RightDiagonal(num[i], num[i + 1]);
            LeftDiagonals += LeftDiagonal(num[i], num[i + 1]);
        }

        Console.WriteLine(RightDiagonals);
        Console.WriteLine(LeftDiagonals);
        Console.WriteLine(Verticals);
    }
    private static int Vertical (long a, long b)
    {
        long c = a & b;
        return Count1(c);
    }
    private static int RightDiagonal(long a, long b)
    {
        long Dummy = b << 1;
        return Vertical(a,Dummy);
    }
    private static int LeftDiagonal(long a, long b)
    {
        long Dummy = b >> 1;
        return Vertical(a, Dummy);
    }
    private static int Count1 (long k)
    {
        int count = 0;

        for (int i = 0; i < 64; i++)
        {
            long newK = k >> i;
            long Dummy = newK & (long)1;

            if (Dummy == 1)
            {
                count++;
            }
        }
        return count;
    }
}

