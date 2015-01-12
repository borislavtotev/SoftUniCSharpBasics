using System;

class SumOf5Numbers
{
    static void Main(string[] args)
    {
        double sum = new double();
        int i = new int();
        string str = null;
        while (i != 13)
        {
            i = Console.Read();
            char ch = (char)(i);

            if (i != 32 && i != 13)
            {
                str += Convert.ToString(ch);
            }
            else
            {
                sum += Convert.ToDouble(str);
                str = null;
            }
        }
        Console.WriteLine(sum);


    }
}

