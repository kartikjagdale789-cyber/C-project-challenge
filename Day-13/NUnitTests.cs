using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    public void TestAddition()
    {
        int result = 2 + 2;
        Assert.AreEqual(4, result);
    }
}