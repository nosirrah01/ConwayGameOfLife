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

        [Test]
        public void Test_GeneratingNextGridFromDead3By3Grid()
        {
            //arrange
            Cell[,] passedInCellMatrix = new Cell[3, 3];
            passedInCellMatrix[0, 0] = new Cell();
            passedInCellMatrix[0, 1] = new Cell();
            passedInCellMatrix[0, 2] = new Cell();
            passedInCellMatrix[1, 0] = new Cell();
            passedInCellMatrix[1, 1] = new Cell();
            passedInCellMatrix[1, 2] = new Cell();
            passedInCellMatrix[2, 0] = new Cell();
            passedInCellMatrix[2, 1] = new Cell();
            passedInCellMatrix[2, 2] = new Cell();

            //act
            Grid grid = new Grid(passedInCellMatrix);

            //assert
            Assert.That(grid.GenerateNextGrid().CellMatrix[0, 0].IsLive, Is.EqualTo(false));
            Assert.That(grid.GenerateNextGrid().CellMatrix[0, 1].IsLive, Is.EqualTo(false));
            Assert.That(grid.GenerateNextGrid().CellMatrix[0, 2].IsLive, Is.EqualTo(false));
            Assert.That(grid.GenerateNextGrid().CellMatrix[1, 0].IsLive, Is.EqualTo(false));
            Assert.That(grid.GenerateNextGrid().CellMatrix[1, 1].IsLive, Is.EqualTo(false));
            Assert.That(grid.GenerateNextGrid().CellMatrix[1, 2].IsLive, Is.EqualTo(false));
            Assert.That(grid.GenerateNextGrid().CellMatrix[2, 0].IsLive, Is.EqualTo(false));
            Assert.That(grid.GenerateNextGrid().CellMatrix[2, 1].IsLive, Is.EqualTo(false));
            Assert.That(grid.GenerateNextGrid().CellMatrix[2, 2].IsLive, Is.EqualTo(false));

        }

        [Test]
        public void Test_GeneratingNextGridFrom5By5GridBlinker()
        {
            // passed in:
            // . . . . .
            // . . . . .
            // . t t t .
            // . . . . .
            // . . . . .
            // expected out:
            // . . . . .
            // . . t . .
            // . . t . .
            // . . t . .
            // . . . . .

            //arrange
            Cell[,] passedInCellMatrix = new Cell[5, 5];
            passedInCellMatrix[0, 0] = new Cell();
            passedInCellMatrix[0, 1] = new Cell();
            passedInCellMatrix[0, 2] = new Cell();
            passedInCellMatrix[0, 3] = new Cell();
            passedInCellMatrix[0, 4] = new Cell();
            passedInCellMatrix[1, 0] = new Cell();
            passedInCellMatrix[1, 1] = new Cell();
            passedInCellMatrix[1, 2] = new Cell();
            passedInCellMatrix[1, 3] = new Cell();
            passedInCellMatrix[1, 4] = new Cell();
            passedInCellMatrix[2, 0] = new Cell();
            passedInCellMatrix[2, 1] = new Cell(true);
            passedInCellMatrix[2, 2] = new Cell(true);
            passedInCellMatrix[2, 3] = new Cell(true);
            passedInCellMatrix[2, 4] = new Cell();
            passedInCellMatrix[3, 0] = new Cell();
            passedInCellMatrix[3, 1] = new Cell();
            passedInCellMatrix[3, 2] = new Cell();
            passedInCellMatrix[3, 3] = new Cell();
            passedInCellMatrix[3, 4] = new Cell();
            passedInCellMatrix[4, 0] = new Cell();
            passedInCellMatrix[4, 1] = new Cell();
            passedInCellMatrix[4, 2] = new Cell();
            passedInCellMatrix[4, 3] = new Cell();
            passedInCellMatrix[4, 4] = new Cell();

            //act
            Grid grid = new Grid(passedInCellMatrix);

            //assert
            Assert.That(grid.GenerateNextGrid().CellMatrix[0, 0].IsLive, Is.EqualTo(false));
            Assert.That(grid.GenerateNextGrid().CellMatrix[0, 1].IsLive, Is.EqualTo(false));
            Assert.That(grid.GenerateNextGrid().CellMatrix[0, 2].IsLive, Is.EqualTo(false));
            Assert.That(grid.GenerateNextGrid().CellMatrix[0, 3].IsLive, Is.EqualTo(false));
            Assert.That(grid.GenerateNextGrid().CellMatrix[0, 4].IsLive, Is.EqualTo(false));
            Assert.That(grid.GenerateNextGrid().CellMatrix[1, 0].IsLive, Is.EqualTo(false));
            Assert.That(grid.GenerateNextGrid().CellMatrix[1, 1].IsLive, Is.EqualTo(false));
            Assert.That(grid.GenerateNextGrid().CellMatrix[1, 2].IsLive, Is.EqualTo(true));

            // this one fails
            Assert.That(grid.GenerateNextGrid().CellMatrix[1, 3].IsLive, Is.EqualTo(false));

            Assert.That(grid.GenerateNextGrid().CellMatrix[1, 4].IsLive, Is.EqualTo(false));
            Assert.That(grid.GenerateNextGrid().CellMatrix[2, 0].IsLive, Is.EqualTo(false));
            Assert.That(grid.GenerateNextGrid().CellMatrix[2, 1].IsLive, Is.EqualTo(false));
            Assert.That(grid.GenerateNextGrid().CellMatrix[2, 2].IsLive, Is.EqualTo(true));
            
            // this one fails
            Assert.That(grid.GenerateNextGrid().CellMatrix[2, 3].IsLive, Is.EqualTo(false));
            
            Assert.That(grid.GenerateNextGrid().CellMatrix[2, 4].IsLive, Is.EqualTo(false));
            Assert.That(grid.GenerateNextGrid().CellMatrix[3, 0].IsLive, Is.EqualTo(false));
            Assert.That(grid.GenerateNextGrid().CellMatrix[3, 1].IsLive, Is.EqualTo(false));
            
            // this one fails
            Assert.That(grid.GenerateNextGrid().CellMatrix[3, 2].IsLive, Is.EqualTo(true));
            
            Assert.That(grid.GenerateNextGrid().CellMatrix[3, 3].IsLive, Is.EqualTo(false));
            Assert.That(grid.GenerateNextGrid().CellMatrix[3, 4].IsLive, Is.EqualTo(false));
            Assert.That(grid.GenerateNextGrid().CellMatrix[4, 0].IsLive, Is.EqualTo(false));
            Assert.That(grid.GenerateNextGrid().CellMatrix[4, 1].IsLive, Is.EqualTo(false));
            Assert.That(grid.GenerateNextGrid().CellMatrix[4, 2].IsLive, Is.EqualTo(false));
            Assert.That(grid.GenerateNextGrid().CellMatrix[4, 3].IsLive, Is.EqualTo(false));
            Assert.That(grid.GenerateNextGrid().CellMatrix[4, 4].IsLive, Is.EqualTo(false));
        }
    }
}