using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Lib
{
    public class Game
    {
        public Piece CurrentPlayer { get; private set; } = Piece.X;

        public Board Board { get; } = new Board();

        public bool MakeMove(int pos)
        {
            if (Board[pos] != Piece.Empty) return false;

            Board[pos] = CurrentPlayer;

            CurrentPlayer = (CurrentPlayer == Piece.X ? Piece.O : Piece.X);
            return true;
        }

        public Piece[] IsWinner()
        {
            // TODO: Return pieces that make the win

            return new Piece[] { };
        }

        public bool IsTie()
        {
            // TODO: Implement

            return false;
        }
    }
}
