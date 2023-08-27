namespace TestNinja.UnitTests;
using TestNinja.Fundamentals; 

[TestClass]
public class UnitTest2
{
   
    [TestMethod]
    public void Add_WhenCalled_ReturnsTheSumOfArguments()
    {
        // Arrange 
        var math = new Math();

        // Act 
        var result = math.Add(1, 1);

        // Assert
        Assert.AreEqual(result, 2);
    }

    [TestMethod]
    public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
    {
        var math = new Math();

        var result = math.Max(1, 0);

        Assert.AreEqual(result, 1);

    }

    [TestMethod]
    public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
    {
        var math = new Math();

        var result = math.Max(0, 1);

        Assert.AreEqual(result, 1);
    }

    [TestMethod]
    public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
    {
        var math = new Math();

        var result = math.Max(1, 1);

        Assert.AreEqual(result, 1);
    }
   
}