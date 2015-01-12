using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MatrixOfPalindromes
{
    static void Main(string[] args)
    {
        int r = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        char start = 'a';

        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write("{0}{1}{2} ",(char)(start+i),(char)(start+i+j),(char)(start+i));        
            }
            Console.WriteLine();
        }
    }
}

