using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RandomNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        Random rnd = new Random();
        
        for (int i = 0; i < n; i++)
        {
            int newValue = rnd.Next(min, max+1);
            Console.Write("{0} ",newValue);
        }
        Console.WriteLine();

    }
}

