using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CheckTheBits
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        List<String> list = new List<String>();

        int CurrentPosition = 1;
        int BitCounter = 0;
        string ByteString = "";

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(number,2).PadLeft(8,'0'));

            while (CurrentPosition <= 7+8*i)
            {
                ByteString += GetBitValue(number, CurrentPosition - 8 * i);
                //Console.WriteLine(ByteString);
                
                BitCounter++;
                //Console.WriteLine(BitCounter);
                if (BitCounter % 8 == 0)
                {
                    //Result = new string[BitCounter / 8 - 1];
                    list.Add(ByteString);
                    //Console.WriteLine(BitCounter / 8 - 1);
                    //Console.WriteLine(Result[BitCounter / 8 - 1]);
                    ByteString = "";
                }

                CurrentPosition += step;
            }   
        }
        
        if (ByteString != "")
        {
            list.Add(ByteString.PadRight(8, '0'));
            //Console.WriteLine(Result[BitCounter / 8]);
        }

        string[] Result = list.ToArray();
        
        for (int i = 0; i < Result.Length; i++)
        {
            Console.WriteLine(Convert.ToInt32(Result[i], 2));                
        }
    }
    private static string GetBitValue(int Number, int Position)
    {
        int DummyNumber = Number >> (7 - Position);
        string BitValue = Convert.ToString(1 & DummyNumber);
        //Console.WriteLine(BitValue);
        return BitValue;
    }
}

