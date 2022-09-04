using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Rectangle ex = new(4, 3);
            Assert.AreEqual(ex.Area, 12);
            Assert.AreEqual(ex.Perimetr, 14)
        }
    }
}