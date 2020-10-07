using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    internal class ChessBishop : ChessPiece
    {
        public ChessBishop()
        {
            Name = "Bishop";
            IsAlive = true;
            if (PiecesCreated == 3 || PiecesCreated == 6)
            {
                HorizontalPosition = 0;
            }
            if (PiecesCreated == 27 || PiecesCreated == 30)
            {
                HorizontalPosition = 7;
            }
        }

    }
}