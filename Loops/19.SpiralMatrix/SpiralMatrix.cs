using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int[,] Matrix = new int[n+1,n+1];

        int a = 1;
        int b = 1;
        int maxA = n;
        int minA = 2;
        int maxB = n;
        int minB = 1;
        int changeA = 1;
        int changeB = 1;
        int which = 2;

        for (int i = 1; i <= (n*n); i++)
        {
            Matrix[a, b] = i;
            //Console.WriteLine("{0},{1}  ", a, b);

            if (which == 1)
            {
                if (changeA == 1)
                {
                    if (a != (maxA-1))
                    {
                        a = a + changeA;
                        continue;
                    }
                    else if (a == (maxA-1))
                    {
                        a = a + changeA;
                        changeA = -1;
                        maxA--;
                        which = 2;
                        continue;
                    }
                } 
                else if (changeA == -1)
                {
                    if (a != (minA+1))
                    {
                        a = a + changeA;
                        continue;
                    }
                    else if (a == (minA+1))
                    {
                        a = a + changeA;
                        changeA = 1;
                        minA++;
                        which = 2;
                        continue;
                    }
                } 
            }
            else if (which == 2)
            {
                if (changeB == 1)
                {
                    if (b != (maxB-1))
                    {
                        b = b + changeB;
                        continue;
                    }
                    else if (b == (maxB-1))
                    {
                        b = b + changeB;
                        changeB = -1;
                        maxB--;
                        which = 1;
                        continue;
                    }
                } 
                else if (changeB == -1)
                {
                    if (b != (minB+1))
                    {
                        b = b + changeB;
                        continue;
                    }
                    else if (b == (minB+1))
                    {
                        b = b + changeB;
                        changeB = 1;
                        minB++;
                        which = 1;
                        continue;
                    }
                } 
            }

        }

        for (int row = 1; row <= n; row++)
        {
            for (int column = 1; column <= n; column++)
            {
                Console.Write("{0,-5}",Matrix[row,column]);
            }
            Console.WriteLine();
        }

    }
}

