using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HexadecimalDecimalNumber
{
    static void Main(string[] args)
    {
        string hexValue = Console.ReadLine();

        long result = 0;

        for (int i = 0; i < hexValue.Length; i++)
        {
            char newChar = hexValue.ElementAt(hexValue.Length-1-i);
            switch (newChar)
            {
                case 'A':
                        result += (long)(10 * Math.Pow(16, i));
                        break;
                case 'B':
                        result += (long)(11 * Math.Pow(16, i));
                        break;
                case 'C':
                        result += (long)(12 * Math.Pow(16, i));
                        break;
                case 'D':
                        result += (long)(13 * Math.Pow(16, i));
                        break;
                case 'E':
                        result += (long)(14 * Math.Pow(16, i));
                        break;
                case 'F':
                        result += (long)(15 * Math.Pow(16, i));
                        break;
                default:
                        result += Convert.ToInt64(Convert.ToString(newChar)) * (long)Math.Pow(16, i);
                    break;
            }

        }
        Console.WriteLine(result);
        //Console.WriteLine(Convert.ToInt64(hexValue, 16));

    }
}

