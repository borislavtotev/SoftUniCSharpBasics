using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class PrimeInGivenRange
{
    static void Main(string[] args)
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());

        List<int> PrimeNumbers = new List<int>();

        if (startNum <= endNum)
        {
            if (startNum < 2)
            {
                startNum = 2;    
            } 
            PrimeNumbers = FindPrimesInRange(startNum,endNum);    
        }

        if (PrimeNumbers.Count == 0)
        {
            Console.WriteLine("(empty list)");
        }
        else
        {
            for (int i = 0; i < PrimeNumbers.Count; i++)
            {
                if (i==0)
                {
                    Console.Write(PrimeNumbers[i]);
                }
                else
                {
                    Console.Write(", " + PrimeNumbers[i]);
                }

            }
        }

    }

    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> FindNumbers = new List<int>();

        for (int i = startNum; i <= endNum; i++)
        {
            Boolean isPrime = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }    
            }
            if (isPrime)
            {
                FindNumbers.Add(i);
            }

        }
        return FindNumbers;
    }
}
