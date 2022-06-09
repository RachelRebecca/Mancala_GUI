﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mancala_GUI
{
    class GameTree
    {
        /// <summary>
        /// Recursive method to get the values for the Minimax (Game) Tree
        /// </summary>
        /// <param name="board">The starting Board object</param>
        /// <param name="depth">The amount of levels to go down in the Minimax (Game) Tree</param>
        /// <param name="player">The initial Max Player (before getting called recursively, Player.COMPUTER is always the Max player)</param>
        /// <returns>double, the value</returns>
        public static double Value(Board board, int depth, Player player)
        {
            Player opponent = player == Player.COMPUTER ? Player.PLAYER : Player.COMPUTER;

            double value;
            if (depth == 0)
            {
                value = board.HeuristicValue(player, opponent, board);
            }
            else if (board.IsWinner(opponent, board))
            {
                value = player == Player.COMPUTER ? Mancala.MIN_VALUE : Mancala.MAX_VALUE;
            }
            else
            {
                if (player == Player.COMPUTER)
                {
                    double BestValue = Mancala.MIN_VALUE;
                    for (int spot = 0; spot < Board.NUM_SPOTS; spot++)
                    {
                        if (board.IsValidMove(player, spot))
                        {
                            Board nextPos = GetNextPositionBoard(board, player, opponent, spot); 

                            // go one more depth inside the tree playing as the opponent
                            double thisVal = Value(nextPos, depth - 1, opponent);

                            if (thisVal > BestValue)
                            {
                                BestValue = thisVal;
                            }
                        }
                    }
                    value = BestValue;
                }
                else  // player == Player.MIN
                {
                    double BestValue = Mancala.MAX_VALUE;
                    for (int spot = 0; spot < Board.NUM_SPOTS; spot++)
                    {
                        if (board.IsValidMove(player, spot))
                        {
                            Board nextPos = GetNextPositionBoard(board, player, opponent, spot);

                            // go one more depth inside the tree playing as the opponent
                            double thisVal = Value(nextPos, depth - 1, opponent);
                            if (BestValue > thisVal)
                            {
                                BestValue = thisVal;
                            }
                        }
                    }
                    value = BestValue;
                }
            }
            return value;
        }

        /// <summary>
        /// Internal method to get the next position board after making a move
        /// </summary>
        /// <param name="board">The Board object</param>
        /// <param name="player">The current Player</param>
        /// <param name="opponent">The current opponent</param>
        /// <param name="spot">The current spot being played</param>
        /// <returns>a new Board object, containing the next position after making a move</returns>
        private static Board GetNextPositionBoard(Board board, Player player, Player opponent, int spot)
        {
            Board nextPos = board.MakeMove(player, spot);

            // update nextPos board with winning move if the next position results in a win
            if (nextPos.AllSpotsAreEmpty(player))
            {
                nextPos.GameOverMove(nextPos, player);
            }
            else if (nextPos.AllSpotsAreEmpty(opponent))
            {
                nextPos.GameOverMove(nextPos, opponent);
            }

            return nextPos;
        }
    }

}
