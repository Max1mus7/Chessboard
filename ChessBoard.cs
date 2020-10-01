using System;
using System.Collections.Generic;
using System.Text;

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
                    //creates the board and fills it with pieces
                    Chessboard[i, j] = new ChessSquare();
                    if (i < 2 || i > 5)
                    {
                        Chessboard[i, j].IsOccupied = true;
                        //places pawns
                        if (i == 1 || i == 6)
                        {
                            ChessPiece cp = new ChessPawn();
                            Chessboard[i, j].ChessPiece = cp;
                        }
                        //places other pieces
                        else if (i == 0 || i == 7)
                        {
                            //places rooks
                            if (j == 0 || j == 7)
                            {
                                ChessPiece cp = new ChessRook();
                                Chessboard[i, j].ChessPiece = cp;
                            }
                            //places knights
                            if (j == 1 || j == 6)
                            {
                                ChessPiece cp = new ChessKnight();
                                Chessboard[i, j].ChessPiece = cp;
                            }
                            //places bishops
                            if (j == 2 || j == 5)
                            {
                                ChessPiece cp = new ChessBishop();
                                Chessboard[i, j].ChessPiece = cp;
                            }
                            //places queens
                            if (j == 3)
                            {
                                ChessPiece cp = new ChessQueen();
                                Chessboard[i, j].ChessPiece = cp;
                            }
                            //places kings
                            if (j == 4)
                            {
                                ChessPiece cp = new ChessKing();
                                Chessboard[i, j].ChessPiece = cp;
                            }
                        }
                    }
                    else
                    {
                        Chessboard[i, j].IsOccupied = false;
                    }
                }
            }
        }

        public ChessSquare[,] GetChessboard()
        {
            return Chessboard;
        }

        public ChessSquare GetChessSquare(int index1, int index2)
        {
            return Chessboard[index1, index2];
        }

        public ChessPiece GetChessPiece(int index1, int index2)
        {
            try
            {
                return Chessboard[index1, index2].ChessPiece;
            }
            catch (NullReferenceException)
            {
                return null;
            }
        }
    }
}