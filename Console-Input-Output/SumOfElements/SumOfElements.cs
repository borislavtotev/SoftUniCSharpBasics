using System;
using System.Text;

class SumOfElements
{
    static void Main(string[] args)
    {
        int chNumber = new int();
        char ch = new char();
        string NewStr = "";
        int[] AllValues = new int[1001];
        int i = 0;
        int BiggestValue = 0;
        long SumOfAllOthers = 0;

        while (chNumber != 13)
        {
            chNumber = Console.Read();
            ch = (char)chNumber;

            if (chNumber != 32 && chNumber != 13)
            {
                NewStr += Convert.ToString(ch); 
            }
            else 
            {
                if (NewStr != "")
                {
                    AllValues[i] = Convert.ToInt32(NewStr);
                    //Console.WriteLine(NewStr);
                    NewStr = "";

                    if (AllValues[i] > BiggestValue)
                    {
                        SumOfAllOthers += BiggestValue;
                        //Console.WriteLine("sum=" + SumOfAllOthers);
                        BiggestValue = AllValues[i];
                    }
                    else
                    {
                        SumOfAllOthers += AllValues[i];
                        //Console.WriteLine("sum=" + SumOfAllOthers);
                    }

                    i++;
                }
            }           
        }

        //Console.WriteLine(SumOfAllOthers);
        if (BiggestValue == SumOfAllOthers)
        {
            Console.WriteLine("Yes, sum={0}",BiggestValue);
        }
        else
        {
            long Mindiff = Convert.ToInt64(Math.Abs(BiggestValue - SumOfAllOthers));

            for (int i1 = 0; i1 < AllValues.Length; i1++)
            {
                if (Mindiff > Math.Abs(AllValues[i1] - SumOfAllOthers - BiggestValue + AllValues[i1]))
                {
                    Mindiff = Math.Abs(AllValues[i1] - SumOfAllOthers - BiggestValue + AllValues[i1]);
                    Console.WriteLine(Mindiff);
                }   
            }

            //Console.WriteLine("total={0}", SumOfAllOthers + BiggestValue);
            Console.WriteLine("No, diff={0}",Mindiff);
        }

    }
}

