Imports TicTacToe.Lib

Public Class Form1
    Private _game As Game

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _game = New Game()
        UpdateBoard()
    End Sub

    Private Sub UpdateBoard()
        Button1.Text = StringForPiece(_game.Board(1))
        Button2.Text = StringForPiece(_game.Board(2))
        Button3.Text = StringForPiece(_game.Board(3))
        Button4.Text = StringForPiece(_game.Board(4))
        Button5.Text = StringForPiece(_game.Board(5))
        Button6.Text = StringForPiece(_game.Board(6))
        Button7.Text = StringForPiece(_game.Board(7))
        Button8.Text = StringForPiece(_game.Board(8))
        Button9.Text = StringForPiece(_game.Board(9))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim b = _game.MakeMove(5)
        UpdateBoard()
    End Sub

    Private Function StringForPiece(p As Piece) As String
        If (p = Piece.X) Then Return "X"
        If (p = Piece.O) Then Return "O"
        Return " "
    End Function

End Class
