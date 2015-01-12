using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


class MagicDates
{
    static void Main(string[] args)
    {
        CultureInfo provider = CultureInfo.GetCultureInfo("en-US");
        string format = CultureInfo.GetCultureInfo("en-US").DateTimeFormat.ShortDatePattern;

        int BeginYear = int.Parse(Console.ReadLine());
        DateTime BeginTime = DateTime.ParseExact("01/01/" + BeginYear, format, provider);
        //Console.WriteLine(BeginTime.ToString(format));

        int EndYear = int.Parse(Console.ReadLine());
        DateTime EndTime = DateTime.ParseExact("12/31/" + EndYear, format, provider);
        //Console.WriteLine(EndTime.ToString(format));
        //Console.WriteLine(EndTime.ToString());


        int magicWeight = int.Parse(Console.ReadLine());

        DateTime NewTime=BeginTime;
        string Newformat = "dd-MM-yyyy";

        int foundMagicDates = 0;

        while (NewTime <= EndTime)
        {
            //Console.WriteLine(NewTime.ToString(Newformat));
            if (CheckWeight(NewTime.ToString(Newformat), magicWeight, foundMagicDates) > foundMagicDates)
            {
                Console.WriteLine(NewTime.ToString(Newformat));
            }
            foundMagicDates = CheckWeight(NewTime.ToString(Newformat), magicWeight, foundMagicDates);
            NewTime = NewTime.AddDays(1);
        }

        if (foundMagicDates == 0)
        {
            Console.WriteLine("No");
        }
    }

    private static int CheckWeight(string DateString, int DateWeight, int foundDates)
    {
        int[] Values = new int[8];
        int numberOfValues = 0;

        for (int i = 0; i < DateString.Length; i++)
        {
            //Console.WriteLine(DateString.Substring(i, 1));
            if (DateString.Substring(i,1) != "-")
            {
                Values[numberOfValues] = Convert.ToInt32(DateString.Substring(i, 1));
                numberOfValues++;
            }
        }


        int sum = Values[0] * Values[1] + Values[0] * Values[2] + Values[0] * Values[3] + Values[0] * Values[4] + Values[0] * Values[5] + Values[0] * Values[6] + Values[0] * Values[7] + Values[1] * Values[2] + Values[1] * Values[3] + Values[1] * Values[4] + Values[1] * Values[5] + Values[1] * Values[6] + Values[1] * Values[7] + Values[2] * Values[3] + Values[2] * Values[4] + Values[2] * Values[5] + Values[2] * Values[6] + Values[2] * Values[7] + Values[3] * Values[4] + Values[3] * Values[5] + Values[3] * Values[6] + Values[3] * Values[7] + Values[4] * Values[5] + Values[4] * Values[6] + Values[4] * Values[7] + Values[5] * Values[6] + Values[5] * Values[7] + Values[6] * Values[7];
        //Console.WriteLine(sum);

        if (sum == DateWeight)
        {
            return foundDates + 1;
        }
        else
        {
            return foundDates;
        }
    }
}

