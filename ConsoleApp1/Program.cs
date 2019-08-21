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
            int _rand = 0;
            for (int i = 0; i <5;i++) {
                Random rand = new Random();
                while (inpt ==0) {
                    Console.WriteLine("You are going to be attacked.\nPlease chose a party member to attack back(1-5):");
                    int.TryParse(Console.ReadLine(), out inpt);
                    if (health[inpt -1] <=0)
                    {
                        Console.WriteLine($"Player {inpt} is dead.");
                        inpt = 0;
                    }
                }
                _rand = rand.Next(1, 150);
                Console.WriteLine($"{ _rand} Damage to player {inpt}");
                health[inpt-1] -= _rand;
                inpt = 0;
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                if (health[i] >0) { Console.WriteLine($"Player {i + 1} Health: {health[i]}"); }
                else { Console.WriteLine($"Player {i + 1} is dead!"); }
            }
            Console.ReadLine();
        }
    }
}
