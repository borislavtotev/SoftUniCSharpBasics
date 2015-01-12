using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        string format = "h:mm tt";
        string dateString = "";
        CultureInfo provider = CultureInfo.GetCultureInfo("en");
        
        DateTime beartimestart = DateTime.ParseExact("1:00 PM", format, provider);
        DateTime beartimeend = DateTime.ParseExact("3:00 AM", format, provider);
        DateTime newtime;

        for (int i = 0; i < 7; i++)
        {

            try
            {
                dateString = Console.ReadLine();
                newtime = DateTime.ParseExact(dateString, format, provider);

                if (newtime >= beartimestart || newtime < beartimeend)
                {
                    Console.WriteLine("bear time");
                }
                else
                {
                    Console.WriteLine("non-bear time");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("invalid time", dateString);
            }
        }
    }
}

