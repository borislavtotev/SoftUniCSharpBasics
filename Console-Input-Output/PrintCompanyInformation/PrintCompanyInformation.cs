using System;
using System.Text;

class PrintCompanyInformation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please write the neccesary information:");
        Console.Write("Company Name:");
        string CompanyName = Console.ReadLine();
        
        Console.Write("Company Address:");
        string CompanyAddress = Console.ReadLine();

        Console.Write("Phone Number:");
        string PhoneNumber = Console.ReadLine();

        Console.Write("Fax Number:");
        string FaxNumber = Console.ReadLine();

        Console.Write("Web site:");
        string WebSite = Console.ReadLine();
        
        Console.Write("Manager First Name:");
        string ManagerFirstName = Console.ReadLine();

        Console.Write("Manager Last Name:");
        string ManagerLastName = Console.ReadLine();

        Console.Write("Manager Age:");
        string ManagerAge= Console.ReadLine();

        Console.Write("Manager Phone Number:");
        string ManagerPhoneNumber = Console.ReadLine();
        Console.WriteLine();

        Console.Write("{0,20}{1,20}|","program","");
        Console.WriteLine("{0,15}{1,15}|","user","");
        Console.WriteLine("{0,-40}|{1,-30}|", "Company Name:", CompanyName);
        Console.WriteLine("{0,-40}|{1,-30}|", "Company Address:", CompanyAddress);
        Console.WriteLine("{0,-40}|{1,-30}|", "Phone Number:", PhoneNumber);
        Console.WriteLine("{0,-40}|{1,-30}|", "Fax Number:", FaxNumber);
        Console.WriteLine("{0,-40}|{1,-30}|", "Web site:", WebSite);
        Console.WriteLine("{0,-40}|{1,-30}|", "Manager First Name:", ManagerFirstName);
        Console.WriteLine("{0,-40}|{1,-30}|", "Manager Last Name:", ManagerLastName);
        Console.WriteLine("{0,-40}|{1,-30}|", "Manager Age:", ManagerAge);
        Console.WriteLine("{0,-40}|{1,-30}|", "Manager Phone Number:", ManagerPhoneNumber);

    }
}

