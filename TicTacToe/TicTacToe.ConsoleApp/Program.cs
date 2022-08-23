using TicTacToe.Lib;

namespace TicTacToe.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var g = new Game();
            DrawBoard(g.Board);

            while (!g.Board.IsFull) {
                int? m = null;
                while (!m.HasValue) {
                    m = AskForMove();
                    if (!m.HasValue) {
                        Console.WriteLine("INVALID MOVE");
                    }
                    else {
                        bool b = g.MakeMove(m.Value);
                        if (!b) {
                            Console.WriteLine("POSITION TAKEN");
                            m = null;
                        }
                    }
                }
                DrawBoard(g.Board);
            }
        }

        static int? AskForMove()
        {
            Console.Write("Where do you want to move (1-9)? ");
            var input = Console.ReadLine();

            int move;
            if (!int.TryParse(input, out move)) {
                return null;
            }
            if (move < 1 || move > 9) return null; 
            return move;
        }

        static void DrawBoard(Board b)
        {
            Console.WriteLine(StringForRow(b[1], b[2], b[3]));
            Console.WriteLine("---+---+---");
            Console.WriteLine(StringForRow(b[4], b[5], b[6]));
            Console.WriteLine("---+---+---");
            Console.WriteLine(StringForRow(b[7], b[8], b[9]));
        }

        static string StringForRow(Piece p1, Piece p2, Piece p3) =>
            $" {StringForPiece(p1)} | {StringForPiece(p2)} | {StringForPiece(p3)} ";

        static string StringForPiece(Piece p)
        {
            if (p == Piece.Empty) return " ";
            return (p == Piece.X ? "X" : "O");
        }
    }
}