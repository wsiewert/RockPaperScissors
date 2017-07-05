using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class AI : Player
    {
        List<string> computerNames = new List<string>() {"Online", "Offline", "Terminator", "Gerald", "ORIGIN MASTER", "You Will Lose", "Loading...", "Computer"};

        public AI()
        {

        }

        public override void GetPlayerName()
        {
            name = GetRandomIndex(computerNames);
            Console.WriteLine(name);
        }

        public override string GetPlayerChoice()
        {
            string choice = GetRandomIndex(choices);
            Console.WriteLine(choice);
            return choice;
        }

        public string GetRandomIndex(List<string> list)
        {
            int randomIndex;
            string result;
            Random randomNumber = new Random();
            randomIndex = randomNumber.Next(0, (list.Count));
            result = list[randomIndex];
            return result;
        }
    }
}
