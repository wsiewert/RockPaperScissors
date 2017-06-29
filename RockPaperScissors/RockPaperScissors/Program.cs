using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ROCK PAPER SCISSORS LIZARD SPOCK");
            Console.WriteLine("'1' - Player vs AI");
            Console.WriteLine("'2' - Player vs player");

            string userInput = Console.ReadLine().ToString().Trim();

            switch (userInput)
            {
                case "1":
                    PlayerVAI playerVAI = new PlayerVAI();
                    playerVAI.StartGame();
                    break;
                case "2":
                    PlayerVPlayer playerVPlayer = new PlayerVPlayer();
                    playerVPlayer.StartGame();
                    break;
                default:
                    break;
            }
        }
    }
}
