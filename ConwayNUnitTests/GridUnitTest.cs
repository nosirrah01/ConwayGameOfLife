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
        public void Test_GettingCellMatrixFromDeadGrid()
        {
            //arrange
            Cell[,] testCellMatrix = new Cell[20, 25];
            for (int col = 0; col < testCellMatrix.GetLength(0); col++)
                for (int row = 0; row < testCellMatrix.GetLength(1); row++)
                    testCellMatrix[col, row] = new Cell();

            int height = 20;
            int width = 25;

            //act
            Grid grid = new Grid(height, width);

            //assert
            Assert.That(grid.CellMatrix, Is.EqualTo(testCellMatrix));
        }

        [Test]
        public void Test_GettingCellMatrixFromPopulatedGrid()
        {
            //arrange
            Cell[,] passedInCellMatrix = new Cell[2, 3];
            passedInCellMatrix[0, 0] = new Cell(true);
            passedInCellMatrix[0, 1] = new Cell();
            passedInCellMatrix[0, 2] = new Cell(true);
            passedInCellMatrix[1, 0] = new Cell();
            passedInCellMatrix[1, 1] = new Cell(true);
            passedInCellMatrix[1, 2] = new Cell();

            Cell[,] testCellMatrix = new Cell[2, 3];
            testCellMatrix[0, 0] = new Cell(true);
            testCellMatrix[0, 1] = new Cell();
            testCellMatrix[0, 2] = new Cell(true);
            testCellMatrix[1, 0] = new Cell();
            testCellMatrix[1, 1] = new Cell(true);
            testCellMatrix[1, 2] = new Cell();

            //act
            Grid grid = new Grid(passedInCellMatrix);

            //assert
            Assert.That(grid.CellMatrix, Is.EqualTo(testCellMatrix));
        }
    }
}