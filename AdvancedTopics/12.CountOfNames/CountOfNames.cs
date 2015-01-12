using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountOfNames
{
    static void Main(string[] args)
    {
        string LettersStr = Console.ReadLine();

        string[] LettersArray = LettersStr.Split(' ');
        Array.Sort(LettersArray);

        Dictionary<string, int> Letters = new Dictionary<string, int>();

        for (int i = 0; i < LettersArray.Length; i++)
        {
            if (Letters.ContainsKey(LettersArray[i]))
            {
                Letters[LettersArray[i]]++;
            }
            else
            {
                Letters[LettersArray[i]] = 1;
            }

        }

        foreach (var item in Letters.Keys)
        {
            Console.WriteLine("{0} -> {1}", item, Letters[item]);
        }

    }
}

