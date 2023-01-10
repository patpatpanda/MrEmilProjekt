using MrEmilProjekt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrEmilProjekt.Game
{
    public class Playgame
    {
        public AppDbContext myContext;

        public Playgame(AppDbContext context)
        {
            myContext = context;
        }
        public void PlayGame()
        {
            string player;
            string computer;

            int randomNumber;

            Console.Write("ROCK,PAPER or SCISSOR : ");

            Random myRandom = new Random();

            randomNumber = myRandom.Next(1, 4);

            switch (randomNumber)
            {
                case 1:
                    computer = "ROCK";
                    Console.WriteLine("Computer chose ");
                    break;
            }

        }
    }
}
