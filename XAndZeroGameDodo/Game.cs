using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAndZeroGameDodo
{
    class Game
    {
        public GameState gameState { get; set; }

        public Table GameTable { get; set; }

        public Game()
        {
            gameState = GameState.Loading;

            // user interaction
            Console.WriteLine("Do you want to start a new X and 0 Dodo game? y/n");
            var answer = Console.ReadLine();
            if (answer == "y")
                Start();
        }

        void Start()
        {
            gameState = GameState.Started;

            // create game table
            GameTable = new Table();
        }

        public bool EvaluateGame()
        {
            var sums = ReturnSums();

            if (sums.Contains(0))
            {
                Console.WriteLine("Computer has won this game.");
                return true;
            }

            if (sums.Contains(3))
            {
                Console.WriteLine("User has won this game.");
                return true;
            }

            if (sums.All(x => x < 3))
            {
                Console.WriteLine("No winner, game over.");
                return true;
            }

            return false;
        }

        int[] ReturnSums()
        {
            var result = new int[6];
            for (var i = 0; i < 3; i++)
            {
                byte auxL = 0;
                byte auxC = 0;

                for (var j = 0; j < 3; j++)
                {
                    auxL += GameTable.GameTable[i, j];
                    auxC += GameTable.GameTable[j, i];
                }
                result[i] = auxL;
                result[3 + i] = auxC;
            }

            return result;
        }
    }

    public enum GameState
    {
        Loading,
        Started,
        Over
    }
}
