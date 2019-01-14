using Lab04_TicTacToe.Classes;
using System;


namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's Play Tic-Tac-Toe!");
            Console.WriteLine("");
            //instantiate new players
            Player p1 = new Player();
            Player p2 = new Player();

            //assign markers "X" and "O" to the players
            //marker is the property, players are the objects
            p1.Marker = "O";
            p2.Marker = "X";

            Console.WriteLine("Player One, please enter your name:");
            string name1 = Console.ReadLine();
            //name is a property of the object, player one
            //assign the name string, provided by the user, to that object
            p1.Name = name1;

            Console.WriteLine("Player Two, please enter your name:");
            string name2 = Console.ReadLine();
            //name is a property of the object, player two
            //assign the name string, provided by the user, to that object
            p2.Name = name2;

            //instantiate the board
            Board board = new Board();

            //instantiate a new game, calling in player one and player two
            Game game = new Game(p1, p2);
            //run game
            game.Play();
        }
    }
}
