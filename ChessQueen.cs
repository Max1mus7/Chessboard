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
            if (PiecesCreated == 4)
            {
                HorizontalPosition = 0;
            }
            if (PiecesCreated == 28)
            {
                HorizontalPosition = 7;
            }
        }
    }
}