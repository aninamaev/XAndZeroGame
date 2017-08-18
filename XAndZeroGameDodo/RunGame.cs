namespace XAndZeroGameDodo
{
    public class RunGame
    {
        public RunGame()
        {
            // creare joc
            var game = new Game();

            if (game.gameState == GameState.Started)
            {
                // create players
                var computerPlayer = new ComputerPlayer();
                var userPlayer = new UserPlayer();

                // associate table with players
                computerPlayer.Table = game.GameTable;
                userPlayer.Table = game.GameTable;

                game.GameTable.PrintCurrentGameTable();


                // let the game begin
                bool isGameOver = false;

                while (!isGameOver)
                {
                    userPlayer.InitiateMove();
                    game.GameTable.PrintCurrentGameTable();
                    isGameOver = game.EvaluateGame();

                    if (!isGameOver)
                    {
                        computerPlayer.InitiateMove();
                        game.GameTable.PrintCurrentGameTable();
                        isGameOver = game.EvaluateGame();
                    }
                }
            }
        }
    }
}