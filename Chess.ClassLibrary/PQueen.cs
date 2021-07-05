using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.ClassLibrary
{
    public class PQueen : Piece
    {
        private string myVar = "QU";

        public new string Label
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public override void LegalMoves(Cell currentCell)
        {
            ChessHelper.StraightLineMoves(currentCell, ChessBoardCell);
            ChessHelper.DiagonalMoves(currentCell, ChessBoardCell);
        }
    }
}
