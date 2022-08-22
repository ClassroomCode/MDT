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
        private Piece[] _pos = new Piece[9]
        {
            Piece.X, Piece.X, Piece.X, Piece.X, Piece.X,
            Piece.O, Piece.O, Piece.O, Piece.X
        };

        public Piece GetPos(int i)
        {
            return _pos[i];
        }

        public bool IsEmpty => _pos.Any(p => p == Piece.Empty);

        public bool IsFull => _pos.Any(p => p != Piece.Empty);
    }
}