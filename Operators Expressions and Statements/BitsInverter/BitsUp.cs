using System;
using System.Text;


class BitsUp
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        int currentposition = 0;
        int lastchangeposition = 1;
        int[] NumberArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (i==0)
            {
                number = ChangeTo1(number, 1);    
            } 

            while ((lastchangeposition + step) < currentposition + 8)
            {
                number = ChangeTo1(number, lastchangeposition + step - i*8);
                lastchangeposition += step;
            }   
            currentposition += 8;

            //Console.WriteLine(Convert.ToString(number, 2).PadLeft(8, '0'));
            NumberArray[i] = number;
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(NumberArray[i]);
        }
    }
    private static int ChangeTo1 (int number, int position)
    {
        //Console.WriteLine(Convert.ToString(number,2).PadLeft(8,'0'));
        int DummyNumber = 1 << (8 - position -1);
        //Console.WriteLine(Convert.ToString(DummyNumber, 2).PadLeft(8, '0'));
        int NewNumber = DummyNumber | number;
        //Console.WriteLine(Convert.ToString(NewNumber, 2).PadLeft(8, '0'));       
        return NewNumber;
    }
}

