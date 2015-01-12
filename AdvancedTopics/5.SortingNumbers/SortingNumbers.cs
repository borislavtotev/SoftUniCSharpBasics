using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortingNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] ArrayInt = new int[n];

        for (int i = 0; i < n; i++)
        {
            ArrayInt[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(ArrayInt);
        Console.WriteLine();

        foreach (var item in ArrayInt)
        {
            Console.WriteLine(item);
        }
    }
}

