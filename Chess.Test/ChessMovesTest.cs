using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chess.ClassLibrary;

namespace Chess.Test
{
    [TestClass]
    public class ChessMovesTest
    {
        static Board myChess = new Board();

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestKingPieceMoves()
        {
            //Arrange
            int rankLocation = 0;
            int fileLocation = 0;

            PKing piece = new PKing
            {
                ChessBoardCell = myChess.ChessBoardCell
            };


            //Action
            //This position is now occupied by this chess piece
            Cell currentCell = myChess.ChessBoardCell[rankLocation, fileLocation];
            currentCell.IsOccupied = true;
            piece.LegalMoves(currentCell);
            myChess.ChessPieceOnPlay = piece.Label;

            //Result: Expecting the below cell to be marked as a legal move
            Assert.IsTrue(myChess.ChessBoardCell[1, 0].IsLegalMove == true);
            Assert.IsTrue(myChess.ChessBoardCell[1, 1].IsLegalMove = true);
            Assert.IsTrue(myChess.ChessBoardCell[0, 1].IsLegalMove = true);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestRookPieceMoves()
        {
            //Arrange
            int rankLocation = 0;
            int fileLocation = 0;

            PRook piece = new PRook
            {
                ChessBoardCell = myChess.ChessBoardCell
            };


            //Action
            //This position is now occupied by this chess piece
            Cell currentCell = myChess.ChessBoardCell[rankLocation, fileLocation];
            currentCell.IsOccupied = true;
            piece.LegalMoves(currentCell);
            myChess.ChessPieceOnPlay = piece.Label;

            //Result: Expecting the below cells to be marked as a legal move
            for (int r = 1; r < myChess.Size; r++)
            {
                Assert.IsTrue(myChess.ChessBoardCell[r, 0].IsLegalMove == true);
            }

            for (int f = 1; f < myChess.Size; f++)
            {
                Assert.IsTrue(myChess.ChessBoardCell[0, f].IsLegalMove == true);
            }
               
        }
    }
}
