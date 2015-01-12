using System;
using System.Text;

class Sunglasses
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            if ((i==0) || (i==N-1))
            {
                String str = "*".PadRight(2*N,'*');
                str = str.PadRight(3 * N, ' ');
                str = str.PadRight(5 * N, '*');
                Console.WriteLine(str);
            }
            else if (i==(N-1)/2)
            {
                String str = "*".PadRight(2 * N-1, '/');
                str = str + "*";
                str = str.PadRight(3 * N, '|');
                str = str + "*";
                str = str.PadRight(5 * N-1, '/');
                str = str + "*";
                Console.WriteLine(str);
            }
            else
            {
                String str = "*".PadRight(2 * N - 1, '/');
                str = str + "*";
                str = str.PadRight(3 * N, ' ');
                str = str + "*";
                str = str.PadRight(5 * N - 1, '/');
                str = str + "*";
                Console.WriteLine(str);
            }
        }
    }
}

