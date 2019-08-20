using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] health = new int[] {100,100,100,100,100};
            int inpt=0;
            for (int i = 0; i <5;i++) {
                Random rand = new Random();
                while (inpt ==0) {
                    Console.WriteLine("You are going to be attacked.\nPlease chose a party member to attack back(1-5):");
                    int.TryParse(Console.ReadLine(), out inpt);
                }
                health[inpt-1] -= rand.Next(1,100);
                inpt = 0;
            }
            Console.WriteLine();
            for(int i = 0; i <5; i++)
            {
                Console.WriteLine($"Player {i+1} Health: {health[i]}");
            }
            Console.ReadLine();
        }
    }
}
