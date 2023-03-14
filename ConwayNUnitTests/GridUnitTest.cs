using NUnit.Framework;
using ConwayLogicLibrary;

namespace ConwayNUnitTests
{
    public class GridTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            int height = 20;
            int width = 25;
            Grid grid = new Grid(height, width);
            Cell[,] cells = new Cell[20,25];
            for (int col = 0; col < cells.GetLength(0); col++)
                for (int row = 0; row < cells.GetLength(1); row++)
                    cells[col, row] =  new Cell();

            Assert.That(grid.CellMatrix, Is.EqualTo(cells));
        }
    }
}