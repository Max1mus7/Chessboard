using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    public class ChessPawn : ChessPiece
    {
        public bool FirstMoveTaken { get; set; }
        public ChessPawn()
        {
            Name = "Pawn";
            if (PiecesCreated > 8 && PiecesCreated < 17)
            {
                HorizontalPosition = 1;
            }
            else if (PiecesCreated >= 17 && PiecesCreated < 25)
            {
                HorizontalPosition = 6;
            }
            FirstMoveTaken = false;
        }
    }
}