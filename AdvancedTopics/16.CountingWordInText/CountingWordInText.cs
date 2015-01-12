using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


    class CountingWordInText
    {
        static void Main(string[] args)
        {
            string phrase = Console.ReadLine();
            string input = Console.ReadLine();
            
            MatchCollection NewMatches = Regex.Matches(input, "[^a-zA-Z0-9]" + phrase + "[^a-zA-Z0-9]",RegexOptions.IgnoreCase); //between other non alpha and num chars
            MatchCollection NewMatches1 = Regex.Matches(input, "^" + phrase + "[^a-zA-Z0-9]", RegexOptions.IgnoreCase); //in tge begining
            MatchCollection NewMatches2 = Regex.Matches(input, "[^a-zA-Z0-9]" + phrase + "$", RegexOptions.IgnoreCase); //in the end
            Console.WriteLine(NewMatches.Count+NewMatches1.Count+NewMatches2.Count);
        }
    }

