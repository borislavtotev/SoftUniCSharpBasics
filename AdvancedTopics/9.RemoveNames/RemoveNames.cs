using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RemoveNames
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string removeFromInput = Console.ReadLine();

        string[] namesStr = input.Split(' ');
        string[] removeNames = removeFromInput.Split(' ');

        foreach (var name in namesStr)
        {
            Boolean forRemoved = false;
            foreach (var removeName in removeNames)
            {
                if (name == removeName)
                {
                    forRemoved = true;
                    break;
                }
            }
            if (! forRemoved)
            {
                Console.Write(name + " ");
            }
        }
    }
}

