using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MatrixofNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j < i+n; j++)
            {
                Console.Write("{0} ",j);
            }
            Console.WriteLine();
        }
    }
}

