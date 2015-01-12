using System;

class DevideBy7AndBy5
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please add a number:");
        int n = int.Parse(Console.ReadLine());
        Boolean Devided = ((n % 7 == 0) && (n % 5 == 0) && (n!=0)) ? true : false;
        Console.WriteLine("Your number can be devided by 7 and 5:" + Devided);
    }
}

