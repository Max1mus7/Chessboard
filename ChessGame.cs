using System;

namespace Chessboard
{
    internal class ChessGame
    {
        private static void Main(string[] args)
        {
            ChessBoard cb = new ChessBoard();
            int count = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    count++;
                    Console.Write(cb.GetChessSquare(i, j).IsOccupied);
                    if (count % 8 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
            count = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    count++;
                    Console.Write(cb.GetChessPiece(i, j));
                    if (count % 8 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
            count = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    count++;
                    Console.Write(cb.GetChessSquare(i, j).IsBlack);
                    if (count % 8 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
            //cb.Move(cb.GetChessPiece(1, 5), 1);
        }
    }
}