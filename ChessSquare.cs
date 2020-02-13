using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    internal class ChessSquare
    {
        public bool IsBlack { get; }
        public bool IsOccupied { get; set; }
        private static int squareCount = 0;
        private static int rowCount = 0;
        public ChessPiece ChessPiece { get; set; }

        public ChessSquare()
        {
            squareCount++;
            if (squareCount % 2 == 0 && rowCount % 2 == 0)
            {
                this.IsBlack = true;
            }
            else if (squareCount % 2 == 1 && rowCount % 2 == 0)
            {
                this.IsBlack = false;
            }
            else if (squareCount % 2 == 1 && rowCount % 2 == 1)
            {
                this.IsBlack = true;
            }
            else if (squareCount % 2 == 0 && rowCount % 2 == 1)
            {
                this.IsBlack = false;
            }
            if (squareCount % 8 == 0)
            {
                rowCount++;
            }
        }
    }
}