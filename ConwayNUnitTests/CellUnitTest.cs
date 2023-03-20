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

        [Test]
        public void Test_ApplyRulesToLiveCellWith8DeadNeighbors()
        {
            //arrange
            Cell cell = new Cell(true);

            //act
            cell.ApplyRulesToCell(false, false, false, false, false, false, false, false);

            //assert
            Assert.That(cell.IsLive, Is.EqualTo(false));
        }

        [Test]
        public void Test_ApplyRulesToLiveCellWith1LiveNeighborAnd7Dead()
        {
            //arrange
            Cell cell = new Cell(true);

            //act
            cell.ApplyRulesToCell(true, false, false, false, false, false, false, false);

            //assert
            Assert.That(cell.IsLive, Is.EqualTo(false));
        }

        [Test]
        public void Test_ApplyRulesToLiveCellWith2LiveNeighborsAnd6Dead()
        {
            //arrange
            Cell cell = new Cell(true);

            //act
            cell.ApplyRulesToCell(true, true, false, false, false, false, false, false);

            //assert
            Assert.That(cell.IsLive, Is.EqualTo(true));
        }

        [Test]
        public void Test_ApplyRulesToLiveCellWith3LiveNeighborsAnd5Dead()
        {
            //arrange
            Cell cell = new Cell(true);

            //act
            cell.ApplyRulesToCell(true, true, true, false, false, false, false, false);

            //assert
            Assert.That(cell.IsLive, Is.EqualTo(true));
        }

        [Test]
        public void Test_ApplyRulesToLiveCellWith4LiveNeighborsAnd4Dead()
        {
            //arrange
            Cell cell = new Cell(true);

            //act
            cell.ApplyRulesToCell(true, true, true, true, false, false, false, false);

            //assert
            Assert.That(cell.IsLive, Is.EqualTo(false));
        }

        [Test]
        public void Test_ApplyRulesToLiveCellWith5LiveNeighborsAnd3Dead()
        {
            //arrange
            Cell cell = new Cell(true);

            //act
            cell.ApplyRulesToCell(true, true, true, true, true, false, false, false);

            //assert
            Assert.That(cell.IsLive, Is.EqualTo(false));
        }

        [Test]
        public void Test_ApplyRulesToLiveCellWith6LiveNeighborsAnd2Dead()
        {
            //arrange
            Cell cell = new Cell(true);

            //act
            cell.ApplyRulesToCell(true, true, true, true, true, true, false, false);

            //assert
            Assert.That(cell.IsLive, Is.EqualTo(false));
        }

        [Test]
        public void Test_ApplyRulesToLiveCellWith7LiveNeighborsAnd1Dead()
        {
            //arrange
            Cell cell = new Cell(true);

            //act
            cell.ApplyRulesToCell(true, true, true, true, true, true, true, false);

            //assert
            Assert.That(cell.IsLive, Is.EqualTo(false));
        }

        [Test]
        public void Test_ApplyRulesToLiveCellWith8LiveNeighbors()
        {
            //arrange
            Cell cell = new Cell(true);

            //act
            cell.ApplyRulesToCell(true, true, true, true, true, true, true, true);

            //assert
            Assert.That(cell.IsLive, Is.EqualTo(false));
        }
    }
}