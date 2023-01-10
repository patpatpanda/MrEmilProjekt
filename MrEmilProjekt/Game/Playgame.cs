using MrEmilProjekt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

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
           


            string computer;

            int randomNumber;
            int playerScore = 0;
            int computerScore = 0;

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
                            ResultMessage();
                        }
                        else if (inputPlayer == "ROCK")
                        {
                            Console.WriteLine("YOU WIN!!");
                            computerScore++;
                            ResultMessage();
                        }
                        else if (inputPlayer == "SCISSOR")
                        {
                            Console.WriteLine("ITS A DRAW!!");
                            playerScore++;
                            ResultMessage();
                        }

                        break;
                }

            }

            Console.WriteLine(playerScore);
            Console.WriteLine(computerScore);
            Console.ReadLine();

        }

        public void ResultMessage()
        {
            Console.WriteLine("\nPress any key to play again");
            Console.ReadKey();
        }

    }
}
