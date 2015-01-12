using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PlayWithIntDoubleString
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please choose a type:\n\r1 --> int\n\r2 --> double\n\r3 --> string");
        int type = int.Parse(Console.ReadLine());


        switch (type)
        {
            case 1:
                Console.Write("Please Enter a integer:");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(number + 1);
                break;
            case 2:
                Console.Write("Please Enter a double:");
                double doublenumber = double.Parse(Console.ReadLine());
                Console.WriteLine(doublenumber + 1);
                break;
            default:
                Console.Write("Please Enter a string:");
                string NewStr = Console.ReadLine();
                Console.WriteLine(NewStr + "*");
                break;
        }
    }
}

