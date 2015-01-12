using System;

class BankAccountData
{
    static void Main(string[] args)
    {
        string FirstName = "Ivan";
        string SecondName = "Petrov";
        string ThirdName = "Ivanov";
        decimal MoneyBalance = 13542351.54213M;
        string BankName = "Corporate Trade Bank";
        ulong CardNumber1 = 12345678910112314;
        ulong CardNumber2 = 12345378710112314;
        ulong CardNumber3 = 12325678410112314;

        Console.WriteLine("First Name:{0}", FirstName);
        Console.WriteLine("Second Name:{0}", SecondName);
        Console.WriteLine("Third Name:{0}", ThirdName);
        Console.WriteLine("Amount of Money:{0}", MoneyBalance.ToString("F2"));
        Console.WriteLine("Bank Name:{0}", BankName);
        Console.WriteLine("Card Numbers:{0},{1},{2}", CardNumber1, CardNumber2, CardNumber3);
    }
}

