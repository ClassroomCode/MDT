using TicTacToe.Lib;

namespace TicTacToe.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var g = new Game();
            DrawBoard(g.Board);

            Console.Write("Where do you want to move (1-9)? ");
            var input = Console.ReadLine();

            int move;
            if (!int.TryParse(input, out move)) {
                // TODO: bad, ask again
            }
            g.MakeMove(move);   // TODO: returns true of false
            DrawBoard(g.Board);

            // TODO: Next player
        }

        static void DrawBoard(Board b)
        {
            // TODO: do it right

            Console.WriteLine("   |   |   ");
            Console.WriteLine("---+---+---");
            Console.WriteLine("   | X |   ");
            Console.WriteLine("---+---+---");
            Console.WriteLine("   |   | O ");
        }
    }
}