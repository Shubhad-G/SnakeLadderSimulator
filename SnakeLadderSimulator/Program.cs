using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake Ladder Single Player Game");
            Random random = new Random();
            int playerPosition = 0;

            Console.WriteLine("initialized the player position to {0}", playerPosition);
            Console.WriteLine("Rolling the dice");

            int diceRoll = random.Next(1, 7);
            Console.WriteLine("\nDice Number: {0}",diceRoll);
            playerPosition+=diceRoll;
            Console.WriteLine("\nPlayer position: {0}",playerPosition);
            Console.ReadLine();
        }
    }
}
