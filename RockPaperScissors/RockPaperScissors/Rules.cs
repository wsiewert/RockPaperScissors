using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Rules
    {
        public Rules()
        {
            
        }

        public void DisplayRules()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("===============================");
            Console.WriteLine("RULES:");
            Console.WriteLine("'scissors' cuts 'paper'");
            Console.WriteLine("'paper' covers 'rock'");
            Console.WriteLine("'rock' crushes 'lizard'");
            Console.WriteLine("'lizard' poisons 'spock'");
            Console.WriteLine("'spock' smashes 'scissors'");
            Console.WriteLine("'scissors' decapitates 'lizard'");
            Console.WriteLine("'lizard' eats 'paper'");
            Console.WriteLine("'paper' disproves 'spock'");
            Console.WriteLine("'spock' vaporizes 'rock'");
            Console.WriteLine("'rock' crushes 'scissors'");
            Console.WriteLine("===============================");
            Console.ResetColor();
        }
    }
}
