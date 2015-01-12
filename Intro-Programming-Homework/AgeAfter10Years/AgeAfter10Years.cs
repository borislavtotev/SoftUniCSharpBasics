using System;

class AgeAfter10Years
{
    static void Main(string[] args)
    {
        DateTime now = DateTime.Now;
        Console.WriteLine("Now is: " + now);
        Console.WriteLine("Plese write down your bith date?");
        Console.WriteLine("(Please use the same date format as the current date format listed above)");
        
        string birth = Console.ReadLine();
        DateTime birthdate = DateTime.Parse(birth);
        
        int age = now.Year - birthdate.Year;
        if (now.Month < birthdate.Month || (now.Month == birthdate.Month && now.Day < birthdate.Day))
        {
            age--;       
        } 
        
        Console.WriteLine("Now you are " + age + " years old");
        int newage = age + 10;
        Console.WriteLine("After 10 years you will be " + newage + " years old");
    }
}

