namespace TestNinja.UnitTests;
using TestNinja.Fundamentals; 

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
    {
        // Arrange 
        var reservation = new Reservation();

        // Act 
        var result = reservation.CanBeCancelledBy(new User { IsAdmin = true});

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void CanBeCancelledBy_UserIsOwner_ReturnsTrue()
    {
        var user1 = new User();
        var reservation = new Reservation() { MadeBy = user1 };
      

        var result = reservation.CanBeCancelledBy(user1);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnsFalse()
    {
        var user1 = new User();
        var user2 = new User();
        var reservation = new Reservation(){ MadeBy = user1 };

        var result = reservation.CanBeCancelledBy(user2);

        Assert.IsTrue(!result);
    }    
}