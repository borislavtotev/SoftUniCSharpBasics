using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MorseCodeNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int nSum = 0;
        int newN = n;

        do
        {
            nSum += newN % 10;
            newN /= 10;
        } while (newN != 0);
        
        //Console.WriteLine(nSum);

        int NumberOfFounds = 0;

        if (nSum == 0)
        {
            Console.WriteLine("-------------------------");
        }
        else
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 6; k++)
                    {
                        for (int l = 0; l < 6; l++)
                        {
                            for (int m = 0; m < 6; m++)
                            {
                                for (int p = 0; p < 6; p++)
                                {
                                    if ( i*j*k*l*m*p == nSum )
                                    {
                                        int[] AllNumbers = new int[] { i, j, k, l, m, p };
                                        Print(AllNumbers);
                                        NumberOfFounds++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        if (NumberOfFounds == 0)
        {
            Console.WriteLine("No");
        }

    }
    private static void Print(int[] Numbers)
    {
        for (int i = 0; i < Numbers.Length; i++)
        {
            switch (Numbers[i])
            {
                case 0: Console.Write("-----" + "|"); break;
                case 1: Console.Write(".----" + "|"); break;
                case 2: Console.Write("..---" + "|"); break;
                case 3: Console.Write("...--" + "|"); break;
                case 4: Console.Write("....-" + "|"); break;
                case 5: Console.Write("....." + "|"); break;
                default:
                    break;
            }
        }
        Console.WriteLine();
    }
}

