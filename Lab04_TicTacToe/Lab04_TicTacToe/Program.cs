using Lab04_TicTacToe.Classes;
using System;


namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's Play Tic-Tac-Toe!");
            Console.WriteLine("");
            //instantiate new players
            Player player1 = new Player();
            Player player2 = new Player();

            //assign markers "X" and "O" to the players
            //marker is the property, players are the objects
            player1.Marker = "X";
            player2.Marker = "O";

            Console.WriteLine("Player One, please enter your name:");
            string name1 = Console.ReadLine();
            //name is a property of the object, player one
            //assign the name string, provided by the user, to that object
            player1.Name = name1;

            Console.WriteLine("Player Two, please enter your name:");
            string name2 = Console.ReadLine();
            //name is a property of the object, player two
            //assign the name string, provided by the user, to that object
            player2.Name = name2;

            //instantiate the board
            Board board = new Board();

            //instantiate a new game, calling in player one and player two
            Game game = new Game(player1, player2);
            //run game
            game.Play();
        }
    }
}
