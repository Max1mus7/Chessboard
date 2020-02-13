using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    internal class ChessPawn : ChessPiece
    {
        public bool FirstMoveTaken { get; set; }

        public ChessPawn()
        {
            Name = "Pawn";
            IsAlive = true;
            if (piecesCreated > 8 && piecesCreated < 17)
            {
                VerticalPosition = 1;
            }
            else if (piecesCreated >= 17 && piecesCreated < 25)
            {
                VerticalPosition = 6;
            }
            FirstMoveTaken = false;
        }

        public override void Move(int coordinate1, int coordinate2)
        {
        }
    }
}