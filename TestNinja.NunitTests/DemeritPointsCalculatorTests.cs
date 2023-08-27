namespace TestNinja.NunitTests;
using TestNinja.Fundamentals;

public class DemeritPointsCalculatorTests
{
    [Test]
    public void CalculateDemeritPoints_SpeedIsSmallerThanZero_ReturnException()
    {
        var calculator = new DemeritPointsCalculator();

        Assert.That(() => calculator.CalculateDemeritPoints(-1), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
    }

    [Test]
    public void CalculateDemeritPoints_SpeedIsLargerThan300_ReturnException()
    {
        var calculator = new DemeritPointsCalculator();

        Assert.That(() => calculator.CalculateDemeritPoints(400), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());

    }

    [Test]
    [TestCase(0, 0)]
    [TestCase(1, 0)]
    [TestCase(15, 0)]
    [TestCase(65, 0)]
    [TestCase(69, 0)]
    [TestCase(70, 1)]
    [TestCase(75, 2)]
    public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed, int points)
    {
        var calculator = new DemeritPointsCalculator();

        var result = calculator.CalculateDemeritPoints(speed);

        Assert.That(result, Is.EqualTo(points));
    }

}
