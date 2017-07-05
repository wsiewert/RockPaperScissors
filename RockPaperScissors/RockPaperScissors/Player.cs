using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Player
    {
        protected string name;
        protected int score;
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

        public string GetName()
        {
            return name;
        }

        public int GetScore()
        {
            return score;
        }

        public virtual void GetPlayerName()
        {

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
