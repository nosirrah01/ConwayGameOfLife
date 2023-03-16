using NUnit.Framework;
using ConwayLogicLibrary;

namespace ConwayNUnitTests
{
    public class CellTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_InstantiateDeadCell()
        {
            Cell cell = new Cell();
            Assert.That(cell.IsLive, Is.EqualTo(false));
        }

        [Test]
        public void Test_InstantiateLiveCell()
        {
            Cell cell = new Cell(true);
            Assert.That(cell.IsLive, Is.EqualTo(true));
        }

        [Test]
        public void Test_ChangeLiveStateOfCell()
        {
            //arrange
            Cell cell = new Cell(true);

            //act
            cell.IsLive = false;

            //assert
            Assert.That(cell.IsLive, Is.EqualTo(false));
        }

        [Test]
        public void Test_OverrideEqualsMethod()
        {
            //arrange
            Cell cell1 = new Cell(true);
            Cell cell2 = new Cell(true);

            //act
            bool cellsAreEqual = cell1.Equals(cell2);

            //assert
            Assert.That(cellsAreEqual, Is.EqualTo(true));
        }
    }
}