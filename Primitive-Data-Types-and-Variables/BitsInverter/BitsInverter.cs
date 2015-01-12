using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsInverter
{
    class BitsInverter
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());

            string WholeString = "";

            for (int i = 0; i < n; i++)
            {
                byte number = byte.Parse(Console.ReadLine());
                //Console.WriteLine(Convert.ToString(number,2));
                WholeString += Convert.ToString(number, 2).PadLeft(8, '0');
                //Console.WriteLine(WholeString);
            }

            StringBuilder sb = new StringBuilder(WholeString);

            for (int i = 0; i < WholeString.Length; i=i+step)
            {
                if (sb[i] == '0')
	            {
                    sb[i] = '1';
	            }
                else
                {
                    sb[i] = '0';
                }
                    
            }

            string NewWholeString = sb.ToString();
            //Console.WriteLine(NewWholeString);

            for (int i = 0; i < n; i++)
            {
                //Console.WriteLine(NewWholeString.Substring(i*8,8));
                int newbyte = Convert.ToInt32(NewWholeString.Substring(i*8, 8),2);
                Console.WriteLine(newbyte);
            }
        }
    }
}
