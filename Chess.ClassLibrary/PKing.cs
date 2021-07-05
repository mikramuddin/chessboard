using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.ClassLibrary
{
    public class PKing : Piece
    {
        private string myVar = "KG";

        public new string Label
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public override void LegalMoves(Cell currentCell)
        {
            if (ChessHelper.IsWithinBoardRange(currentCell.RankNumber + 1, currentCell.FileNumber + 0))
                ChessBoardCell[currentCell.RankNumber + 1, currentCell.FileNumber + 0].IsLegalMove = true;
            if (ChessHelper.IsWithinBoardRange(currentCell.RankNumber + 1, currentCell.FileNumber - 1))
                ChessBoardCell[currentCell.RankNumber + 1, currentCell.FileNumber - 1].IsLegalMove = true;
            if (ChessHelper.IsWithinBoardRange(currentCell.RankNumber + 1, currentCell.FileNumber + 1))
                ChessBoardCell[currentCell.RankNumber + 1, currentCell.FileNumber + 1].IsLegalMove = true;
            if (ChessHelper.IsWithinBoardRange(currentCell.RankNumber + 0, currentCell.FileNumber - 1))
                ChessBoardCell[currentCell.RankNumber + 0, currentCell.FileNumber - 1].IsLegalMove = true;
            if (ChessHelper.IsWithinBoardRange(currentCell.RankNumber + 0, currentCell.FileNumber + 1))
                ChessBoardCell[currentCell.RankNumber + 0, currentCell.FileNumber + 1].IsLegalMove = true;
            if (ChessHelper.IsWithinBoardRange(currentCell.RankNumber - 1, currentCell.FileNumber + 0))
                ChessBoardCell[currentCell.RankNumber - 1, currentCell.FileNumber + 0].IsLegalMove = true;
            if (ChessHelper.IsWithinBoardRange(currentCell.RankNumber - 1, currentCell.FileNumber - 1))
                ChessBoardCell[currentCell.RankNumber - 1, currentCell.FileNumber - 1].IsLegalMove = true;
            if (ChessHelper.IsWithinBoardRange(currentCell.RankNumber - 1, currentCell.FileNumber + 1))
                ChessBoardCell[currentCell.RankNumber - 1, currentCell.FileNumber + 1].IsLegalMove = true;
        }
    }
}
