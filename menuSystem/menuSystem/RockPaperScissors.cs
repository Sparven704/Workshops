using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuSystem
{
    internal class RockPaperScissors
    {
        public RockPaperScissors()
        {
            Console.WriteLine("Welcome to rock paper scissors!");
            Console.WriteLine("1. New game");
            Console.WriteLine("2. Exit.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput < 1 || userInput > 2)
            {
                Console.WriteLine("Error, Invalid input");
                return;
            }

            Random random = new Random();

            int playerPoints = 0;
            int computerPoints = 0;
            while (userInput == 1)
            {
                Console.WriteLine("Rules are first to 5!");
                while (playerPoints != 5 && computerPoints != 5)
                {
                    Console.WriteLine("Players score: " + playerPoints);
                    Console.WriteLine("Computers score: " + computerPoints);
                    Console.WriteLine("Please enter 'r' for rock, 'p' for paper and 's' for scissors)");
                    string playerMove = Console.ReadLine();

                    int computerMove = random.Next(0, 3);

                    if (computerMove == 0)
                    {
                        Console.WriteLine("The computer chose Rock.");

                        switch (playerMove)
                        {
                            case "r":
                                Console.WriteLine("Seems you have tied!");
                                break;
                            case "p":
                                Console.WriteLine("You have won!");
                                playerPoints++;
                                break;
                            case "s":
                                Console.WriteLine("You have lost.");
                                computerPoints++;
                                break;
                        }
                    }
                    else if (computerMove == 1)
                    {
                        Console.WriteLine("The computer chose Paper.");

                        switch (playerMove)
                        {
                            case "r":
                                Console.WriteLine("You have lost.");
                                computerPoints++;
                                break;
                            case "p":
                                Console.WriteLine("Seems you have tied!");

                                break;
                            case "s":
                                Console.WriteLine("You have won!");
                                playerPoints++;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("The computer chose Scissors.");

                        switch (playerMove)
                        {
                            case "r":
                                Console.WriteLine("You have won!");
                                playerPoints++;
                                break;
                            case "p":
                                Console.WriteLine("You have lost.");
                                computerPoints++;
                                break;
                            case "s":
                                Console.WriteLine("Seems you have tied!");
                                break;
                        }
                    }

                }
                if (playerPoints == 5)
                {
                    Console.WriteLine("You win the game!");
                    playerPoints = 0;
                    computerPoints = 0;
                }
                else
                {
                    Console.WriteLine("You lost the game :(");
                    playerPoints = 0;
                    computerPoints = 0;
                }
                Console.WriteLine();
                Console.WriteLine("1. New game");
                Console.WriteLine("2. Exit.");
                userInput = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
