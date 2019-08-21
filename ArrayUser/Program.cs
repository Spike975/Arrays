using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayUser
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[5];
            for (int i = 0; i < 5; i++) {
                int.TryParse(ask("Enter a number:"), out input[i]);
            }
            Console.WriteLine();
            for (int idx = input.Length-1; idx>=0;idx--)
            {
                Console.WriteLine(input[idx]);
            }
            Console.ReadLine();
        }
        static string ask(string str)
        {
            Console.WriteLine(str);
            return Console.ReadLine();
        }
    }
}
