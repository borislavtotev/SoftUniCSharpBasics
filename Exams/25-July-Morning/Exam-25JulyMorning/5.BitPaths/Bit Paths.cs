using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BitPaths
{
    static void Main(string[] args)
    {
        int[,] Matrix = new int[8,4];

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Matrix[i, j] = 0;
            }
        }
        
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
		{
			string NewLine = Console.ReadLine();

            string[] NewLineNumbers = NewLine.Split(',');

            int changePosition = Convert.ToInt32(NewLineNumbers[0]);

            if (Matrix[0, changePosition] == 0)
            {
                Matrix[0, changePosition] = 1;    
            }
            else
            {
                Matrix[0, changePosition] = 0;
            }

            for (int j = 1; j < NewLineNumbers.Length; j++)
            {
                changePosition += Convert.ToInt32(NewLineNumbers[j]);
                if (Matrix[j, changePosition] == 1)
                {
                    Matrix[j, changePosition] = 0;
                }
                else
                {
                    Matrix[j, changePosition] = 1;   
                } 
            }
		}

        long sum = 0;

        for (int i = 0; i < 8; i++)
        {
            string row = Convert.ToString(Matrix[i, 0]) + Convert.ToString(Matrix[i, 1]) + Convert.ToString(Matrix[i, 2]) + Convert.ToString(Matrix[i, 3]);
            //Console.WriteLine(Convert.ToInt32(row,2));
            sum+=Convert.ToInt64(row,2);
            //for (int j = 0; j < 4; j++)
            //{
           //     Console.Write(Matrix[i,j]);
           // }
           // Console.WriteLine();
        }
        //Console.WriteLine(sum);
        Console.WriteLine(Convert.ToString(sum,2));
        Console.WriteLine(Convert.ToString(sum, 16).ToUpper());
    }
}

