using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    internal class ChessKing : ChessPiece
    {
        public ChessKing()
        {
            Name = "King";
            IsAlive = true;
            if (piecesCreated == 5)
            {
                VerticalPosition = 0;
            }
            if (piecesCreated == 29)
            {
                VerticalPosition = 7;
            }
        }

        public override void Move(int coordinate1, int coordinate2)
        {
        }
    }
}