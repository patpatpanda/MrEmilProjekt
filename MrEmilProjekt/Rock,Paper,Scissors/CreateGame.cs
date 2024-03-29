﻿using MrEmilProjekt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using MrEmilProjekt.Migrations;

namespace MrEmilProjekt.Game
{
    public class CreateGame
    {
        public AppDbContext myContext;

        public CreateGame()
        {
        }

        public CreateGame(AppDbContext context)
        {
            myContext = context;
        }
        public void PlayGame()
        {

            var buildApp = new Builder();
            var myContext = buildApp.AppBuilder();

            string computerInput;

            int randomNumber;
            int playerScore = 0;
            int computerScore = 0;
            int draw = 0;
        

            while (true)
            {
              
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.WriteLine("Quit? Type END");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\nROCK,PAPER or SCISSORS : ");
                    string inputPlayer = Console.ReadLine().ToUpper();

                    Random myRandom = new Random();

                    randomNumber = myRandom.Next(1, 4);
                    if (inputPlayer == "END")
                    {
                        ShowGameStats(draw, computerScore, playerScore, myContext);
                        break;

                    }

                    switch (randomNumber)
                    {

                        case 1:
                            computerInput = "ROCK";
                            Console.WriteLine("Computer chose ROCK ");
                            if (inputPlayer == "ROCK")
                            {

                                DrawMessage();
                                draw++;

                            }
                            else if (inputPlayer == "PAPER")
                            {


                                playerScore++;
                                WinMessage();
                            }
                            else if (inputPlayer == "SCISSORS")
                            {

                                computerScore++;
                                LooseMessage();
                            }

                            break;
                        case 2:
                            computerInput = "PAPER";
                            Console.WriteLine("Computer chose PAPER ");
                            if (inputPlayer == "PAPER")
                            {
                                draw++;

                                DrawMessage();
                            }
                            else if (inputPlayer == "ROCK")
                            {


                                computerScore++;
                                LooseMessage();
                            }
                            else if (inputPlayer == "SCISSOR")
                            {

                                playerScore++;
                                WinMessage();
                            }
                            break;
                        case 3:
                            computerInput = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSOR ");
                            if (inputPlayer == "PAPER")
                            {

                                computerScore++;
                                LooseMessage();
                            }
                            else if (inputPlayer == "ROCK")
                            {

                                playerScore++;

                                WinMessage();
                            }
                            else if (inputPlayer == "SCISSOR")
                            {


                                draw++;
                                DrawMessage();
                            }

                            break;
                    }
                
               


               
            }

            


        }

        private static void ShowGameStats(int draw, int computerScore, int playerScore, AppDbContext myContext)
        {
            var avg = Average(draw, computerScore, playerScore);

            SaveGameStats(playerScore, computerScore, avg, myContext);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"You won {avg}% of total games played! ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
            
        }

        private static void SaveGameStats(int playerScore, int computerScore, int avg, AppDbContext myContext)
        {
            var gameScore = new RockPaperScissors();
            gameScore.Win = playerScore;
            gameScore.Lost = computerScore;
            gameScore.WinPercentage = avg;
            gameScore.Date = DateTime.Now;
            myContext.Games.Add(gameScore);
            myContext.SaveChanges();
        }

        private static int Average(int draw, int computerScore, int playerScore)
        {
            int totalGames;
            Console.WriteLine(draw);
            Console.WriteLine(computerScore);
            Console.WriteLine(playerScore);
            totalGames = draw + computerScore + playerScore;
            int avg = playerScore * 100 / totalGames;
            Console.Clear();
            return avg;
        }


        public void WinMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("YOU WIN!!");
            Console.WriteLine("\nPress any key to play again");
          
            Console.ReadKey();

          
        }
        public void LooseMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("YOU LOOSE!!");
            Console.WriteLine("\nPress any key to play again");
            Console.ReadKey();


        }

        public void DrawMessage()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ITS A DRAW  !!");
            Console.WriteLine("\nPress any key to play again");
            Console.ReadKey();
        }

    }
}
