using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DecimalToHexadecimalNumber
{
    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());

        long k = n;

        string result = "";

        while (k != 0)
        {
            long newValue = k % 16;

            switch (newValue)
            {
                case 10:
                    result = "A" + result;
                    break;
                case 11:
                    result = "B" + result;
                    break;
                case 12:
                    result = "C" + result;
                    break;
                case 13:
                    result = "D" + result;
                    break;
                case 14:
                    result = "E" + result;
                    break;
                case 15:
                    result = "F" + result;
                    break;
                default:
                    result = newValue + result;
                    break;
            }
            k = k / 16;            
        }
        Console.WriteLine(result);
        //Console.WriteLine(Convert.ToString(n,16));
    }
}

