using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheExplorer
{
    class TheExplorer
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i==1 || i==n)
                {
                    string FirstRow = "-".PadLeft((n - 1) / 2, '-');
                    FirstRow += "*";
                    FirstRow = FirstRow.PadRight(n, '-');
                    Console.WriteLine(FirstRow);
                }
                else if (i==(n-1)/2+1)
                {
                    string MiddleRow = "*".PadRight(n - 1, '-');
                    MiddleRow += "*";
                    Console.WriteLine(MiddleRow);
                }
                else
                {
                    string NormalRow = "".PadLeft(Math.Abs((n - 1) / 2 + 1 - i), '-');
                    NormalRow += "*";
                    NormalRow = NormalRow.PadRight(n - Math.Abs((n - 1) / 2 + 1 - i) - 1, '-');
                    NormalRow += "*";
                    NormalRow = NormalRow.PadRight(n, '-');
                    Console.WriteLine(NormalRow);
                }


            }
        }
    }
}
