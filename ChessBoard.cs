using System;

namespace Chessboard
{
    public class ChessBoard
    {
        //Declare fields
        //2-D array of ChessSquares that will make up the chessboard
        public ChessSquare[,] Chessboard { get; set; }

        public ChessBoard()
        {
            Chessboard = new ChessSquare[8, 8];
            //creates a loop to access all areas of Chessboard array
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    //instantiates the board
                    Chessboard[i, j] = new ChessSquare();
                }
            }
        }
        //method that moves a pawn and checks to make sure move is valid
        public void MovePawn(ChessPawn pawn, int verticalMotion, int horizontalMotion)
        {
            if (pawn.Color.Equals("Black", StringComparison.OrdinalIgnoreCase))
            {
                verticalMotion = verticalMotion;

            }
            else
            {
                verticalMotion = -verticalMotion;
            }

            Console.WriteLine("Pawn entered");
            if (!((ChessPawn)pawn).FirstMoveTaken)
            {
                if (verticalMotion > 2)
                {
                    throw new System.InvalidOperationException("Pawns cannot move that far vertically, even on the first move.");
                }
                else if (verticalMotion < 0)
                {
                    throw new System.InvalidOperationException("Pawns cannot move backwards.");
                }
                else if(horizontalMotion < -1 || horizontalMotion > 1)
                {
                    throw new System.InvalidOperationException("Pawns can never move more than one space horizontally.")
                }
                else if (horizontalMotion != 0 && !Chessboard[pawn.VerticalPosition + verticalMotion, pawn.HorizontalPosition + horizontalMotion].IsOccupied || 
                    Chessboard[pawn.VerticalPosition + verticalMotion , pawn.HorizontalPosition + horizontalMotion].ChessPiece != null &&
                    Chessboard[pawn.VerticalPosition + verticalMotion, pawn.HorizontalPosition + horizontalMotion].ChessPiece.Color.Equals(pawn.Color))
                {
                    throw new System.InvalidOperationException("Pawns cannot move horizontally without attacking a piece of the opposite color.");
                }
                else
                {
                    if(Chessboard[pawn.VerticalPosition + verticalMotion, pawn.HorizontalPosition + ])
                    Chessboard[pawn.VerticalPosition + verticalMotion, pawn.HorizontalPosition + horizontalMotion].ChessPiece = Chessboard[pawn.VerticalPosition, pawn.HorizontalPosition].ChessPiece;
                    Chessboard[pawn.VerticalPosition, pawn.HorizontalPosition].ChessPiece = null;
                    Chessboard[pawn.VerticalPosition, pawn.HorizontalPosition].IsOccupied = false;
                }
            }
        }
        public void MoveKnight(ChessKnight knight, int verticalMotion, int horizontalMotion)
        {
            if (knight.Color.Equals("Black", StringComparison.OrdinalIgnoreCase))
            {
                verticalMotion = verticalMotion;

            }
            else
            {
                verticalMotion = -verticalMotion;
            }
        }
    }
}