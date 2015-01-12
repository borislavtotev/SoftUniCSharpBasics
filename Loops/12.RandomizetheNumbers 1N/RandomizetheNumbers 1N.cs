using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RandomizetheNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Random rnd = new Random();

        int[] Values = new int[n];

        for (int i = 0; i < n; i++)
        {
            Values[i] = i+1;
        }

     
        for (int i = 0; i < n; i++)
        {
            int position = rnd.Next(0, Values.Length);
            Console.Write("{0} ",Values[position]);
            Values = RemoveAt(Values, position);
        } 
        Console.WriteLine();

    }
    public static int[] RemoveAt(int[] source, int index)
    {
        int[] dest = new int[source.Length - 1];
        if (index > 0)
            Array.Copy(source, 0, dest, 0, index);

        if (index < source.Length - 1)
            Array.Copy(source, index + 1, dest, index, source.Length - index - 1);

        return dest;
    }
}

