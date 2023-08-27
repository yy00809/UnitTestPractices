namespace TestNinja.NunitTests;
using TestNinja.Fundamentals;

public class FizzBuzzTests
{
    [Test]
    public void GetOuput_InputIsDevisibleBy3And5_ReturnFizzBuzz()
    {
        var result = FizzBuzz.GetOutput(15);

        Assert.That(result, Is.EqualTo("FizzBuzz"));
    }

    [Test]
    public void GetOuput_InputIsDevisibleBy3AndNot5_ReturnFizz()
    {
        var result = FizzBuzz.GetOutput(3);

        Assert.That(result, Is.EqualTo("Fizz"));
    }
    
    [Test]
    public void GetOuput_InputIsDevisibleByNot3And5_ReturnBuzz()
    {
        var result = FizzBuzz.GetOutput(5);

        Assert.That(result, Is.EqualTo("Buzz"));
    }

    [Test]
    public void GetOuput_InputIsDevisibleByNot3AndNot5_ReturnTheInputString()
    {
        var result = FizzBuzz.GetOutput(1);

        Assert.That(result, Is.EqualTo("1"));
    }
}
