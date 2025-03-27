using MathWorkshop;

namespace UnitTests;

public class CalculatorTests
{
    [Fact]
    public void Add_WorksCorrectly()
    {
        Assert.Equal(5, Calculator.Add(2, 3));
    }

    [Fact]
    public void Multiply_WorksCorrectly()
    {
        Assert.Equal(6, Calculator.Multiply(2, 3));
    }

    [Fact]
    public void Divide_ByNonZero_WorksCorrectly()
    {
        Assert.Equal(2, Calculator.Divide(6, 3));
    }

    [Fact]
    public void Divide_ByZero_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => Calculator.Divide(10, 0));
    }
}
