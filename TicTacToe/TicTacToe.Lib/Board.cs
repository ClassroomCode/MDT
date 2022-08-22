using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Lib
{
    public enum Piece { Empty, X, O }

    public class Board
    {
        private Piece[] pos = new Piece[9]
        {
            Piece.X, Piece.X, Piece.X, Piece.X, Piece.X,
            Piece.O, Piece.O, Piece.O, Piece.Empty
        };

        public Piece GetPos(int i)
        {
            return pos[i];
        }

        public bool IsEmpty()
        {
            return true;
        }

        public bool IsFull()
        {
            return true;
        }
    }
}