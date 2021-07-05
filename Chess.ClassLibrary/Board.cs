using System;

namespace Chess.ClassLibrary
{
    /// <summary>
    /// Construct the Chess Board
    /// Reset the Chess Board
    /// Draw the Chess Board
    /// </summary>
    public class Board
    {
        public int Size { get; set; }
        public string ChessPieceOnPlay { get; set; }
        public Cell[,] ChessBoardCell { get; set; }

        /// <summary>
        /// Constructor which creates the Cell 8x8 
        /// </summary>
        public Board()
        {
            Size = 8;

            ChessPieceOnPlay = String.Empty;

            ChessBoardCell = new Cell[Size,Size];
            //Initialization
            Reset(true);
        }

        /// <summary>
        /// Using this Board object, it will Draw the Board showing 
        /// the Chess Piece and its legally allowed moves on this Board
        /// </summary>
        public void Draw()
        {
            for (int r = Size - 1; r >= 0; r--) //Starting with top rank and moving bottom down
            {
                for (int f = 0; f < Size; f++)  //Starting with left file and moving right 
                {
                    if (this.ChessBoardCell[r, f].IsOccupied)
                        Console.Write("["+ChessPieceOnPlay+"]");
                    else if (this.ChessBoardCell[r, f].IsLegalMove)
                        Console.Write("[  ]");
                    else Console.Write("[{0}{1}]", ChessHelper.ChessFileLabel(f), r+1);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("######Current Board on Display######");
        }

        public void Reset(bool init=false)
        {
            for (int r = 0; r < Size; r++)
            {
                for (int f = 0; f < Size; f++)
                {
                    if (init)
                    {
                        //Do this only when called by Constructor
                        ChessBoardCell[r, f] = new Cell(r, f);
                    }

                    else
                    {
                        this.ChessBoardCell[r, f].IsLegalMove = false;
                        this.ChessBoardCell[r, f].IsOccupied = false;
                    }
                }
            }
        }

        /// <summary>
        /// Takes the chess piece provided to scan theough all possible moves
        /// Takes the currentCell position and sets it legalMove property appropriately,
        /// </summary>
        /// <param name="currentCell"></param>
        /// <param name="chessPiece"></param>
        public void PossibleMoves(Cell currentCell, string chessPiece)
        {
            //Given the chess piece, figure out the all legal chess moves
            switch (chessPiece)
            {
                case "K":
                    KingMoves(currentCell);
                    break;

                case "Q":
                    QueenMoves(currentCell);
                    break;

                case "B":
                    BishopMoves(currentCell);
                    break;

                case "R":
                    RookMoves(currentCell);
                    break;
            }

        }

        private void KingMoves(Cell currentCell)
        {
            PKing piece = new PKing
            {
                ChessBoardCell = ChessBoardCell
            };
            piece.LegalMoves(currentCell);
            ChessPieceOnPlay = piece.Label;

        }

        private void QueenMoves(Cell currentCell)
        {
            PQueen piece = new PQueen
            {
                ChessBoardCell = ChessBoardCell
            };
            piece.LegalMoves(currentCell);
            ChessPieceOnPlay = piece.Label;

        }

        private void RookMoves(Cell currentCell)
        {
            PRook piece = new PRook
            {
                ChessBoardCell = ChessBoardCell
            };
            piece.LegalMoves(currentCell);
            ChessPieceOnPlay = piece.Label;

        }

        private void BishopMoves(Cell currentCell)
        {
            PBishop piece = new PBishop
            {
                ChessBoardCell = ChessBoardCell
            };
            piece.LegalMoves(currentCell);
            ChessPieceOnPlay = piece.Label;

        }
    }
}
