using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OddEvenElements
{
    static void Main(string[] args)
    {
        string Input = Console.ReadLine();
        string[] ValuesStr = Input.Split(' ');

        decimal minOdd = int.MaxValue;
        decimal minEven = int.MaxValue;
        decimal maxOdd = int.MinValue;
        decimal maxEven = int.MinValue;
        decimal sumOdd = 0;
        decimal sumEven = 0;

        if (ValuesStr[0] == "")
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }
        else
        {
            for (int i = 0; i < ValuesStr.Length; i = i + 2)
            {
                decimal NewValue = Convert.ToDecimal(ValuesStr[i]);
                sumOdd += NewValue;

                if (NewValue > maxOdd)
                {
                    maxOdd = NewValue;
                }

                if (NewValue < minOdd)
                {
                    minOdd = NewValue;
                }
            }


            if (ValuesStr.Length < 2)
            {
                Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No", sumOdd.ToString("G10"), minOdd.ToString("G10"), maxOdd.ToString("G10"));
            }
            else
            {
                for (int i = 1; i < ValuesStr.Length; i = i + 2)
                {
                    decimal NewValue = Convert.ToDecimal(ValuesStr[i]);
                    sumEven += NewValue;

                    if (NewValue > maxEven)
                    {
                        maxEven = NewValue;
                    }

                    if (NewValue < minEven)
                    {
                        minEven = NewValue;
                    }
                }
                Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", sumOdd.ToString("G10"), minOdd.ToString("G10"), maxOdd.ToString("G10"), sumEven.ToString("G10"), minEven.ToString("G10"), maxEven.ToString("G10"));
            }

        }
    }
}

