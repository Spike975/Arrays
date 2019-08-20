using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeByThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] val = new int[3, 3];
            int add=1;
            for(int i = 0; i <3;i++)
            {
                for (int x = 0;x < 3;x++)
                {
                    val[i, x] = add;
                    add++;
                }
            } 
            for (int i = 0;i < 3; i++) {
                for (int x = 0; x<3; x++)
                {
                    Console.Write(val[i,x]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
