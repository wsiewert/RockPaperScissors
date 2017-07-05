using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        Player player1;
        Player player2;
        List<string> choices = new List<string>() { "rock", "paper", "scissors", "spock", "lizard" };

        public Game()
        {
            
        }

        public void StartGame()
        {
            Rules rules = new Rules();
            rules.DisplayRules();
            GetPlayerType(GetGameType());
            GetPlayerNames();
            PlayRound();
        }

        public void PlayRound()
        {
            DisplayRoundSeparationBar();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(player1.name);
            Console.ResetColor();
            Console.WriteLine(" choose your hand");
            string player1Choice = player1.GetPlayerChoice();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(player2.name);
            Console.ResetColor();
            Console.WriteLine(" choose your hand");
            string player2Choice = player2.GetPlayerChoice();

            CompareHands(player1Choice, player2Choice);
        }

        public void CompareHands(string player1Choice, string player2Choice)
        {
            int player1ChoiceIndex = GetChoiceIndex(player1Choice);
            int player2ChoiceIndex = GetChoiceIndex(player2Choice);

            int winResult = (5 + player1ChoiceIndex - player2ChoiceIndex) % 5;

            switch (winResult)
            {
                case 0:
                    Console.WriteLine("   [DRAW!]");
                    CheckGameWinner();
                    break;
                case 1:
                case 3:
                    Console.WriteLine("   [" + player1.name + " wins this round!]");
                    player1.IncrementScore();
                    CheckGameWinner();
                    break;
                case 2:
                case 4:
                    Console.WriteLine("   [" + player2.name + " wins this round!]");
                    player2.IncrementScore();
                    CheckGameWinner();
                    break;
                default:
                    break;
            }
        }

        public int GetChoiceIndex(string choice)
        { 
            int index = choices.IndexOf(choice);
            return index;
        }

        public void CheckGameWinner()
        {
            if (player1.score == 2)
            {
                DisplayWinner(player1.name);
            }
            else if(player2.score == 2)
            {
                DisplayWinner(player2.name);
            }
            else
            {
                PlayRound();
            }
        }

        public void DisplayWinner(string winner)
        {
            DisplayRoundSeparationBar();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(winner + " WINS THE GAME!");
            Console.ResetColor();
            AskToPlayAgain();
        }

        public void AskToPlayAgain()
        {
            Console.WriteLine("Would you like to play again?");
            Console.WriteLine("'yes' or 'no'");
            string userInput = Console.ReadLine().ToLower().Trim();
            switch (userInput)
            {
                case "yes":
                    StartGame();
                    break;
                case "no":
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("--NOT A COMMAND--");
                    Console.ResetColor();
                    AskToPlayAgain();
                    break;
            }
        }

        public string GetGameType()
        {
            Console.WriteLine("Select Game Type");
            Console.WriteLine("'1' - Human vs AI");
            Console.WriteLine("'2' - Human vs Human");
            string userInput = Console.ReadLine();

            if (userInput == "1" || userInput == "2")
            {
                return userInput;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--NOT A COMMAND--");
            Console.ResetColor();
            return GetGameType();
        }

        public void GetPlayerType(string gameType)
        {
            if (gameType == "1")
            {
                player1 = new Human();
                player2 = new AI();
            }
            else if (gameType == "2")
            {
                player1 = new Human();
                player2 = new Human();
            }
        }

        public void GetPlayerNames()
        {
            Console.WriteLine("Player 1 choose a name:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            player1.GetPlayerName();
            Console.ResetColor();
            Console.WriteLine("Player 2 choose a name:");
            Console.ForegroundColor = ConsoleColor.Green;
            player2.GetPlayerName();
            Console.ResetColor();
        }

        public void DisplayRoundSeparationBar()
        {
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < 35; i++)
            {
                Console.Write("=");
                if (i == 34)
                {
                    Console.WriteLine("=");
                }
            }
            Console.ResetColor();
        }
    }
}
