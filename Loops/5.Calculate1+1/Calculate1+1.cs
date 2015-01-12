using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Calculate1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());

            double sum = 1;
            double chislitel = 1;
            double znamenatel = 1;

            for (int i = 1; i <= n; i++)
            {
                chislitel *= i;
                znamenatel *= x;
                sum += chislitel/znamenatel;
            }
            Console.WriteLine("{0:0.00000}",sum);
        }
    }
