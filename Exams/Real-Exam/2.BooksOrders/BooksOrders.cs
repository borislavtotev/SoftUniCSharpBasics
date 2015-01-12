using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class BooksOrders
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        BigInteger Books = 0;
        double Price = 0;

        for (int i = 0; i < N; i++)
        {
            BigInteger NewNumberOfPackets = BigInteger.Parse(Console.ReadLine());
            BigInteger NewBooksPerPackets = BigInteger.Parse(Console.ReadLine());
            double NewBookPrice = double.Parse(Console.ReadLine());

            Books += NewNumberOfPackets * NewBooksPerPackets;

            double discount = 0;

            BigInteger Dummy = NewNumberOfPackets / 10;

            if (Dummy >= 11)
            {
                discount = 0.15;
            }
            else if (Dummy >= 1 && Dummy < 11)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (Dummy == j)
                    {
                        discount = ((double)4 + (double)Dummy) / 100;
                        break;
                    }
                }
            }
            //Console.WriteLine(discount);

            Price += (double)NewNumberOfPackets * (double)NewBooksPerPackets * (double)NewBookPrice * (double)(1 - discount);

        }
        Console.WriteLine(Books);
        Console.WriteLine("{0:0.00}", Price);
    }
}

