namespace S14con.Test;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void AddTest()
    {
        Vector<int> v1 = new Vector<int>(3, 4);
        Vector<int> v2 = new Vector<int>(1, 2);
        
        Vector<int> vsum = v1.Add(v2);
        Vector<int> vExpectedSum = new Vector<int>(4, 6);

        Assert.AreEqual(vsum, vExpectedSum);
    }

    [TestMethod]
    public void AngleTest()
    {
        AngleVector<int> v1 = new AngleVector<int> (3,4);
        AngleVector<int> v2 = new AngleVector<int> (9,10);
        double angle = v1.Angle(v2);
        double angle2 = Math.Acos(67/(5 + Math.Sqrt(181)));

        Assert.AreEqual(angle, angle2);
    }
}
