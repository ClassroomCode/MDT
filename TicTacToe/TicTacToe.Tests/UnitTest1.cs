using TicTacToe.Lib;

namespace TicTacToe.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestBoardFull()
        {
            // Arrange
            var b = new Board();
            b[1] = Piece.X;
            b[2] = Piece.X;
            b[3] = Piece.O;
            b[4] = Piece.O;
            b[5] = Piece.X;
            b[6] = Piece.X;
            b[7] = Piece.O;
            b[8] = Piece.O;
            b[9] = Piece.O;

            // Act
            bool isFull = b.IsFull;

            // Assert
            Assert.True(isFull);
        }

        [Fact]
        public void TestBoardNotFull()
        {
            // Arrange
            var b = new Board();
            b[1] = Piece.X;
            b[2] = Piece.X;
            b[3] = Piece.O;
            b[4] = Piece.O;
            b[5] = Piece.Empty;
            b[6] = Piece.X;
            b[7] = Piece.O;
            b[8] = Piece.O;
            b[9] = Piece.O;

            // Act
            bool isFull = b.IsFull;

            // Assert
            Assert.False(isFull);
        }
    }
}