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
            for (int row = 0; row < cellMatrix.GetLength(0); row++)
                for (int col = 0; col < cellMatrix.GetLength(1); col++)
                    cellMatrix[row, col] = new Cell();
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

        public Grid GenerateNextGrid()
        {
            //Cell[,] nextCellMatrix = GenerateNextCellMatrix();

            Grid nextGrid = new Grid(cellMatrix);
            bool? n1 = null;
            bool? n2 = null;
            bool? n3 = null;
            bool? n4 = null;
            bool? n5 = null;
            bool? n6 = null;
            bool? n7 = null;
            bool? n8 = null;
            for (int row = 0; row < nextGrid.CellMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < nextGrid.CellMatrix.GetLength(1); col++)
                {
                    n1 = null;
                    n2 = null;
                    n3 = null;
                    n4 = null;
                    n5 = null;
                    n6 = null;
                    n7 = null;
                    n8 = null;

                    if (row != 0 && col != 0)
                        n1 = cellMatrix[row - 1, col - 1].IsLive;
                    if (row != 0)
                        n2 = cellMatrix[row - 1, col].IsLive;
                    if (row != 0 && col != cellMatrix.GetLength(1) - 1)
                        n3 = cellMatrix[row - 1, col + 1].IsLive;
                    if (col != 0)
                        n4 = cellMatrix[row, col - 1].IsLive;
                    if (col != cellMatrix.GetLength(1) - 1)
                        n5 = cellMatrix[row, col + 1].IsLive;
                    if (row != cellMatrix.GetLength(0) - 1 && col != 0)
                        n6 = cellMatrix[row + 1, col - 1].IsLive;
                    if (row != cellMatrix.GetLength(0) - 1)
                        n7 = cellMatrix[row + 1, col].IsLive;
                    if (row != cellMatrix.GetLength(0) - 1 && col != cellMatrix.GetLength(1) - 1)
                        n8 = cellMatrix[row + 1, col + 1].IsLive;

                    nextGrid.CellMatrix[row, col].ApplyRulesToCell(n1, n2, n3, n4, n5, n6, n7, n8);
                }
            }

            return nextGrid;
        }

        private Cell[,] GenerateNextCellMatrix()
        {
            Cell[,] nextCellMatrix = new Cell[height, width];
            for (int row = 0; row < nextCellMatrix.GetLength(0); row++)
                for (int col = 0; col < nextCellMatrix.GetLength(1); col++)
                    nextCellMatrix[row, col].IsLive = cellMatrix[row, col].IsLive;
            return nextCellMatrix;
        }
    }
}
