using NUnit.Framework;
using task2;


namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Rectangle ex = new(4, 3);
            Assert.AreEqual(12, ex.Area);
            Assert.AreEqual(14, ex.Perimetr);
        }
    }
}