using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days2

{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] days = new int[29,5];
            int k = 0;
            for (int i =0; i <5; i++)
            {
                for(int x = 0; x < 29; x++)
                {
                    days[x, i] = (x + 1);
                }
            }
            for (int i = 0; i <5;i++)
            {
                int col = 0;
                for (int x = 0; x < 29; x++)
                {
                    if (i ==0){col += days[x,i];}
                    if (i ==1){col += days[x,i];}
                    if (i ==2){col += days[x,i];}
                    if (i ==3){col += days[x,i];}
                    if (i ==4){col += days[x,i];}
                }
                Console.WriteLine($"Total of column {i+1}: {col}");
                col = 0;
            }
            for (int i = 0; i < 29; i++)
            {
                int row = 0;
                for (int x = 0; x < 5; x++)
                {
                    if (i == k) { row += days[i, x]; }
                }
                k++;
                Console.WriteLine($"Total in row {i+1}: {row}");
            }
            Console.ReadLine();
        }
    }
}
