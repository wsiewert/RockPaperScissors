using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class PlayerVPlayer
    {
        PlayerHuman player1 = new PlayerHuman();
        PlayerHuman player2 = new PlayerHuman();
        string playerTurn;

        public PlayerVPlayer()
        {
            playerTurn = player1.name;
        }

        public void StartGame()
        {
            Console.WriteLine("Player1 Enter Name:");
            player1.name = Console.ReadLine();
            Console.WriteLine("Player2 Enter Name:");
            player2.name = Console.ReadLine();
            PlayGame();
        }

        public void PlayGame()
        {
            Console.WriteLine(playerTurn + "'s turn");
            
            Console.WriteLine("");
            Console.ReadKey();
        }

        public void ChangeTurn()
        {
            if (playerTurn == player1.name)
            {
                playerTurn = player2.name;
            }
            else
            {
                playerTurn = player2.name;
            }
        }
    }
}
