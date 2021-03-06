﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    public class Board
    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};

        /// <summary>
		/// Display the game board in the console. 
		/// </summary>
		public void DisplayBoard()
		{

            //Output the board to the console
            int rows = GameBoard.GetLength(0);
            int columns = GameBoard.GetLength(1);

            for (int i = 0; i < rows; i++) 
            {
                Console.WriteLine();
                for (int j = 0; j < columns; j++) 
                {
                    Console.Write($"|{GameBoard[i,j]}|");
                }
            }
            Console.WriteLine();
		}
	}
}
