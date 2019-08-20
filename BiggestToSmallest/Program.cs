using System;

namespace BiggestToSmallest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] val = new int[10];
            int high =99999999;
            for (int x = 0; x<val.Length; x++)
            {
                int.TryParse(ask("Enter a number:"), out val[x]);
            }
            Console.WriteLine("");
            foreach (int i in val)
            {
                int big=0;
                foreach(int k in val)
                {
                    if (k >= big&&k<high) { big =k; }
                }
                high = big;
                Console.WriteLine(big);
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
