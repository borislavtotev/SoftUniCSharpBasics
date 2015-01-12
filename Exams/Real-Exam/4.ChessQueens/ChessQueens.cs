using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ChessQueens
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());

        int found = 0;
        char maxi = (char)('a' + N - 1);

        for (char i = 'a'; i <= maxi; i = (char)(i + 1))
        {
            for (int j = 1; j <= N; j++)
            {
                if ( (char)(i+D+1) <= maxi )
                {
                    Console.WriteLine("{0}{1} - {2}{3}",i,j,(char)(i+D+1),j);
                    found++;
                }

                if ((j + D + 1) <= N)
                {
                    Console.WriteLine("{0}{1} - {2}{3}", i, j, i, j+D+1);
                    found++;
                }

                if ((char)(i - D - 1) >= 'a')
                {
                    Console.WriteLine("{0}{1} - {2}{3}", i, j, (char)(i - D - 1), j);
                    found++;
                }

                if ((j - D - 1) >= 1)
                {
                    Console.WriteLine("{0}{1} - {2}{3}", i, j, i, j - D - 1);
                    found++;
                }
                //diagonals
                if ((char)(i + D +1) <= maxi && ((j + D +1) <= N))
                {
                    Console.WriteLine("{0}{1} - {2}{3}", i, j, (char)(i + D+1), j + D + 1);
                    found++;
                }

                if ((char)(i - D - 1) >= 'a' && ((j - D - 1) >= 1))
                {
                    Console.WriteLine("{0}{1} - {2}{3}", i, j, (char)(i - D - 1), j - D - 1);
                    found++;
                }

                if ((char)(i - D - 1) >= 'a' && ((j + D + 1) <= N))
                {
                    Console.WriteLine("{0}{1} - {2}{3}", i, j, (char)(i - D - 1), j + D + 1);
                    found++;
                }

                if ((char)(i + D + 1) <= maxi && ((j - D - 1) >= 1))
                {
                    Console.WriteLine("{0}{1} - {2}{3}", i, j, (char)(i + D + 1), j - D - 1);
                    found++;
                }
            }
        }

        if (found == 0)
        {
            Console.WriteLine("No valid positions");
        }
        //Console.WriteLine(found);

    }
}
