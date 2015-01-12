using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LongestWordInText
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string[] inputArray = input.Split(' ','.',','); //split by signs in the text

        int longestNumber = 0;
        int length = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length > length)
            {
                longestNumber = i;
                length = inputArray[i].Length;
            }
        }

        Console.WriteLine(inputArray[longestNumber]);
    }
}

