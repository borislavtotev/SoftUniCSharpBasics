using System;

class CheckForAPlayCard
{
    static void Main(string[] args)
    {
        string[] Card = new string [13]{"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};

        string NewCard = Console.ReadLine();

        if (Array.IndexOf(Card,NewCard) == -1) 
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine("Yes");
        }
    }
}

