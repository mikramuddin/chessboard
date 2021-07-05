namespace Chess.ClassLibrary
{
    public class ChessHelper
    {
        const int Size = 8;
        /// <summary>
        /// Helper function to reassign the letter col label into our system File number for ease. 
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static int ChessFileNumber(string inputString)
        {
            int i = 0;
            if (inputString.Length > 0)
            {
                switch (inputString)
                {
                    case "a":
                        i = 1; break;
                    case "b":
                        i = 2; break;
                    case "c":
                        i = 3; break;
                    case "d":
                        i = 4; break;
                    case "e":
                        i = 5; break;
                    case "f":
                        i = 6; break;
                    case "g":
                        i = 7; break;
                    case "h":
                        i = 8; break;
                }
            }
            return i;
        }

        public static string ChessFileLabel(int fileNumber)
        {
            switch (fileNumber)
            {
                case 0:
                    return "a";
                case 1:
                    return "b";
                case 2:
                    return "c";
                case 3:
                    return "d";
                case 4:
                    return "e";
                case 5:
                    return "f";
                case 6:
                    return "g";
                case 7:
                    return "h";
                default:
                    return fileNumber.ToString();
            }
        }

        //public enum ChessFileLabel
        //{
        //    a,b,c,d,e,f,g,h
        //}

        /// <summary>
        /// Rook moves, also a part of Queen moves
        /// </summary>
        /// <param name="currentCell"></param>
        public static void StraightLineMoves(Cell currentCell, Cell[,] ChessBoardCell)
        {
            for (int r = 1; r < Size; r++)
            {
                if (IsWithinBoardRange(currentCell.RankNumber + r, currentCell.FileNumber))
                    ChessBoardCell[currentCell.RankNumber + r, currentCell.FileNumber].IsLegalMove = true;

                if (IsWithinBoardRange(currentCell.RankNumber - r, currentCell.FileNumber))
                    ChessBoardCell[currentCell.RankNumber - r, currentCell.FileNumber].IsLegalMove = true;
            }

            for (int f = 1; f < Size; f++)
            {
                if (IsWithinBoardRange(currentCell.RankNumber, currentCell.FileNumber + f))
                    ChessBoardCell[currentCell.RankNumber, currentCell.FileNumber + f].IsLegalMove = true;

                if (IsWithinBoardRange(currentCell.RankNumber, currentCell.FileNumber - f))
                    ChessBoardCell[currentCell.RankNumber, currentCell.FileNumber - f].IsLegalMove = true;
            }
        }

        /// <summary>
        /// Bishop moves, also a part of Queen moves
        /// </summary>
        /// <param name="currentCell"></param>
        public static void DiagonalMoves(Cell currentCell, Cell[,] ChessBoardCell)
        {
            if (IsWithinBoardRange(currentCell.RankNumber + 1, currentCell.FileNumber + 1))
                ChessBoardCell[currentCell.RankNumber + 1, currentCell.FileNumber + 1].IsLegalMove = true;
            if (IsWithinBoardRange(currentCell.RankNumber + 2, currentCell.FileNumber + 2))
                ChessBoardCell[currentCell.RankNumber + 2, currentCell.FileNumber + 2].IsLegalMove = true;
            if (IsWithinBoardRange(currentCell.RankNumber + 3, currentCell.FileNumber + 3))
                ChessBoardCell[currentCell.RankNumber + 3, currentCell.FileNumber + 3].IsLegalMove = true;
            if (IsWithinBoardRange(currentCell.RankNumber + 4, currentCell.FileNumber + 4))
                ChessBoardCell[currentCell.RankNumber + 4, currentCell.FileNumber + 4].IsLegalMove = true;
            if (IsWithinBoardRange(currentCell.RankNumber + 5, currentCell.FileNumber + 5))
                ChessBoardCell[currentCell.RankNumber + 5, currentCell.FileNumber + 5].IsLegalMove = true;
            if (IsWithinBoardRange(currentCell.RankNumber + 6, currentCell.FileNumber + 6))
                ChessBoardCell[currentCell.RankNumber + 6, currentCell.FileNumber + 6].IsLegalMove = true;
            if (IsWithinBoardRange(currentCell.RankNumber + 7, currentCell.FileNumber + 7))
                ChessBoardCell[currentCell.RankNumber + 7, currentCell.FileNumber + 7].IsLegalMove = true;


            if (IsWithinBoardRange(currentCell.RankNumber - 1, currentCell.FileNumber + 1))
                ChessBoardCell[currentCell.RankNumber - 1, currentCell.FileNumber + 1].IsLegalMove = true;
            if (IsWithinBoardRange(currentCell.RankNumber - 2, currentCell.FileNumber + 2))
                ChessBoardCell[currentCell.RankNumber - 2, currentCell.FileNumber + 2].IsLegalMove = true;
            if (IsWithinBoardRange(currentCell.RankNumber - 3, currentCell.FileNumber + 3))
                ChessBoardCell[currentCell.RankNumber - 3, currentCell.FileNumber + 3].IsLegalMove = true;
            if (IsWithinBoardRange(currentCell.RankNumber - 4, currentCell.FileNumber + 4))
                ChessBoardCell[currentCell.RankNumber - 4, currentCell.FileNumber + 4].IsLegalMove = true;
            if (IsWithinBoardRange(currentCell.RankNumber - 5, currentCell.FileNumber + 5))
                ChessBoardCell[currentCell.RankNumber - 5, currentCell.FileNumber + 5].IsLegalMove = true;
            if (IsWithinBoardRange(currentCell.RankNumber - 6, currentCell.FileNumber + 6))
                ChessBoardCell[currentCell.RankNumber - 6, currentCell.FileNumber + 6].IsLegalMove = true;
            if (IsWithinBoardRange(currentCell.RankNumber - 7, currentCell.FileNumber + 7))
                ChessBoardCell[currentCell.RankNumber - 7, currentCell.FileNumber + 7].IsLegalMove = true;

            if (IsWithinBoardRange(currentCell.RankNumber + 1, currentCell.FileNumber - 1))
                ChessBoardCell[currentCell.RankNumber + 1, currentCell.FileNumber - 1].IsLegalMove = true;
            if (IsWithinBoardRange(currentCell.RankNumber + 2, currentCell.FileNumber - 2))
                ChessBoardCell[currentCell.RankNumber + 2, currentCell.FileNumber - 2].IsLegalMove = true;
            if (IsWithinBoardRange(currentCell.RankNumber + 3, currentCell.FileNumber - 3))
                ChessBoardCell[currentCell.RankNumber + 3, currentCell.FileNumber - 3].IsLegalMove = true;
            if (IsWithinBoardRange(currentCell.RankNumber + 4, currentCell.FileNumber - 4))
                ChessBoardCell[currentCell.RankNumber + 4, currentCell.FileNumber - 4].IsLegalMove = true;
            if (IsWithinBoardRange(currentCell.RankNumber + 5, currentCell.FileNumber - 5))
                ChessBoardCell[currentCell.RankNumber + 5, currentCell.FileNumber - 5].IsLegalMove = true;
            if (IsWithinBoardRange(currentCell.RankNumber + 6, currentCell.FileNumber - 6))
                ChessBoardCell[currentCell.RankNumber + 6, currentCell.FileNumber - 6].IsLegalMove = true;
            if (IsWithinBoardRange(currentCell.RankNumber + 7, currentCell.FileNumber - 7))
                ChessBoardCell[currentCell.RankNumber + 7, currentCell.FileNumber - 7].IsLegalMove = true;


            if (IsWithinBoardRange(currentCell.RankNumber - 1, currentCell.FileNumber - 1))
                ChessBoardCell[currentCell.RankNumber - 1, currentCell.FileNumber - 1].IsLegalMove = true;
            if (IsWithinBoardRange(currentCell.RankNumber - 2, currentCell.FileNumber - 2))
                ChessBoardCell[currentCell.RankNumber - 2, currentCell.FileNumber - 2].IsLegalMove = true;
            if (IsWithinBoardRange(currentCell.RankNumber - 3, currentCell.FileNumber - 3))
                ChessBoardCell[currentCell.RankNumber - 3, currentCell.FileNumber - 3].IsLegalMove = true;
            if (IsWithinBoardRange(currentCell.RankNumber - 4, currentCell.FileNumber - 4))
                ChessBoardCell[currentCell.RankNumber - 4, currentCell.FileNumber - 4].IsLegalMove = true;
            if (IsWithinBoardRange(currentCell.RankNumber - 5, currentCell.FileNumber - 5))
                ChessBoardCell[currentCell.RankNumber - 5, currentCell.FileNumber - 5].IsLegalMove = true;
            if (IsWithinBoardRange(currentCell.RankNumber - 6, currentCell.FileNumber - 6))
                ChessBoardCell[currentCell.RankNumber - 6, currentCell.FileNumber - 6].IsLegalMove = true;
            if (IsWithinBoardRange(currentCell.RankNumber - 7, currentCell.FileNumber - 7))
                ChessBoardCell[currentCell.RankNumber - 7, currentCell.FileNumber - 7].IsLegalMove = true;
        }

        /// <summary>
        /// Simple check if or not to mark this cell due to out of bounds
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool IsWithinBoardRange(int x, int y)
        {
            if (x >= 0 && x < Size)
                if (y >= 0 && y < Size)
                    return true;

            return false;
        }
    }
}
