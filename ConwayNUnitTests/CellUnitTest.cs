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
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            Cell cell = new Cell();
            Assert.That(cell.IsLive, Is.EqualTo(false));
        }

        [Test]
        public void Test3()
        {
            Cell cell = new Cell(true);
            Assert.That(cell.IsLive, Is.EqualTo(true));
        }

        [Test]
        public void Test4()
        {
            Cell cell = new Cell(true);
            cell.IsLive = false;
            Assert.That(cell.IsLive, Is.EqualTo(false));
        }
    }
}