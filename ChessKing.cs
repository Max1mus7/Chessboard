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
            if (PiecesCreated == 5)
            {
                HorizontalPosition = 0;
            }
            if (PiecesCreated == 29)
            {
                HorizontalPosition = 7;
            }
        }
    }
}