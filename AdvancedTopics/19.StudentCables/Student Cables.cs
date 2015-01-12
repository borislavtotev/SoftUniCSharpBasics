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

        int[] Cables = new int[n];

        for (int i = 0; i < n; i++)
        {
            int NewLenght = int.Parse(Console.ReadLine());
            string NewMeasure = Console.ReadLine();

            if (NewMeasure == "meters")
            {
                NewLenght *= 100;
            }
            Cables[i] = NewLenght;
        }

        int TotalLength = 0;
        int RemovedCables = 0;

        for (int i = 0; i < n; i++)
        {
            if (Cables[i] < 20)
            {
                RemovedCables++;
                continue;
            }
            TotalLength += Cables[i];
        }

        TotalLength = TotalLength - 3 * (n - 1 - RemovedCables);

        int CableNumbers = 0;

        while (TotalLength >= 504 )
        {
            TotalLength -= 504;
            CableNumbers++;
        }

        Console.WriteLine(CableNumbers);
        Console.WriteLine(TotalLength);

    }
}

