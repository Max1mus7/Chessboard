using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    public class ChessKnight : ChessPiece
    {
        public ChessKnight()
        {
            Name = "Knight";
            IsAlive = true;
            if (PiecesCreated == 2 || PiecesCreated == 7)
            {
                HorizontalPosition = 0;
            }
            if (PiecesCreated == 26 || PiecesCreated == 31)
            {
                HorizontalPosition = 7;
            }
        }
    }
}