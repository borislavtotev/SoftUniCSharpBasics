using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ZeroSubset
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please add 5 integer numbers split by space:");
        string Input = Console.ReadLine();
        string[] NumbersStr = Input.Split(' ');

        int foundStr = 0;

        //only one value
        if (Convert.ToInt32(NumbersStr[0]) == 0)
        {
            Console.WriteLine("{0} = 0", NumbersStr[0]);
            foundStr++;
        }

        if (Convert.ToInt32(NumbersStr[1]) == 0)
        {
            Console.WriteLine("{0} = 0", NumbersStr[1]);
            foundStr++;
        }
        
        if (Convert.ToInt32(NumbersStr[2]) == 0)
        {
            Console.WriteLine("{0} = 0", NumbersStr[2]);
            foundStr++;
        }

        if (Convert.ToInt32(NumbersStr[3]) == 0)
        {
            Console.WriteLine("{0} = 0", NumbersStr[3]);
            foundStr++;
        }

        if (Convert.ToInt32(NumbersStr[4]) == 0)
        {
            Console.WriteLine("{0} = 0", NumbersStr[4]);
            foundStr++;
        }

        //sum of two values
        if (Convert.ToInt32(NumbersStr[0]) + Convert.ToInt32(NumbersStr[1]) == 0)
        {
            Console.WriteLine("{0} + {1} = 0", NumbersStr[0], NumbersStr[1]);
            foundStr++;
        }

        if (Convert.ToInt32(NumbersStr[0]) + Convert.ToInt32(NumbersStr[2]) == 0)
        {
            Console.WriteLine("{0} + {1} = 0", NumbersStr[0], NumbersStr[2]);
            foundStr++;
        }
        
        if (Convert.ToInt32(NumbersStr[0]) + Convert.ToInt32(NumbersStr[3]) == 0)
        {
            Console.WriteLine("{0} + {1} = 0", NumbersStr[0], NumbersStr[3]);
            foundStr++;
        }

        if (Convert.ToInt32(NumbersStr[0]) + Convert.ToInt32(NumbersStr[4]) == 0)
        {
            Console.WriteLine("{0} + {1} = 0", NumbersStr[0], NumbersStr[4]);
            foundStr++;
        }

        if (Convert.ToInt32(NumbersStr[1]) + Convert.ToInt32(NumbersStr[2]) == 0)
        {
            Console.WriteLine("{0} + {1} = 0", NumbersStr[1], NumbersStr[2]);
            foundStr++;
        }

        if (Convert.ToInt32(NumbersStr[1]) + Convert.ToInt32(NumbersStr[3]) == 0)
        {
            Console.WriteLine("{0} + {1} = 0", NumbersStr[1], NumbersStr[3]);
            foundStr++;
        }

        if (Convert.ToInt32(NumbersStr[1]) + Convert.ToInt32(NumbersStr[4]) == 0)
        {
            Console.WriteLine("{0} + {1} = 0", NumbersStr[1], NumbersStr[4]);
            foundStr++;
        }

        if (Convert.ToInt32(NumbersStr[2]) + Convert.ToInt32(NumbersStr[3]) == 0)
        {
            Console.WriteLine("{0} + {1} = 0", NumbersStr[2], NumbersStr[3]);
            foundStr++;
        }

        if (Convert.ToInt32(NumbersStr[2]) + Convert.ToInt32(NumbersStr[4]) == 0)
        {
            Console.WriteLine("{0} + {1} = 0", NumbersStr[2], NumbersStr[4]);
            foundStr++;
        }

        if (Convert.ToInt32(NumbersStr[3]) + Convert.ToInt32(NumbersStr[4]) == 0)
        {
            Console.WriteLine("{0} + {1} = 0", NumbersStr[3], NumbersStr[4]);
            foundStr++;
        }

        //sum of 3 values
        if (Convert.ToInt32(NumbersStr[0]) + Convert.ToInt32(NumbersStr[1]) + Convert.ToInt32(NumbersStr[2]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", NumbersStr[0], NumbersStr[1], NumbersStr[2]);
            foundStr++;
        }

        if (Convert.ToInt32(NumbersStr[0]) + Convert.ToInt32(NumbersStr[1]) + Convert.ToInt32(NumbersStr[3]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", NumbersStr[0], NumbersStr[1], NumbersStr[3]);
            foundStr++;
        }

        if (Convert.ToInt32(NumbersStr[0]) + Convert.ToInt32(NumbersStr[1]) + Convert.ToInt32(NumbersStr[4]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", NumbersStr[0], NumbersStr[1], NumbersStr[4]);
            foundStr++;
        }

        if (Convert.ToInt32(NumbersStr[0]) + Convert.ToInt32(NumbersStr[2]) + Convert.ToInt32(NumbersStr[3]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", NumbersStr[0], NumbersStr[2], NumbersStr[3]);
            foundStr++;
        }

        if (Convert.ToInt32(NumbersStr[0]) + Convert.ToInt32(NumbersStr[2]) + Convert.ToInt32(NumbersStr[4]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", NumbersStr[0], NumbersStr[2], NumbersStr[4]);
            foundStr++;
        }

        if (Convert.ToInt32(NumbersStr[0]) + Convert.ToInt32(NumbersStr[3]) + Convert.ToInt32(NumbersStr[4]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", NumbersStr[0], NumbersStr[3], NumbersStr[4]);
            foundStr++;
        }

        if (Convert.ToInt32(NumbersStr[1]) + Convert.ToInt32(NumbersStr[2]) + Convert.ToInt32(NumbersStr[3]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", NumbersStr[1], NumbersStr[2], NumbersStr[3]);
            foundStr++;
        }

        if (Convert.ToInt32(NumbersStr[1]) + Convert.ToInt32(NumbersStr[2]) + Convert.ToInt32(NumbersStr[4]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", NumbersStr[1], NumbersStr[2], NumbersStr[4]);
            foundStr++;
        }

        if (Convert.ToInt32(NumbersStr[1]) + Convert.ToInt32(NumbersStr[3]) + Convert.ToInt32(NumbersStr[4]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", NumbersStr[1], NumbersStr[3], NumbersStr[4]);
            foundStr++;
        }

        if (Convert.ToInt32(NumbersStr[2]) + Convert.ToInt32(NumbersStr[3]) + Convert.ToInt32(NumbersStr[4]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", NumbersStr[2], NumbersStr[3], NumbersStr[4]);
            foundStr++;
        }

        //sum of 4 values
        if (Convert.ToInt32(NumbersStr[0]) + Convert.ToInt32(NumbersStr[1]) + Convert.ToInt32(NumbersStr[2]) + Convert.ToInt32(NumbersStr[3]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", NumbersStr[0], NumbersStr[1], NumbersStr[2], NumbersStr[3]);
            foundStr++;
        }

        if (Convert.ToInt32(NumbersStr[0]) + Convert.ToInt32(NumbersStr[1]) + Convert.ToInt32(NumbersStr[2]) + Convert.ToInt32(NumbersStr[4]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", NumbersStr[0], NumbersStr[1], NumbersStr[2], NumbersStr[4]);
            foundStr++;
        }

        if (Convert.ToInt32(NumbersStr[0]) + Convert.ToInt32(NumbersStr[1]) + Convert.ToInt32(NumbersStr[3]) + Convert.ToInt32(NumbersStr[4]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", NumbersStr[0], NumbersStr[1], NumbersStr[3], NumbersStr[4]);
            foundStr++;
        }

        if (Convert.ToInt32(NumbersStr[0]) + Convert.ToInt32(NumbersStr[2]) + Convert.ToInt32(NumbersStr[3]) + Convert.ToInt32(NumbersStr[4]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", NumbersStr[0], NumbersStr[2], NumbersStr[3], NumbersStr[4]);
            foundStr++;
        }

        if (Convert.ToInt32(NumbersStr[0]) + Convert.ToInt32(NumbersStr[1]) + Convert.ToInt32(NumbersStr[2]) + Convert.ToInt32(NumbersStr[3]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", NumbersStr[0], NumbersStr[1], NumbersStr[2], NumbersStr[3]);
            foundStr++;
        }

        //sum of 5 values
        if (Convert.ToInt32(NumbersStr[0]) + Convert.ToInt32(NumbersStr[1]) + Convert.ToInt32(NumbersStr[2]) + Convert.ToInt32(NumbersStr[3]) + Convert.ToInt32(NumbersStr[4]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", NumbersStr[0], NumbersStr[1], NumbersStr[2], NumbersStr[3], NumbersStr[4]);
            foundStr++;
        }

        if (foundStr == 0)
        {
            Console.WriteLine("no zero subset");
        }
    }


}

