using System.Diagnostics;
using Xunit;

namespace PrimeFactorsKata;

public class PrimeFactorTests
{
    [Theory(DisplayName = "Given number should return expected prime factors.")]
    [InlineData(1)]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    [InlineData(4, 2, 2)]
    [InlineData(5, 5)]
    [InlineData(6, 2, 3)]
    [InlineData(7, 7)]
    [InlineData(8, 2, 2, 2)]
    [InlineData(9, 3, 3)]
    public void Of_Number_Expected(int number, params int[] expected)
    {
        var actual = PrimeFactor.Of(number);
        Assert.Equal(expected, actual);
    }

    [Fact(DisplayName = "Of method should have a high performance")]
    public void Of_LargeNumber_Fast()
    {
        var timer = Stopwatch.StartNew();
        timer.Start();
        _= PrimeFactor.Of(int.MaxValue);
        timer.Stop();

        Assert.True(timer.ElapsedMilliseconds < 1, $"Slow performance, running time was {timer.ElapsedMilliseconds} ms.");
    }

    [Fact(DisplayName = "Acceptance test")]
    public void AcceptanceTest()
    {
        var expected = new List<int> { 2, 3, 7, 11, 13, 17, 19, 23, 29 };

        var actual = PrimeFactor.Of(2 * 3 * 7 * 11 * 13 * 17 * 19 * 23 * 29);

        Assert.Equal(expected, actual);
    }
}