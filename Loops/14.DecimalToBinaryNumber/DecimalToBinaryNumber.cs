using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DecimalToBinaryNumber
{
    static void Main(string[] args)
    {
        long n = int.Parse(Console.ReadLine());

        long k = n;
        string result = "";

        while (k != 0)
        {
            result = Convert.ToString(k % 2) + result;
            k = k / 2;  
        }
        Console.WriteLine(result);
        //Console.WriteLine(Convert.ToString(n,2));
    }
}

