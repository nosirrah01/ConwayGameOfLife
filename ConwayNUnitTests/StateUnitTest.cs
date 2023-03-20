using NUnit.Framework;
using ConwayLogicLibrary;
using ClassLibrary1;

namespace ConwayNUnitTests
{
    public class StateTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_GetCurrentGridFromState()
        {
            //arrange
            Grid passedInGrid = new Grid(1, 1);
            Grid testGrid = new Grid(1, 1);

            //act
            State state = new State(passedInGrid);

            //assert
            Assert.That(state.CurrentGrid, Is.EqualTo(testGrid));
        }

        /*
        [Test]
        public void Test_GetNextGridFromState()
        {
            //arrange

            Cell[,] currentCellMatrix = new Cell[3, 3];
            currentCellMatrix[0, 0] = new Cell();
            currentCellMatrix[0, 1] = new Cell();
            currentCellMatrix[0, 2] = new Cell();
            currentCellMatrix[1, 0] = new Cell();
            currentCellMatrix[1, 1] = new Cell(true);
            currentCellMatrix[1, 2] = new Cell();
            currentCellMatrix[2, 0] = new Cell();
            currentCellMatrix[2, 1] = new Cell();
            currentCellMatrix[2, 2] = new Cell();

            Cell[,] nextTestCellMatrix = new Cell[3, 3];
            nextTestCellMatrix[0, 0] = new Cell();
            nextTestCellMatrix[0, 1] = new Cell();
            nextTestCellMatrix[0, 2] = new Cell();
            nextTestCellMatrix[1, 0] = new Cell();
            nextTestCellMatrix[1, 1] = new Cell();
            nextTestCellMatrix[1, 2] = new Cell();
            nextTestCellMatrix[2, 0] = new Cell();
            nextTestCellMatrix[2, 1] = new Cell();
            nextTestCellMatrix[2, 2] = new Cell();

            Grid currentGrid = new Grid(currentCellMatrix);
            Grid testNextGrid = new Grid(nextTestCellMatrix);

            //act
            State state = new State(currentGrid);

            //assert
            Assert.That(state.NextGrid.CellMatrix[1, 1].IsLive, Is.EqualTo(false));
        }
        */
    }
}