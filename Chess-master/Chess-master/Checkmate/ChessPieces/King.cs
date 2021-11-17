using System.Drawing;

namespace Checkmate.ChessPieces
{
    public class King : ChessPiece
    {
        public King(PieceColor pieceColor) : base(pieceColor)
        {
            
            PieceImage = pieceColor == PieceColor.BLACK ? Properties.Resources.BKing : Properties.Resources.WKing;
            hasMoved = false;
        }

        public override void ShowLegalMoves(ChessBoard board, Point location)
        {
            base.ShowLegalMoves(board,location);
            if (!hasMoved)
            {
                if (board.board[location.X, location.Y-1].IsOccupied.Equals(false) && board.board[location.X, location.Y-2].IsOccupied.Equals(false) &&
                    board.board[location.X, location.Y-3].IsOccupied.Equals(false))
                {
                    board.board[location.X, location.Y-4].IsLegal = true;
                    board.board[location.X, location.Y - 4].IsOccupied = false;
                }
                



            }
            if(isSafe(location.X + 1, location.Y)) {
                board.board[location.X + 1, location.Y].IsLegal = true;
            }

            if(isSafe(location.X - 1, location.Y)) {
                board.board[location.X - 1, location.Y].IsLegal = true;
            } 
                            
            if(isSafe(location.X, location.Y + 1)) {
                board.board[location.X, location.Y + 1].IsLegal = true;
            } 
                            
            if(isSafe(location.X, location.Y - 1)) {
                board.board[location.X, location.Y - 1].IsLegal = true;
            }

            if(isSafe(location.X - 1, location.Y - 1)) {
                board.board[location.X - 1, location.Y - 1].IsLegal = true;
            }

            if(isSafe(location.X + 1, location.Y + 1)) {
                board.board[location.X + 1, location.Y + 1].IsLegal = true;
            }

            if(isSafe(location.X + 1, location.Y - 1)) {
                board.board[location.X + 1, location.Y - 1].IsLegal = true;
            }


            if(isSafe(location.X - 1, location.Y + 1)) {
                board.board[location.X - 1, location.Y + 1].IsLegal = true;
            }

        }
    }
}