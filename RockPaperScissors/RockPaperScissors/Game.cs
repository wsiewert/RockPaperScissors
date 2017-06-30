﻿using System;
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
            Console.WriteLine(player1.name + " Choose your hand:");
            string player1Choice = player1.GetPlayerChoice();
            Console.WriteLine(player2.name + " Choose your hand:");
            string player2Choice = player2.GetPlayerChoice();

            CompareHands(player1Choice,player2Choice);
        }

        public void CompareHands(string player1Choice, string player2Choice)
        {
            int player1ChoiceIndex = GetChoiceIndex(player1Choice);
            int player2ChoiceIndex = GetChoiceIndex(player2Choice);

            int winResult = (5 + player1ChoiceIndex - player2ChoiceIndex) % 5;

            switch (winResult)
            {
                case 0:
                    Console.WriteLine("DRAW!");
                    CheckGameWinner();
                    break;
                case 1:
                case 3:
                    Console.WriteLine(player1.name + " wins this round!");
                    player1.IncrementScore();
                    CheckGameWinner();
                    break;
                case 2:
                case 4:
                    Console.WriteLine(player2.name + " wins this round!");
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
            if (player1.score == 2 || player2.score == 2)
            {
                Console.WriteLine("WIN GAME");
                WinGame();
                //display winnner and ask to play again.
            }
            else
            {
                PlayRound();
            }
        }

        public void WinGame()
        {
            //do something to win the game.
        }

        public string GetGameType()
        {
            Console.WriteLine("Select Game Type");
            Console.WriteLine("'1' - Human vs AI");
            Console.WriteLine("'2' - Human vs Human");
            string userInput = Console.ReadLine();
            return userInput;
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
            player1.GetPlayerName();
            Console.WriteLine("Player 2 choose a name:");
            player2.GetPlayerName();
        }
    }
}