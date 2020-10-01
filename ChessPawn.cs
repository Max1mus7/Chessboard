using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    internal class ChessPawn : ChessPiece
    {
        public bool FirstMoveTaken { get; set; }
        public ChessPawn()
        {
            Name = "Pawn";
            if (piecesCreated > 8 && piecesCreated < 17)
            {
                VerticalPosition = 1;
            }
            else if (piecesCreated >= 17 && piecesCreated < 25)
            {
                VerticalPosition = 6;
            }
            FirstMoveTaken = false;
        }

        public override void Move(int x, int y, ChessBoard chessBoard)
        {
            if(!FirstMoveTaken)
            {
                if(y <= VerticalPosition + 2 && y > VerticalPosition)
                {
                    if(!chessBoard.GetChessSquare(x,y).IsOccupied)
                    {
                        ChessPawn newPawn = (ChessPawn)this.MemberwiseClone();
                        chessBoard.GetChessSquare(x,y).ChessPiece = newPawn;
                        chessBoard.GetChessSquare(HorizontalPosition,VerticalPosition).ChessPiece = null;

                    }
                }
            }
        }
    }
}