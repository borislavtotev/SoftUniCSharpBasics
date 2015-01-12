using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        int magicWeight = int.Parse(Console.ReadLine());

        string[] Alphas = new string[] {"A", "B", "C", "E", "H", "K", "M", "P", "T", "X" };

        List<string> CarNumbers = new List<string>();

        int magicNumbers = 0;

        for (int a = 0; a < 10; a++)
        {
            for (int b = a+1; b < 10; b++)
            {
                string[] NumbersArray = new string[] { "CA" + a + a + a + a,
                                                       "CA" + a + b + b + b,
                                                       "CA" + a + a + a + b,
                                                       "CA" + a + a + b + b,
                                                       "CA" + a + b + a + b,
                                                       "CA" + a + b + b + a,
                                                         "CA" + b + b + b + b,
                                                         "CA" + b + a + a + a, 
                                                         "CA" + b + b + b + a,
                                                         "CA" + b + b + a + a,
                                                         "CA" + b + a + b + a,
                                                         "CA" + b + a + a + b,};
                foreach (var NumberStr in NumbersArray)
                {                   
                    for (int k = 0; k < Alphas.Length; k++)
                    {
                        for (int l = 0; l < Alphas.Length; l++)
                        {
                            string CarNumber = NumberStr + Alphas[k] + Alphas[l];
                            if (Weight(CarNumber) == magicWeight)
                            {
                                //Console.WriteLine(CarNumber);
                                if (! CarNumbers.Contains(CarNumber))
                                {
                                    CarNumbers.Add(CarNumber);
                                    magicNumbers++;
                                }
                            }
                        }
                    }
                }

            }
        }
        
        Console.WriteLine(magicNumbers);
    }
    private static int Weight(string CarNumber)
    {
        int weightValue = 0;

        for (int i = 0; i < CarNumber.Length; i++)
        {
            switch (CarNumber[i])
            {
                case 'A': weightValue += 10; break;
                case 'B': weightValue += 20; break;
                case 'C': weightValue += 30; break;
                case 'E': weightValue += 50; break;
                case 'H': weightValue += 80; break;
                case 'K': weightValue += 110; break;
                case 'M': weightValue += 130; break;
                case 'P': weightValue += 160; break;
                case 'T': weightValue += 200; break;
                case 'X': weightValue += 240; break;
                default:
                    weightValue += (int)Char.GetNumericValue(CarNumber[i]);
                    break;
            }
        }
        return weightValue;
    }

}

