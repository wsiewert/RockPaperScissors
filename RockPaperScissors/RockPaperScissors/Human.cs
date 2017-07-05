using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Human : Player
    {
        public Human()
        {
            
        }

        public override void GetPlayerName()
        {
            string userInput = Console.ReadLine().Trim();
            if (userInput == "")
            {
                name = "DEFAULT_USER_NAME";
            }
            else
            {
                name = userInput;
            }
        }
    }
}
