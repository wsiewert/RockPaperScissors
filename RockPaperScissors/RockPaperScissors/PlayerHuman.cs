using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class PlayerHuman
    {
        public string name;
        public int score;

        public PlayerHuman()
        {
            name = "";
            score = 0;
        }

        public void IncrementScore()
        {
            score++;
        }

        public void PlayerChoice()
        {
            
        }
    }
}
