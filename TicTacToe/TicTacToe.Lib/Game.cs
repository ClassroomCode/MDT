using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Lib
{
    public class Game
    {
        public Piece CurrentPlayer { get; } = Piece.X;

        public Board Board { get; } = new Board();

        public bool MakeMove(int pos)
        {
            // TODO: implement

            return true;
        }
    }
}
