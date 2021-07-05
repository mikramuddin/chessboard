using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.ClassLibrary
{
    public class PBishop : Piece
    {
        private string myVar = ChessConstant.PBISHOP;

        public new string Label
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public override void LegalMoves(Cell currentCell)
        {
            ChessHelper.DiagonalMoves(currentCell, ChessBoardCell);
        }
    }
}
