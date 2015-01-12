using System;

class Voleyball
{
    static void Main(string[] args)
    {
        string YearType = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());

        decimal PlaysInHolidays = 2/3M*p;
        //Console.WriteLine("playsinholidays" + PlaysInHolidays) ;
        decimal PlaysInHometown = h;
        //Console.WriteLine(h);
        decimal PlaysInNormalWeekends = 3/4M * (48 - h);
        //Console.WriteLine(PlaysInNormalWeekends);
        decimal TotalPlays = (PlaysInHolidays + PlaysInHometown + PlaysInNormalWeekends);
        if (YearType=="leap")
        {
            TotalPlays *= 1.15M;
        }

        Console.WriteLine((int)TotalPlays);
    }
}

