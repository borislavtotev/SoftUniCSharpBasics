using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class Tables
{
    static void Main(string[] args)
    {
        BigInteger legs = 0;

        for (int i = 1; i < 5; i++)
        {
            BigInteger newValue = BigInteger.Parse(Console.ReadLine());
            legs += i * newValue;
        }

        BigInteger T = BigInteger.Parse(Console.ReadLine());
        BigInteger N = BigInteger.Parse(Console.ReadLine());

        BigInteger PosibleTables = 0;
        if ( (legs/4) <= T )
	    {
		    PosibleTables = legs/4;
	    }
        else
	    {
            PosibleTables = T;
	    }

        if (PosibleTables==N)
        {
            Console.WriteLine("Just enough tables made: {0}", N);
        }
        else if ( PosibleTables > N)
        {
            Console.WriteLine("more: {0}",PosibleTables-N);
            Console.WriteLine("tops left: {0}, legs left: {1}", T - N, legs - N * 4);
        }
        else 
	    {        
            Console.WriteLine("less: {0}", PosibleTables - N);

            BigInteger NotEnoughLegs = N * 4 - legs;

            if (NotEnoughLegs < 0)
            {
                NotEnoughLegs = 0;
            }

            BigInteger NotEnoughT = N - T;

            if (NotEnoughT < 0)
            {
                NotEnoughT = 0;
            }

            Console.WriteLine("tops needed: {0}, legs needed: {1}", NotEnoughT, NotEnoughLegs);  
       
        }


    }
}

