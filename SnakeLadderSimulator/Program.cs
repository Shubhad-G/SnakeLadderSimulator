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
            Console.WriteLine("Welcome to Snake Ladder 2 Player Game");
            Random random = new Random();
            
            int player1Position = 0;
            int player2Position = 0;
            string currentPlayer = "player1";//initialized current player to player 1 in the beginning
            Console.WriteLine("initialized the player1 position to {0}", player1Position);
            Console.WriteLine("initialized the player2 position to {0}", player2Position);
            Console.WriteLine("Rolling the dice for");

            while (player1Position <= 100 && player2Position<=100)
            {
               
                int diceRoll = random.Next(1, 7);
                Console.WriteLine("\nDice Number: {0}\n", diceRoll);
                int option = random.Next(1, 4);
                switch (option)
                {
                    case 1:
                        if (currentPlayer == "player1")
                        {
                            if (player1Position >= 100)
                            {
                                if (player1Position > 100)
                                {
                                    player1Position = player1Position - diceRoll;
                                    Console.WriteLine("\nNoplay\nplayer 1 position : {0}", player1Position);
                                    currentPlayer= "player2";
                                }
                                else
                                    Console.WriteLine("Ladder\nplayer 1 has won: {0}", player1Position);
                            }
                            else
                                Console.WriteLine("No play\nplayer 1 position: {0}", player1Position);
                                currentPlayer = "player2";
                        }
                        else
                        {
                            if (player2Position >= 100)
                            {
                                if (player2Position > 100)
                                {
                                    player2Position = player2Position - diceRoll;
                                    Console.WriteLine("\nNoplay\nplayer 2 position : {0}", player2Position);
                                    currentPlayer="player1";
                                }
                                else
                                    Console.WriteLine("Ladder\nplayer 2 has won: {0}", player2Position);
                            }
                            else
                                Console.WriteLine("No play\nplayer 2 position: {0}", player2Position);
                                currentPlayer="player1";
                        }
                        break;

                    case 2:
                        if (currentPlayer == "player1")
                        {
                            int previousPosition = player1Position;
                            player1Position += diceRoll;
                            if (player1Position >= 100)
                            {
                                if (player1Position > 100)
                                {
                                    player1Position = previousPosition;
                                    Console.WriteLine("\nNoplay\nplayer 1 position : {0}", player1Position);
                                }
                                else
                                {
                                    Console.WriteLine("Ladder\nplayer 1 has won: {0}", player1Position);
                                    player1Position += player1Position;
                                }
                            }
                            else
                                Console.WriteLine("\nLadder\nplayer 1 position: {0}", player1Position);
                                currentPlayer = "player1";
                        }
                        else
                        {
                            int previousPosition = player2Position;
                            player2Position += diceRoll;
                            if (player2Position >= 100)
                            {
                                if (player2Position > 100)
                                {
                                    player2Position = previousPosition;
                                    Console.WriteLine("\nNoplay\nplayer 2 position : {0}", player2Position);
                                }
                                else
                                {
                                    Console.WriteLine("Ladder\nplayer 2 has won: {0}", player2Position);
                                    player1Position += player1Position;
                                }
                            }
                            else
                                Console.WriteLine("\nLadder\nplayer 2 position: {0}", player2Position);
                                currentPlayer="player2";
                        }
                        break;

                    case 3:
                        if (currentPlayer == "player1")
                        {
                            player1Position -= diceRoll;
                            if (player1Position < 0)
                                player1Position = 0;
                            Console.WriteLine("Snake\nplayer 1 position : {0}", player1Position);
                            currentPlayer = "player2";
                        }
                        else
                        {
                            player2Position -= diceRoll;
                            if (player2Position < 0)
                                player2Position = 0;
                            Console.WriteLine("Snake\nplayer 2 position : {0}", player2Position);
                            currentPlayer = "player1";
                        }
                        break;
                }
                       
                }

            Console.ReadLine();
        }
    }
}
