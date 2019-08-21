using System;

namespace BiggestToSmallest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] val = new int[10];
            int high = 0;
            int small = 0;
            bool _h = true;
            bool _s = true;
            for (int x = 0; x < val.Length; x++)
            {
                int.TryParse(ask("Enter a number:"), out val[x]);
            }
            Console.WriteLine("");
            for(int i = 0; i < val.Length; i++)
            {
                if (val[i] > high || (high == 0&& _h)) { high = val[i]; _h = false; }
                if (val[i] < small || (small == 0&& _s)) { small = val[i]; _s = false; }
            }
            Console.WriteLine($"The highest number is: {high}");
            Console.WriteLine($"The smallest number is: {small}");
            Console.ReadLine();
        }
        static string ask(string str)
        {
            Console.WriteLine(str);
            return Console.ReadLine();
        }
    }
}
