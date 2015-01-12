using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BitRoller
{
    static void Main(string[] args)
    {
        uint n = uint.Parse(Console.ReadLine());
        uint f = uint.Parse(Console.ReadLine());
        uint r = uint.Parse(Console.ReadLine());

        string BitValue = Convert.ToString(n, 2).PadLeft(19, '0');
        //Console.WriteLine(BitValue);

        char[] Bits = BitValue.ToArray();

        for (int i = 0; i < r; i++)
        {
            Bits = Roller(Bits, f, r);
        }

        string result = "";

        for (int i = 0; i < Bits.Length; i++)
        {
            result += Bits[i];
        }

        Console.WriteLine(Convert.ToUInt64(result,2));

    }
    private static char[] Roller (char[] Bits, uint f, uint r)
    {
        char[] NewBits = new char[Bits.Length];

        for (int k = 0; k < r; k++)
        {
            for (int i = 0; i <= (Bits.Length - 1); i++)
            {
                if ((Bits.Length - 1 - i) == f)
                {
                    NewBits[i] = Bits[i];
                }
                else if (i == Bits.Length - 1)
                {
                    if (f == 18)
                    {
                      NewBits[1] = Bits[i];  
                    }
                    else
                    {
                      NewBits[0] = Bits[i];     
                    } 
                }
                else
                {
                    if ((Bits.Length - 1 - i) == f + 1)
                    {
                        if (f == 0)
                        {
                            NewBits[0] = Bits[i];
                        }
                        else
                        {
                            NewBits[i + 2] = Bits[i];
                        }
                    }
                    else
                    {
                        NewBits[i + 1] = Bits[i];
                    }
                }
            }
        }

        //for (int i = 0; i < NewBits.Length; i++)
        //{
            //Console.Write(NewBits[i]);
        //}
        //Console.WriteLine();
        return NewBits;

    }
}

