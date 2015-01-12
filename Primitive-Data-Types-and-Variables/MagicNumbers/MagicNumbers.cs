using System;
using System.Text;

class MagicNumbers
{
    static void Main(string[] args)
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());

        Boolean FoundNumber = false;

        for (int a = 1; a < 8; a++)
        {
            for (int b = 1; b < 8; b++)
            {
                for (int c = 1; c < 8; c++)
                {
                    string abc = a.ToString() + b.ToString() + c.ToString();
                    int def = int.Parse(abc) + diff;
                    int ghi = def + diff;

                    Boolean BigValue = false;

                    if (ghi > 777)
                    {
                        BigValue = true;
                        continue;
                    }
                    string Value = abc + def.ToString() + ghi.ToString();


                    int NewSum = 0;
                    for (int index = 0; index < 9; index++)
                    {
                        if ((int.Parse(Value.Substring(index, 1)) > 7) || (int.Parse(Value.Substring(index, 1)) == 0))
                        {
                            BigValue = true;
                            continue;
                        }
                        else
                        {
                            NewSum += int.Parse(Value.Substring(index, 1));
                        }
                    }

                    if (!BigValue)
                    {
                        if (sum == NewSum)
                        {
                            Console.WriteLine(Value);
                            FoundNumber = true;
                        }

                    }
                }
            }
        }

        if (!FoundNumber)
        {
            Console.WriteLine("No");
        }
    }
}

