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
            string userInput = Console.ReadLine();
            name = userInput;
        }

        public virtual string GetPlayerChoice()
        {
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}
