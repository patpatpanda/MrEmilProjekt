using MrEmilProjekt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using MrEmilProjekt.Migrations;

namespace MrEmilProjekt.Game
{
    public class Playgame
    {
        public AppDbContext myContext;

        public Playgame()
        {
        }

        public Playgame(AppDbContext context)
        {
            myContext = context;
        }
        public void PlayGame()
        {

            var buildApp = new Builder();
            var myContext = buildApp.AppBuilder();

            string computer;

            int randomNumber;
            int playerScore = 0;
            int computerScore = 0;
            int draw = 0;
            int totalGames = 0;

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nDone playing? Type END");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nROCK,PAPER or SCISSORS : ");
                string inputPlayer = Console.ReadLine().ToUpper();

                Random myRandom = new Random();

                randomNumber = myRandom.Next(1, 4);
                if (inputPlayer == "END")
                {
                    
                    break;
                }

                switch (randomNumber)
                {
                        
                    case 1:
                        computer = "ROCK";
                        Console.WriteLine("Computer chose ROCK ");
                        if (inputPlayer == "ROCK")
                        {
                            Console.WriteLine("ITS A DRAW!");
                            ResultMessage();
                            draw++;

                        }
                        else if (inputPlayer == "PAPER")
                        {
                            Console.WriteLine("YOU WIN!!");
                            
                            playerScore++;
                            ResultMessage();
                        }
                        else if (inputPlayer == "SCISSORS")
                        {
                            Console.WriteLine("YOU LOOSE!!");
                            computerScore++;
                            ResultMessage();
                        }
                        
                        break;
                    case 2:
                        computer = "PAPER";
                        Console.WriteLine("Computer chose PAPER ");
                        if (inputPlayer == "PAPER")
                        {
                            draw++;
                            Console.WriteLine("ITS A DRAW!");
                            ResultMessage();
                        }
                        else if (inputPlayer == "ROCK")
                        {
                            
                            Console.WriteLine("YOU LOOSE!!");
                            computerScore++;
                            ResultMessage();
                        }
                        else if (inputPlayer == "SCISSOR")
                        {
                            Console.WriteLine("YOU WIN!!");
                            playerScore++;
                            ResultMessage();
                        }
                        break;
                    case 3:
                        computer = "SCISSORS";
                        Console.WriteLine("Computer chose SCISSOR ");
                        if (inputPlayer == "PAPER")
                        {
                            
                            Console.WriteLine("YOU LOOSE!");
                            computerScore++;
                            ResultMessage();
                        }
                        else if (inputPlayer == "ROCK")
                        {
                            Console.WriteLine("YOU WIN!!");
                            playerScore++;
                            
                            ResultMessage();
                        }
                        else if (inputPlayer == "SCISSOR")
                        {
                            Console.WriteLine("ITS A DRAW!!");

                            draw++;
                            ResultMessage();
                        }

                        break;
                }

            }

            Console.WriteLine(draw);
            Console.WriteLine(computerScore);
            Console.WriteLine(playerScore);
            totalGames = draw + computerScore + playerScore;
            int avg = playerScore * 100 / totalGames;
            Console.Clear();

            var gameScore = new TheGame();
            gameScore.Win = playerScore;
            gameScore.Lost = computerScore;
            gameScore.WinPercentage = avg;
            gameScore.Date = DateTime.Now;
            myContext.TheGames.Add(gameScore);
            myContext.SaveChanges();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"You won {avg}% of total games played! ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nPress any key to continue");
            Console.ReadLine();
        }

        

        public void ResultMessage()
        {
            Console.WriteLine("\nPress any key to play again");
            Console.ReadKey();
        }

    }
}
