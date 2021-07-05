using Chess.ClassLibrary;
using System;
using System.Collections.Generic;

namespace ChessMock
{
    class Program
    {

        static Board myChess = new Board();

        static void Main(string[] args)
        {
            string userinput = ChessConstant.KING; //default

            Console.WriteLine("Hello World to Chess Simulation!");

            userinput = GamePieceSelected();

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
                    userinput = GamePieceSelected();
                }

                //Start Fresh Board
                myChess.Reset();

            } while (true);
        }

        private static string GamePieceSelected()
        {
            List<string> gamePieces = new List<string> { "K", "Q", "R", "B" };
            string userinput;
            while (true) // Loop for correct user input
            {
                // Obtain Chess piece for the Board to play with
                Console.Write("Enter the chess piece[K]ing;[Q]ueen;[R]ook;[B]ishop: ");
                userinput = Console.ReadLine().ToUpper();
                if (gamePieces.Contains(userinput)) // Check string
                {
                    break;
                }
            }

            return userinput;
        }

        private static Cell SetPiecePosition()
        {
            // Obtain Chess piece starting position as in a1, f4 etc...
            Console.Write("Enter the chess piece starting position [a-h][1-8] : ");
            //TODO: User input check on length and proper input not 1a or wrong inputs
            char[] startingPosition = Console.ReadLine().ToCharArray();

            int fileLocation = ChessHelper.ChessFileNumber(startingPosition[0].ToString().ToLower()) - 1;

            int rankLocation = int.Parse(startingPosition[1].ToString()) - 1;

            //This position is now occupied by this chess piece
            myChess.ChessBoardCell[rankLocation, fileLocation].IsOccupied = true;
            return myChess.ChessBoardCell[rankLocation, fileLocation];
        }

    }
}
