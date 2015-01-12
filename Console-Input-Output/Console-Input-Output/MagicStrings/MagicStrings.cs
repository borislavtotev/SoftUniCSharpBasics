using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MagicStrings
{
    static void Main(string[] args)
    {
        int diff = int.Parse(Console.ReadLine());
        int[] ArrayNumber = new int[] {1,3,4,5};

        int MinValue = 4 * 1;
        int MaxValue = 4 * 5;
        int MaxDiff = MaxValue - MinValue;
        int MaxValueFirstFour = MaxValue - diff;

        string[] Results = new string[100000];
        int results_index = 0;

        if (diff > MaxDiff)
        {
            Console.WriteLine("No");
        }
        else 
        {
            for (int i = 0; i < ArrayNumber.Length; i++)
            {
                int a = ArrayNumber[i];

                if (a < MaxValueFirstFour)
                {
                    for (int i1 = 0; i1 < ArrayNumber.Length; i1++)
                    {
                        int b = ArrayNumber[i1];

                        if (a+b < MaxValueFirstFour)
                        {
                            for (int i2 = 0; i2 < ArrayNumber.Length; i2++)
                            {
                                int c = ArrayNumber[i2];

                                if (a+b+c < MaxValueFirstFour)
                                {
                                    for (int i3 = 0; i3 < ArrayNumber.Length; i3++)
                                    {
                                        int d = ArrayNumber[i3];

                                        if (a+b+c+d <= MaxValueFirstFour)
                                        {
                                            //Console.WriteLine("{0} {1} {2} {3} |", a, b, c, d);
                                           // -----------------------------------------------------
                                           // -----------------------------------------------------
                                            for (int i4 = 0; i4 < ArrayNumber.Length; i4++)
                                            {
                                                int a2 = ArrayNumber[i4];

                                                if (a2 < (a+b+c+d+diff))
                                                {
                                                    for (int i5 = 0; i5 < ArrayNumber.Length; i5++)
                                                    {
                                                        int b2 = ArrayNumber[i5];

                                                        if ((a2 + b2) < (a + b + c + d + diff))
                                                        {
                                                            for (int i6 = 0; i6 < ArrayNumber.Length; i6++)
                                                            {
                                                                int c2 = ArrayNumber[i6];

                                                                if ((a2 + b2 + c2) < (a + b + c + d + diff))
                                                                {
                                                                    for (int i7 = 0; i7 < ArrayNumber.Length; i7++)
                                                                    {
                                                                        int d2 = ArrayNumber[i7];

                                                                        if ((a2 + b2 + c2 + d2) == (a + b + c + d + diff))
                                                                        {
                                                                            //Console.Write("{0} {1} {2} {3} |", a, b, c, d);
                                                                            //Console.WriteLine("{0} {1} {2} {3}", a2, b2, c2, d2);
                                                                            //Console.WriteLine(ConvertValuesToString(a, b, c, d, a2, b2, c2, d2));
                                                                            Results[results_index] = ConvertValuesToString(a, b, c, d, a2, b2, c2, d2);
                                                                            results_index++;

                                                                            //Console.Write("{0} {1} {2} {3} |", a2, b2, c2, d2);
                                                                            //Console.WriteLine("{0} {1} {2} {3}", a, b, c, d);
                                                                            //Console.WriteLine(ConvertValuesToString(a2, b2, c2, d2, a, b, c, d));
                                                                            if (ConvertValuesToString(a2, b2, c2, d2, a, b, c, d) != ConvertValuesToString(a, b, c, d, a2, b2, c2, d2))
                                                                            {
                                                                                Results[results_index] = ConvertValuesToString(a2, b2, c2, d2, a, b, c, d);
                                                                                results_index++; 
                                                                            }
                                                                            else
                                                                            {
                                                                                //Console.WriteLine(ConvertValuesToString(a2, b2, c2, d2, a, b, c, d));
                                                                                //Console.ReadKey();
                                                                            }

                                                                        }
                                                                        

                                                                    }
                                                                }

                                                            }
                                                        }
                                                    }

                                                }
                                            }
                                        }

                                    }
                                }

                            }
                        }
                    }

                }
            }
        }

        //Console.WriteLine("Results");
        Array.Sort(Results);
        string[] NewResults = Results.Distinct().ToArray();

        for (int index = 0; index < NewResults.Length; index++)
        {
            if (NewResults[index] != null)
            {
                Console.WriteLine(NewResults[index]);
            }
            else
            {
               // break;
            }

        }
    }
    private static string ConvertValuesToString (int a, int b, int c, int d, int a2, int b2, int c2, int d2) 
    {
        return Alfabetic(a) + Alfabetic(b) + Alfabetic(c) + Alfabetic(d) + Alfabetic(a2) + Alfabetic(b2) + Alfabetic(c2) + Alfabetic(d2);
    }
    private static string Alfabetic (int number)
    {
        if (number == 3)
        {
            return "s";
        }
        else if (number == 4)
        {
            return "n";
        }
        else if (number == 1)
        {
            return "k";
        }
        else
        {
            return "p";
        }
    }
}

