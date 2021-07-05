using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.ClassLibrary
{
    public abstract class Piece
    {
        public string Label { get; set; }

        public Cell[,] ChessBoardCell { get; set; }

        public abstract void LegalMoves(Cell currentCell);

    }
}
