using NUnit.Framework;
using task3;

namespace TestProject3;

public class Tests
{


    [Test]
    public void Tri()
    {
        Figure ex = new("Tri", new(0, 0), new(0, 1),
            new(0, 2));
        Assert.AreEqual(4 , ex.PerimeterCalculator());
        Assert.AreEqual("Tri" , ex.Name);
        
    }
    [Test]
    public void Rec()
    {
        Figure ex = new("Rec", new(-2, -1), new(3, -1),
            new(3, 3), new(1, 3));
        Assert.AreEqual(16 , ex.PerimeterCalculator());
        Assert.AreEqual("Rec" , ex.Name);
    }

    [Test]
    public void Pen()
    {
        Figure ex = new("Pen", new(0, 0), new(0, 1),
            new(3, 5), new(4, 5), new(4, 0));
        Assert.AreEqual(16 , ex.PerimeterCalculator());
        Assert.AreEqual("Pen" , ex.Name);
    }
}
