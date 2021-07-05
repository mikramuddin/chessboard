namespace Chess.ClassLibrary
{
    public class Cell
    {
        public int RankNumber { get; set; }
        
        public int FileNumber { get; set; }

        public bool IsOccupied { get; set; }

        public bool IsLegalMove { get; set; }

        public Cell(int rank, int file)
        {
            RankNumber = rank;
            FileNumber = file;
        }

    }
}
