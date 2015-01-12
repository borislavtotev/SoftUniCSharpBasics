using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AverageLoadTimeCalculator
{
    static void Main(string[] args)
    {
        //string[] inputReport = new string[]{
        //    "2014-Mar-02 11:33 http://softuni.bg 8.37725",
        //    "2014-Mar-02 11:34 http://www.google.com 1.335",
        //    "2014-Mar-03 21:03 http://softuni.bg 7.25",
        //    "2014-Mar-03 22:00 http://www.google.com 2.44",
        //    "2014-Mar-03 22:01 http://www.google.com 2.45",
        //    "2014-Mar-03 22:01 http://www.google.com 2.77",
        //};

        string[] inputReport = new string[]{
            "2014-Apr-01 02:01 http://softuni.bg 8.37725",
            "2014-Apr-01 02:05 http://www.nakov.com 11.622",
            "2014-Apr-01 02:06 http://softuni.bg 4.33",
            "2014-Apr-01 02:11 http://www.google.com 1.94",
            "2014-Apr-01 02:11 http://www.google.com 2.011",
            "2014-Apr-01 02:12 http://www.google.com 4.882",
            "2014-Apr-01 02:34 http://softuni.bg 4.885",
            "2014-Apr-01 02:36 http://www.nakov.com 10.74", 
            "2014-Apr-01 02:36 http://www.nakov.com 11.75",
            "2014-Apr-01 02:38 http://softuni.bg 3.886",
            "2014-Apr-01 02:44 http://www.google.com 1.04",
            "2014-Apr-01 02:48 http://www.google.com 1.4555",
            "2014-Apr-01 02:55 http://www.google.com 1.977",
        };



        Dictionary<string, List<double>> LogDictionary = new Dictionary<string, List<double>>();

        foreach (var item in inputReport)
        {
            string[] rowElements = item.Split(' ');

            if (LogDictionary.ContainsKey(rowElements[2]))
            {
                LogDictionary[rowElements[2]].Add(Convert.ToDouble(rowElements[3]));
            }
            else
            {
                LogDictionary[rowElements[2]] = new List<double>();
                LogDictionary[rowElements[2]].Add(Convert.ToDouble(rowElements[3]));
            }
        }

        foreach (var item in LogDictionary.Keys)
        {
            double sum = 0;

            foreach (var listElement in LogDictionary[item])
            {
                sum += listElement;   
            }
            Console.WriteLine("{0} -> {1}",item,sum/LogDictionary[item].Count);
        }
    }
}

