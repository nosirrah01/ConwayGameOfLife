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
        }
    }
}
