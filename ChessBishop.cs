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
            if (piecesCreated == 3 || piecesCreated == 6)
            {
                VerticalPosition = 0;
            }
            if (piecesCreated == 27 || piecesCreated == 30)
            {
                VerticalPosition = 7;
            }
        }

        public override void Move(int x, int y, ChessBoard chessBoard)
        {
        }
    }
}