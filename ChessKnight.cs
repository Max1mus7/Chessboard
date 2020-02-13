using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    internal class ChessKnight : ChessPiece
    {
        public ChessKnight()
        {
            Name = "Knight";
            IsAlive = true;
            if (piecesCreated == 2 || piecesCreated == 7)
            {
                VerticalPosition = 0;
            }
            if (piecesCreated == 26 || piecesCreated == 31)
            {
                VerticalPosition = 7;
            }
        }

        public override void Move(int coordinate1, int coordinate2, ChessBoard chessBoard)
        {
        }
    }
}