using System;

namespace RoPaSci
{
    public class Program
    {
        private static void Main(string[] args)
        {
            GameItem p1Item = Enum.Parse<GameItem>(args[0]);
            GameItem p2Item = Enum.Parse<GameItem>(args[1]);

            GameStatus result = RockPaperScissors(p1Item, p2Item);

            switch (result)
            {
                case GameStatus.Draw:
                    Console.WriteLine("It's a draw!");
                    break;
                case GameStatus.Player1Wins:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case GameStatus.Player2Wins:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static GameStatus RockPaperScissors(GameItem player1, GameItem player2)
        {
            int gameResult = 2;

            if (player1 == player2)
            {
                gameResult = 0;
            }
            if (((player1 == GameItem.Rock) && (player2 == GameItem.Scissors)) ||
                ((player1 == GameItem.Scissors) && (player2 == GameItem.Paper)) ||
                ((player1 == GameItem.Paper) && (player2 == GameItem.Rock)))
            {
                gameResult = 1;
            }
            return (GameStatus)gameResult;
        }
    }
}
