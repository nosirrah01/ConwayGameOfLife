using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwayLogicLibrary
{
    public class Grid
    {
        private int height;
        private int width;

        Cell[,] cellMatrix;
        public Cell[,] CellMatrix
        {
            get { return cellMatrix; }
            set { cellMatrix = value; }
        }
        public Grid(int height, int width)
        {
            this.height = height;
            this.width = width;
            Cell[,] cellMatrix = new Cell[height, width];
            for (int col = 0; col < cellMatrix.GetLength(0); col++)
                for (int row = 0; row < cellMatrix.GetLength(1); row++)
                    cellMatrix[col, row] = new Cell();
            this.cellMatrix = cellMatrix;
        }

        public Grid(Cell[,] cellMatrix)
        {
            //.GetLength(0) for the number of rows, .GetLength(1) for the number of collumns

            height = cellMatrix.GetLength(0);
            width = cellMatrix.GetLength(1);
            this.cellMatrix = cellMatrix;
        }

        public override bool Equals(object obj)
        {
            if ((this.height == ((Grid)obj).height) && (this.width == ((Grid)obj).width))
            {
                for (int i = 0; i < this.cellMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < this.cellMatrix.GetLength(1); j++)
                    {
                        if (!this.cellMatrix[i, j].Equals(((Grid)obj).cellMatrix[i, j]))
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            else
                return false;
        }
    }
}
