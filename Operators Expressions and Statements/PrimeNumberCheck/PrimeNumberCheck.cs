using System;

class PrimeNumberCheck
{
    static void Main(string[] args)
    {
        Console.Write("n:");
        int n = int.Parse(Console.ReadLine());

        Boolean Devided = (n<=1) ? false : true;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                Devided = false;
                break;
            }
        }
        Console.WriteLine(Devided);            
    }
}

