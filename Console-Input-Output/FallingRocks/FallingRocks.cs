using System;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;

class FallingRocks
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.SetWindowSize(70, 20);
        string[] ArrayStr = new string[] {
            "|" + "^".PadLeft(10, ' ').PadRight(52, ' ') + "@".PadRight(13, ' ') + "|",
            "|" + "*".PadLeft(20, ' ').PadRight(40, ' ') + "*".PadRight(25, ' ') + "|",
            "|" + "&".PadLeft(10, ' ').PadRight(25, ' ') + "+".PadRight(22, ' ') + "%".PadRight(13,' ') + "$".PadRight(5,' ') + "|",
            "|" + "+".PadLeft(5, ' ').PadRight(55, ' ') + ".".PadRight(10, ' ') + "|",
            "|" + "+++".PadLeft(20, ' ').PadRight(33, ' ') + "#".PadRight(25, ' ') + "!".PadRight(7, ' ') + "|",
            "|" + "+".PadLeft(22, ' ').PadRight(37, ' ') + ";".PadRight(23, ' ') + "*".PadRight(5, ' ') + "|",
            "|" + "*".PadLeft(17, ' ').PadRight(65, ' ') + "|",
            "|" + ".".PadLeft(3, ' ').PadRight(28, ' ') + "++".PadRight(37, ' ') + "|",
            "|" + "*".PadLeft(45, ' ').PadRight(65, ' ') + "|",
            "|" + ".".PadLeft(23, ' ').PadRight(42, ' ') + "--".PadRight(23, ' ') + "|",
            "|" + ";".PadLeft(2, ' ').PadRight(14, ' ') + ".".PadRight(41, ' ') + "@".PadRight(10, ' ') + "|",
        };

        string[] NewArrayStr = new string[ArrayStr.Length];
        int CurrentPosition = 33;
        string LastRow = "";
        bool Die = false;
        int Score = 0;

        while (!Die)
        {
            Console.Clear();
            Console.WriteLine("Score:"+Score);

            if (ArrayStr[ArrayStr.Length - 1].Substring(CurrentPosition-1,3) == "   ")
            {

                LastRow = ArrayStr[ArrayStr.Length - 1].Substring(0, CurrentPosition - 1) + "(0)" + ArrayStr[ArrayStr.Length - 1].Substring(CurrentPosition + 2, ArrayStr[ArrayStr.Length - 1].Length - 1 - CurrentPosition - 1);
                
                for (int i = 0; i < ArrayStr.Length; i++)
                {

                    if (i + 1 < ArrayStr.Length)
                    {
                        NewArrayStr[i + 1] = ArrayStr[i];
                        Console.WriteLine(ArrayStr[i]);
                    }
                    else
                    {
                        NewArrayStr[0] = ArrayStr[i];
                        Console.WriteLine(LastRow);
                    }
                }
                NewArrayStr.CopyTo(ArrayStr, 0);

                DateTime timeoutvalue = DateTime.Now.AddSeconds(0.5);

                while (DateTime.Now < timeoutvalue)
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo cki = Console.ReadKey(false);
                        if (cki.Key.ToString() == "LeftArrow")
                        {
                            CurrentPosition--;
                        }
                        else if (cki.Key.ToString() == "RightArrow")
                        {
                            CurrentPosition++;
                        }
                    }
                    else
                    {
                        Thread.Sleep(1);
                    }
                }
                Score++;
            }
            else
            {
                Console.WriteLine("You die! Your score is:{0}",Score);
                Die = true;
            }

        }

    }
}

