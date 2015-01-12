using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ProgrammerDNA
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        char Alpha = char.Parse(Console.ReadLine());

        //Console.WriteLine("{0},{1}",N,(char)(Alpha+1));

        int NumberOfDots = 3;
        int ChangeSign = -1;
        char NewAlpha = Alpha; 

        for (int i = 0; i < N; i++)
        {
            if (i % 7 == 0)
            {
                NumberOfDots = 3;
            }

            Console.Write(new string('.',NumberOfDots));

            if ( (NumberOfDots == 0 && ChangeSign == -1 ) || (NumberOfDots == 3 && ChangeSign ==1) )
            {
                ChangeSign *= -1;
            }

            for (int j = 0; j < (7-2*NumberOfDots); j++)
            {
                Console.Write(NewAlpha);
                if (NewAlpha != 'G')
                {
                    NewAlpha = (char)(NewAlpha + 1);
                }
                else
                {
                    NewAlpha = 'A';
                }

            }
            
            Console.WriteLine(new string('.', NumberOfDots));
            NumberOfDots = NumberOfDots + ChangeSign;
        }
    }
}

