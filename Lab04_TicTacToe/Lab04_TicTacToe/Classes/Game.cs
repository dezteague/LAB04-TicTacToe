using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
	class Game
	{
        /// <summary>
		/// Bring in properties: board, players, winner 
		/// </summary>
		public Player PlayerOne { get; set; }
		public Player PlayerTwo { get; set; }
		public Player Winner { get; set; }
		public Board Board { get; set; }


		/// <summary>
		/// Require 2 players and a board to start a game. 
		/// </summary>
		/// <param name="p1">Player 1</param>
		/// <param name="p2">Player 2</param>
		public Game(Player p1, Player p2)
		{
			PlayerOne = p1;
			PlayerTwo = p2;
			Board = new Board();
		}

		/// <summary>
		/// Activate the Play of the game
		/// </summary>
		/// <returns>Winner</returns>
		public Player Play()
		{

            //TODO: Complete this method and utilize the rest of the class structure to play the game.

            /*
             * Complete this method by constructing the logic for the actual playing of Tic Tac Toe. 
             * 
             * A few things to get you started:
            1. A turn consists of a player picking a position on the board with their designated marker. 
            2. Display the board after every turn to show the most up to date state of the game
            3. Once a Winner is determined, display the board one final time and return a winner

            Few additional hints:
                Be sure to keep track of the number of turns that have been taken to determine if a draw is required
                and make sure that the game continues while there are unmarked spots on the board. 

            Use any and all pre-existing methods in this program to help construct the method logic. 
             */

            //set up a counter to keep track of the number of turns
            int turnCounter = 0;

            //as long as the winner has not been identified, do this:
            while (Winner == null)
            {
                //display the board
                Board.DisplayBoard();
                //determine whose turn it is
                //and take a turn which means occupy one of the coordinates
                NextPlayer().TakeTurn(Board);
                //if there is a winner, declare the player as winner!
                if (CheckForWinner(Board))
                {
                    Winner = NextPlayer();
                    
                }
                //if not, count the turn and switch players
                else
                {
                    turnCounter++;
                    SwitchPlayer();
                    Console.Clear();
                }
                //if players reach maximum amout of tries w/out a winner, declare a draw 
                if (turnCounter == 9 && Winner == null)
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, you're out of trys! It's a draw");
                } 
            }
            Console.Clear();
            Console.WriteLine($"Congratulations {Winner.Name}, you are the winner!");
            return Winner;
        }


		/// <summary>
		/// Check if winner exists
		/// </summary>
		/// <param name="board">current state of the board</param>
		/// <returns>if winner exists</returns>
		public bool CheckForWinner(Board board)
		{
			int[][] winners = new int[][]
			{
                //horizontal winning lines
				new[] {1,2,3},
				new[] {4,5,6},
				new[] {7,8,9},

                //vertical winning lines
				new[] {1,4,7},
				new[] {2,5,8},
				new[] {3,6,9},

                //diagonal winning lines
				new[] {1,5,9},
				new[] {3,5,7}
			};

			// Given all the winning conditions, Determine the winning logic. 
			for (int i = 0; i < winners.Length; i++)
			{
                //assign the coordinates of positions 1, 2, & 3
				Position p1 = Player.PositionForNumber(winners[i][0]);
				Position p2 = Player.PositionForNumber(winners[i][1]);
				Position p3 = Player.PositionForNumber(winners[i][2]);

                //assign strings a, b, c as either an integer OR the marker that has replaced it
				string a = Board.GameBoard[p1.Row, p1.Column];
				string b = Board.GameBoard[p2.Row, p2.Column];
				string c = Board.GameBoard[p3.Row, p3.Column];

                // TODO:  Determine a winner has been reached. 
                // return true if a winner has been reached. 
                // if all three positions are the same (either all x's or all o's)
                if (a == b && b == c && a == c)
                {
                    return true;
                }
                else
                {
                    return false;
                }
			
			}

			return false;
		}


		/// <summary>
		/// Determine next player
		/// </summary>
		/// <returns>next player</returns>
		public Player NextPlayer()
		{
			return (PlayerOne.IsTurn) ? PlayerOne : PlayerTwo;
		}

		/// <summary>
		/// End one players turn and activate the other
		/// </summary>
		public void SwitchPlayer()
		{
			if (PlayerOne.IsTurn)
			{
              
				PlayerOne.IsTurn = false;

              
				PlayerTwo.IsTurn = true;
			}
			else
			{
				PlayerOne.IsTurn = true;
				PlayerTwo.IsTurn = false;
			}
		}


	}
}
