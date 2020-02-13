using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    public abstract class ChessPiece
    {
        public string Name { get; set; }
        public bool IsAlive { get; set; }
        public int VerticalPosition { get; set; }
        public int HorizontalPosition { get; set; }
        public string Color { get; }
        public static int piecesCreated = 0;

        public ChessPiece()
        {
            piecesCreated++;
            if (piecesCreated < 17)
            {
                Color = "Black";
            }
            else
            {
                Color = "White";
            }
            HorizontalPosition = (piecesCreated - 1) % 8;
        }

        public abstract void Move(int coordinate1, int coordinate2, ChessBoard chessBoard);

        public void Defeat(ChessPiece c)
        {
            c.IsAlive = false;
        }

        public int GetPiecesCreated()
        {
            return piecesCreated;
        }

        public override string ToString()
        {
            return Color[0].ToString() + Name[0].ToString();
        }
    }
}