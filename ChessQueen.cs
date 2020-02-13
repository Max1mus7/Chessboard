using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    internal class ChessQueen : ChessPiece
    {
        public ChessQueen()
        {
            Name = "Queen";
            IsAlive = true;
            if (piecesCreated == 4)
            {
                VerticalPosition = 0;
            }
            if (piecesCreated == 28)
            {
                VerticalPosition = 7;
            }
        }

        public override void Move(int coordinate1, int coordinate2, ChessBoard chessBoard)
        {
        }
    }
}