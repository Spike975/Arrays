using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonFood
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] dragon = new double[3, 7];
            double ave = 0;
            double ave1 = 0;
            double ave2 = 0;
            double ave3 = 0;
            double least = 0;
            int leastDrag = 0;
            double most = 0;
            int mostDrag = 0;
            for (int i = 0; i < 3; i ++)
            {
                for (int x = 0; x < 7; x++)
                {
                    double.TryParse(ask($"Enter how much kilos dragon {i + 1} ate on day {x+1}:"), out dragon[i,x]);
                }
            }
            for (int i = 0; i<3; i++)
            {
                for(int x = 0; x<7; x++)
                {
                    ave +=dragon[1,x];

                    if ( i ==0) { ave1 += dragon[i, x]; }
                    if ( i ==1) { ave2 += dragon[i, x]; }
                    if ( i ==2) { ave3 += dragon[i, x]; }

                    if (dragon[i,x] > most) { most = dragon[i, x]; mostDrag = i+1; }
                    if (dragon[i,x] < least|| least == 0) { least = dragon[i, x]; leastDrag = i + 1; }
                }
            }
            ave /= dragon.Length;
            ave1 /= (dragon.Length/3);
            ave2 /= (dragon.Length/3);
            ave3 /= (dragon.Length/3);

            Console.WriteLine($"The average kilos all the dragons ate was {ave}!");
            Console.WriteLine($"The average kilos dragon 1 ate was {ave1}!");
            Console.WriteLine($"The average kilos dragon 2 ate was {ave2}!");
            Console.WriteLine($"The average kilos dragon 3 ate was {ave3}!");
            Console.WriteLine($"The dragon that ate the most was dragon {mostDrag} at {most}!");
            Console.WriteLine($"The dragon that ate the least was dragon {leastDrag} at {least}!");
            Console.ReadLine();
        }
        static string ask(string q)
        {
            Console.WriteLine(q);
            return Console.ReadLine();
        }
    }
}
