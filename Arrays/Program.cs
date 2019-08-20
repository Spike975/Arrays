using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = 0;
            int[] decend = new int[10];
            for (int idx = decend.Length; idx>0;idx--)
            {
                decend[numb] = idx;
                numb++;
            }
            foreach (int idx in decend)
            {
                Console.WriteLine(idx);
            }
            Console.ReadLine();
        }
    }
}
