namespace ClassLibrary1
{
    public class Rook : ChessPiece
    {
        public Rook(string color, char column, int row) : base(color, column, row)
        {
        }

        protected override bool IsMovePossible(char newColumn, int newRow)
        {
            if (newColumn < 'a' || newColumn > 'h' || newRow < 1 || newRow > 8)
            {
                return false;
            }

            if (newColumn == Column && newRow == Row)
            {
                return false;
            }

            if (newColumn == Column || newRow == Row)
            {
                return true;
            }

            return false;
        }
    }
}
