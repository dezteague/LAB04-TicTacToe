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
        public void SwitchPlayersTest()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            game.SwitchPlayer();
            Assert.True(game.PlayerOne.IsTurn);
        }


        [Fact]
        public void CorrectPositionIndexCorrelationTest()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            Position positionOne = Player.PositionForNumber(1);
            Position positionTwo = Player.PositionForNumber(2);
            game.Board.GameBoard[positionOne.Row, positionOne.Column] = p1.Marker;
            game.Board.GameBoard[positionTwo.Row, positionTwo.Column] = p2.Marker;
        }


        [Fact]
        public void MakeNewBoardTest()
        {
            Board board = new Board();
            Assert.Equal("1", board.GameBoard[0, 0]);
        }
    }
}
