using TicTacToe.Lib;

namespace TicTacToe.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var b = new Board();

            Console.WriteLine($"Full? {b.IsFull()}");
            Console.WriteLine($"Empty? {b.IsEmpty()}");


            Console.WriteLine("   |   |   ");
            Console.WriteLine("---+---+---");
            Console.WriteLine("   | X |   ");
            Console.WriteLine("---+---+---");
            Console.WriteLine("   |   | O ");
        }
    }
}