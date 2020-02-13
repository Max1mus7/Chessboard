using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    internal class ChessRook : ChessPiece
    {
        public ChessRook()
        {
            Name = "Rook";
            IsAlive = true;
            if (piecesCreated == 1 || piecesCreated == 8)
            {
                VerticalPosition = 0;
            }
            if (piecesCreated == 25 || piecesCreated == 32)
            {
                VerticalPosition = 7;
            }
        }

        public override void Move(int coordinate1, int coordinate2)
        {
        }
    }
}