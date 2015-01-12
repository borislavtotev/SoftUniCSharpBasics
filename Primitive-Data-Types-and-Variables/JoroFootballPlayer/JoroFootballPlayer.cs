using System;

class JoroFootballPlayer
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Please write t for leap year and f for year that is not leap:");
        char LeapYear = char.Parse(Console.ReadLine());
        
        int PlaysInLeapYear = 0;
        if (LeapYear == 't')
        {
            PlaysInLeapYear = 3;
        }

        //Console.WriteLine("Please write number of holidays in the year which are not Saturday:");
        int Holidays = int.Parse(Console.ReadLine());

        float PlaysInHolidays = Holidays / 2;

        //Console.WriteLine("Please write number of weekends which Joro spend in his hometown:");
        int PlaysInHometown = int.Parse(Console.ReadLine());

        float PlaysInNormalWeekends = (52 - PlaysInHometown) * 2 / 3;

        int TotalPlays = (int)(PlaysInLeapYear + PlaysInHolidays + PlaysInHometown + PlaysInNormalWeekends);

        Console.WriteLine(TotalPlays);

    }
}

