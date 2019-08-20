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
            int.TryParse(ask("Please enter a number:"),out input[0]);
            int.TryParse(ask("Please enter another number:"),out input[1]);
            int.TryParse(ask("Please enter another number:"),out input[2]);
            int.TryParse(ask("Please enter another number:"),out input[3]);
            int.TryParse(ask("Please enter another number:"),out input[4]);

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
