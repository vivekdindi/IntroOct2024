

namespace StringCalculator;
public class CalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new Calculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("-2", -2)]
    public void singleInteger(string strNumber, int number)
    {
        var calculator = new Calculator();

        var result = calculator.Add(strNumber);

        Assert.Equal(result, number);
    }

    [Theory]
    [InlineData("2,2", 4)]
    [InlineData("-12,-2", -14)]
    [InlineData("-10,2", -8)]


    public void commaDelimiterTwoIntegers(string strNumber, int number)
    {
        var calculator = new Calculator();

        var result = calculator.Add(strNumber);

        Assert.Equal(result, number);
    }



    [Theory]
    [InlineData("2,2", 4)]
    [InlineData("1,3,3", 7)]
    [InlineData("1,2,3,4,5,6,7,8,9", 45)]

    public void commaDelimiterAnyLength(string strNumber, int number)
    {
        var calculator = new Calculator();

        var result = calculator.Add(strNumber);

        Assert.Equal(result, number);
    }


    //dd("1\n2") => 3`
    [Theory]
    [InlineData("2\n2", 4)]
    [InlineData("2\n3\n4\n1\n5", 15)]

    public void newLineDelimiter(string strNumber, int number)
    {
        var calculator = new Calculator();

        var result = calculator.Add(strNumber);

        Assert.Equal(result, number);
    }

    [Theory]
    [InlineData("1\n,2", 3)]
    [InlineData("2\n,3\n,4", 9)]
    // `Add("1\n2,3") => 6`

    public void mixDelimiter(string strNumber, int number)
    {
        var calculator = new Calculator();

        var result = calculator.Add(strNumber);

        Assert.Equal(result, number);
    }



}
