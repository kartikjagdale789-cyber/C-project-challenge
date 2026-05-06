using Xunit;

public class MathTests
{
    [Fact]
    public void Add_Test()
    {
        int result = 2 + 3;
        Assert.Equal(5, result);
    }
}