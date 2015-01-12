using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LettersSymbolsNumbers
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        long sumLetter = 0;
        long sumNumbers = 0;
        long sumSymbols = 0;

        for (int i = 0; i < N; i++)
        {
            string newLine = Console.ReadLine();

            for (int j = 0; j < newLine.Length; j++)
            {
                int charNumber = (int)newLine[j];

                if (charNumber >= 65 && charNumber <= 90)
                {
                    sumLetter += (charNumber - 65 + 1) * 10;
                }
                else if (charNumber >= 97 && charNumber <= 122)
                {
                    sumLetter += (charNumber - 97 + 1) * 10;
                }
                else if (charNumber >= 48 && charNumber <= 57)
                {
                    sumNumbers += (charNumber-48)*20;
                }
                else if (charNumber != 32 && charNumber != 9)
                {
                    sumSymbols += 200;
                }

                //Console.WriteLine(charNumber);
            }
        }

        Console.WriteLine(sumLetter);
        Console.WriteLine(sumNumbers);
        Console.WriteLine(sumSymbols);
    }
}

