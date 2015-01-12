using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please add a positive number:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (i!=n)
            {
                Console.Write("{0} ", i);
            }
            else
            {
                Console.Write(i);
            }
        }
        Console.WriteLine(); 
    }
}

