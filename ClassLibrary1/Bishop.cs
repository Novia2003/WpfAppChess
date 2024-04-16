using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Bishop : ChessPiece
    {
        public Bishop(string color, char column, int row) : base(color, column, row)
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

            if (Math.Abs(newColumn - Column) == Math.Abs(newRow - Row))
            {
                return true;
            }

            return false;
        }
    }
}
