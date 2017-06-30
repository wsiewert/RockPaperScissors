using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Player
    {
        public string name;
        public int score;
        public List<string> choices = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };

        public Player()
        {
            name = "";
            score = 0;
        }

        public void IncrementScore()
        {
            score++;
        }

        public virtual void GetPlayerName()
        {
            string userInput = Console.ReadLine().Trim();
            name = userInput;
        }

        public virtual string GetPlayerChoice()
        {
            string userInput = Console.ReadLine().ToLower().Trim();
            if (choices.Contains(userInput))
            {
                return userInput;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--NOT A COMMAND!--");
            Console.ResetColor();
            return GetPlayerChoice();
        }
    }
}
