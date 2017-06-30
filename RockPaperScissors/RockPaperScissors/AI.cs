using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class AI : Player
    {
        List<string> computerNames = new List<string>() {"Online", "Offline", "Terminator", "Gerald", "ORIGIN MASTER", "You Will Lose", "Loading..."};
        List<string> choices = new List<string>() {"rock","paper","scissors","lizard","spock"};
        string computerName = "GENERIC COMPUTER NAME";

        public AI()
        {

        }

        public override void GetPlayerName()
        {
            name = computerName;
            Console.WriteLine(name);
        }

        public override string GetPlayerChoice()
        {
            string choice = choices[GetRandomChoice()];
            Console.WriteLine(choice);
            return choice;
        }

        public int GetRandomChoice()
        {
            int randomIndex;
            Random randomNumber = new Random();
            randomIndex = randomNumber.Next(0,4);
            return randomIndex;
        }
    }
}
