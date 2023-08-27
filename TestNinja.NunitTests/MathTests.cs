namespace TestNinja.NunitTests;
using TestNinja.Fundamentals;

public class MathTests
{
    private Math _math;
    [SetUp]
    public void Setup()
    {
        _math = new Math();
    }

    [Test]
    [TestCase(2, 1, 2)]
    [TestCase(0, 1, 1)]
    [TestCase(2, 2, 2)]
    public void Max_WhenCalled_ReturnGreaterArgument(int a, int b, int expectedResult)
    {
        var result = _math.Max(a, b);

        Assert.That(result, Is.EqualTo(expectedResult));

    }

    [Test]
    public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
    {
        var result = _math.GetOddNumbers(5);

        Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5}));
    }


}