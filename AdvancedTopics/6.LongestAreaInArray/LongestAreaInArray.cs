using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LongestAreaInArray
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, int> strBook = new Dictionary<string, int>();

        string LastStr = null;

        for (int i = 0; i < n; i++)
        {
            string CurrentStr = Console.ReadLine();

            if (CurrentStr == LastStr)
            {
                strBook[CurrentStr]++ ;
            }
            else
            {
                strBook[CurrentStr] = 1;
                LastStr = CurrentStr;
            }
        }


        foreach (var Key in strBook.Keys)
        {
            if (strBook[Key] == strBook.Values.Max() )
            {
                Console.WriteLine(strBook.Values.Max());

                for (int i = 0; i < strBook.Values.Max(); i++)
                {
                    Console.WriteLine(Key);
                }

                break;
            }
        }
    }
}

