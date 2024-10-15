namespace CSharpSyntax;

public class UnitTest1
{
    [Fact]
    public void CanAddTwoInt()
    {
        int a = 10;
        int b = 20;
        int answer;
        answer = a + b;
        Assert.Equal(30, answer);


    }
    [Theory]
    [InlineData(10, 20, 30)]
    [InlineData(1, 27, 28)]
    [InlineData(10, 2, 12)]
    public void CanAddSomeInt(int a, int b, int expecting)
    {
        int answer = a + b;
        Assert.Equal(expecting, answer);
    }
}