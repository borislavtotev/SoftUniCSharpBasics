using System;

class EmployeeData
{
    static void Main(string[] args)
    {
        string FirstName = "Ivan";
        string SecondName = "Ivanov";
        byte Age = 28;
        char Gender = 'm';
        ulong PersonalId = 8306112507;
        uint EmploeeNumber = 27560001;

        Console.WriteLine("First Name:{0}",FirstName);
        Console.WriteLine("Second Name:{0}",SecondName);
        Console.WriteLine("Age:{0}",Age);
        Console.WriteLine("Gender:{0}",Gender);
        Console.WriteLine("Personal Id:" + PersonalId);
        Console.WriteLine("Unique Employee Number:" + EmploeeNumber);
    }
}
