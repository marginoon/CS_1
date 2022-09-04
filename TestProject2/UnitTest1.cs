using NUnit.Framework;
using task2;

namespace TestProject2
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Rectangle ex = new(4, 3);
            Assert.AreEqual(12, ex.Area);
            Assert.AreEqual(14, ex.Perimetr);
        }
    }
}