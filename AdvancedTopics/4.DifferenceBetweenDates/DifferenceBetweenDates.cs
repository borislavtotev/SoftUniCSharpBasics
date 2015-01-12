using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


class DifferenceBetweenDates
{
    static void Main(string[] args)
    {
        string firstDateStr = Console.ReadLine();
        string secondDateStr = Console.ReadLine();
        string format = "d.MM.yyyy";

        CultureInfo provider = CultureInfo.GetCultureInfo("en-US");

        DateTime firstDate = DateTime.ParseExact(firstDateStr, format, provider);
        DateTime secondDate = DateTime.ParseExact(secondDateStr, format, provider);
        //Console.WriteLine(firstDate);
        //Console.WriteLine(secondDate);
        Console.WriteLine("{0}",(secondDate-firstDate).TotalDays); 

    }
}

