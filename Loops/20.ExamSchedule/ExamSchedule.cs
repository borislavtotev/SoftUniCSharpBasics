using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


class ExamSchedule
{
    static void Main(string[] args)
    {
        string hour = Console.ReadLine();
        string minutes = Console.ReadLine();
        minutes = minutes.PadLeft(2,'0');
        string Part = Console.ReadLine();
        int durHour = int.Parse(Console.ReadLine());
        int durMin = int.Parse(Console.ReadLine());

        CultureInfo provider = CultureInfo.GetCultureInfo("en-US");
        //string format = "hh:mm tt";
        string format = CultureInfo.GetCultureInfo("en-US").DateTimeFormat.ShortTimePattern;
        string DateStr = String.Format("{0}:{1} {2}",hour,minutes,Part);
        //Console.WriteLine(DateStr);

        DateTime Date = DateTime.ParseExact(DateStr, format, provider);
        //Console.WriteLine(Date.ToString("hh:mm:tt"));

        Date = Date.AddHours(durHour);
        Date = Date.AddMinutes(durMin);
        Console.WriteLine(Date.ToString("hh:mm:tt"));
    }


}

