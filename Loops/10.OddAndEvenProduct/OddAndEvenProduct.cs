using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OddAndEvenProduct
{
    static void Main(string[] args)
    {
        string Input = Console.ReadLine();
        string[] NumbersStr = Input.Split(' ');

        long odd_product = 1;
        long even_product = 1;

        for (int i = 0; i < NumbersStr.Length; i++)
        {
            if (i % 2 == 0)
            {
                odd_product *= Convert.ToInt32(NumbersStr[i]);
            }
            else
            {
                even_product *= Convert.ToInt32(NumbersStr[i]);
            }
        }

        if (odd_product == even_product)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product={0}",odd_product);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product={0}", odd_product);
            Console.WriteLine("even_product={0}", even_product);
        }
    }
}

