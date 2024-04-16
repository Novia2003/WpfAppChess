using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
 public abstract class ChessPiece
    {
        public ChessPiece(string color, char column, int row)
        {
            Color = color;
            Column = column;
            Row = row;
        }

        public string Color { get; set; }
        public char Column { get; set; }
        public int Row { get; set; }

        public virtual void MakeMove(char newColumn, int newRow)
        {
            if (IsMovePossible(newColumn, newRow))
            {
                Column = newColumn;
                Row = newRow;
            }
            else
            {
                throw new Exception("Невозможно сделать такой ход для данной фигуры");
            }
        }

        protected abstract bool IsMovePossible(char newColumn, int newRow);
    }
}
