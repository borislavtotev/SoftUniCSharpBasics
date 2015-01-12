using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FiveSpecialLetters
{
    static void Main(string[] args)
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        char[] TypeOfLetters = new char[] { 'a', 'b', 'c', 'd', 'e' };

        int foundLetters = 0;

        foreach (var Letter1 in TypeOfLetters)
        {
            foreach (var Letter2 in TypeOfLetters)
            {
                foreach (var Letter3 in TypeOfLetters)
                {
                    foreach (var Letter4 in TypeOfLetters)
                    {
                        foreach (var Letter5 in TypeOfLetters)
                        {
                            char[] NewCombinationArray = new char[] { Letter1, Letter2, Letter3, Letter4, Letter5 };
                            long NewWeight = Weight(NewCombinationArray);

                            if (NewWeight >= start && NewWeight <= end)
                            {
                                if (foundLetters > 0)
                                {
                                    Console.Write(" " + Letter1.ToString() + Letter2.ToString() + Letter3.ToString() + Letter4.ToString() + Letter5.ToString());
                                }
                                else
                                {
                                    Console.Write(Letter1.ToString() + Letter2.ToString() + Letter3.ToString() + Letter4.ToString() + Letter5.ToString());
                                }
                                foundLetters++;
                            }
                        }
                    }
                }
            }
        }

        if (foundLetters == 0)
        {
            Console.Write("No");
        }
    }
    private static long Weight(char[] Letters)
    {
        int i = 1;
        List<Char> NewLetters = new List<Char>();
        long weigth = 0;

        for (int j = 0; j < Letters.Length; j++)
			{
                char NewStr = Letters[j];

                if (! NewLetters.Contains(NewStr))
                {
                    NewLetters.Add(NewStr);
                    int newWeigth = 0;
                    switch (NewStr)
                    {
                        case 'a': newWeigth = 5; break;
                        case 'b': newWeigth = -12; break;
                        case 'c': newWeigth = 47; break;
                        case 'd': newWeigth = 7; break;
                        default:
                            newWeigth = -32;
                            break;
                    }

                    weigth += i * newWeigth;
                    i++;
                }
			}
        //Console.WriteLine("Weigth:" + weigth);
        return weigth;
    }
}

