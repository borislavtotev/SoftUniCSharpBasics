using System;

class MultiplicationSign
{
    static void Main(string[] args)
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        
        if (a != 0 && b !=0 && c != 0)
	    {
            if ((a>0 && b>0 && c>0) || (a > 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c < 0) || (a < 0 && b < 0 && c > 0))
            {
                Console.WriteLine("+");
            }
            else 
            {
                Console.WriteLine("-");
            }
	    }
        else
	    {
            Console.WriteLine(0);
	    }
    }
}

