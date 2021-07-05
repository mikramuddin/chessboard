using Chess.ClassLibrary;
using System;

namespace ChessMock
{
    class Program
    {

        static Board myChess = new Board();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World to Chess Simulation!");

            // Obtain Chess piece for the Board to play with
            Console.WriteLine("Enter the chess piece [K]ing; [Q]ueen; [R]ook; [B]ishop");
            //TODO: Ensure for only K,Q,R,B as options capturing User error
            string userinput = Console.ReadLine().ToUpper();

            do
            {               
                //Obtain which piece and where is the starting position
                //providing the actual cell context for usage
                Cell currentCell = SetPiecePosition();

                //Show all legal moves
                myChess.PossibleMoves(currentCell, userinput);

                //Draw the Board showing the piece and its legally allowed moves
                myChess.Draw();

                //Move the same piece to next position
                Console.WriteLine("Play next position with same chess piece. Enter to continue or Press [Y/N]");
                if (Console.ReadLine().ToLower().Equals("n"))
                {
                    // Obtain next Chess piece for the Board to play with
                    Console.WriteLine("Enter the chess piece [K]ing; [Q]ueen; [R]ook; [B]ishop");
                    //TODO: Ensure for only K,Q,R,B as options capturing User error
                    userinput = Console.ReadLine().ToUpper(); 
                }

                //Start Fresh Board
                myChess.Reset();

            } while (true);
        }

        private static Cell SetPiecePosition()
        {
            // Obtain Chess piece starting File position
            Console.WriteLine("Enter the chess piece File number [a-h]");
            string colLabel = Console.ReadLine();
            //TODO: Ensure for only letters a thru h as options capturing User error
            int fileLocation = ChessHelper.ChessFileNumber(colLabel.ToLower()) - 1;

            // Obtain Chess piece starting Rank position
            Console.WriteLine("and Rank number [1-8]");
            //TODO: Ensure for only numbers 1 through 8 as options capturing User error
            int rankLocation = int.Parse(Console.ReadLine()) - 1; 

            //This position is now occupied by this chess piece
            myChess.ChessBoardCell[rankLocation, fileLocation].IsOccupied = true;
            return myChess.ChessBoardCell[rankLocation, fileLocation];
        }

    }
}
