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
        private Piece[] _pos = new Piece[9];

        public Piece this[int i]
        {
            get { return _pos[i - 1]; }
            set { _pos[i - 1] = value; }
        }

        public bool IsEmpty => !(_pos.Any(p => p != Piece.Empty));

        public bool IsFull => !(_pos.Any(p => p == Piece.Empty));
    }
}