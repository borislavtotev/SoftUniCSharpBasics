using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ExtractUrlsFromText
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string[] inputArray = input.Split(' '); //split by signs in the text

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].StartsWith("http:") || inputArray[i].StartsWith("www."))
            {
                if (inputArray[i].EndsWith("."))
                {
                    string NewURL = inputArray[i].Substring(0,inputArray[i].Length-1);
                    Console.WriteLine(NewURL);
                }
                else
                {
                    Console.WriteLine(inputArray[i]);
                }
            }
        }

    }
}
