using System;
using Xunit;
using static Lab04_TicTacToe.Program;
using Lab04_TicTacToe.Classes;

namespace TicTacToeTest
{
    public class UnitTest1
    {
        [Fact]
        public void GameWinnerTest()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            game.Board.GameBoard[0, 0] = "O";
            game.Board.GameBoard[0, 1] = "O";
            game.Board.GameBoard[0, 2] = "O";
            Assert.True(game.CheckForWinner(game.Board));
        }

        [Fact]
        public void MakeNewBoardTest()
        {
            Board board = new Board();
            Assert.Equal("1", board.GameBoard[0, 0]);
        }

        [Fact]
        public void SwitchPlayersTest()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            game.SwitchPlayer();
            Assert.True(game.PlayerOne.IsTurn);
        }
    }
}
