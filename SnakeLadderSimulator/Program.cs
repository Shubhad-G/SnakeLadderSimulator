using System;
using System.Collections.Generic;
using System.ComponentModel;
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

            while (playerPosition <= 100)
            {
               
                int diceRoll = random.Next(1, 7);
                Console.WriteLine("\nDice Number: {0}\n", diceRoll);
                int option = random.Next(1, 4);
                switch (option)
                {
                    case 1:
                        if (playerPosition >= 100)
                        {
                            if (playerPosition > 100)
                            {
                                playerPosition = playerPosition - diceRoll;
                                Console.WriteLine("\nNoplay\nplayer position : {0}", playerPosition);
                            }
                            else
                                Console.WriteLine("Ladder\nplayer has won: {0}", playerPosition);
                        }
                        else
                        Console.WriteLine("No play\nplayer position: {0}", playerPosition);
                        break;

                    case 2:
                        Console.WriteLine("\nLadder\nplayer position: {0}", playerPosition);
                        int previousPosition=playerPosition;
                        playerPosition += diceRoll;
                        if (playerPosition >= 100)
                        {
                            if (playerPosition > 100)
                            {
                                playerPosition = previousPosition;
                                Console.WriteLine("\nNoplay\nplayer position : {0}", playerPosition);
                            }
                            else
                            {
                                Console.WriteLine("Ladder\nplayer has won: {0}", playerPosition);
                                playerPosition += playerPosition;
                            }
                        }
                        else
                            Console.WriteLine("\nLadder\nplayer position: {0}", playerPosition);
                        break;

                    case 3:
                        playerPosition -= diceRoll;
                        if (playerPosition < 0)
                            playerPosition = 0;
                        Console.WriteLine("Snake\nplayer position : {0}", playerPosition);
                        break;
                }

            }
            Console.ReadLine();
        }
    }
}
