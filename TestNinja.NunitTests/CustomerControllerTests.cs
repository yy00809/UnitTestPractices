namespace TestNinja.NunitTests;
using TestNinja.Fundamentals;


public class CustomerControllerTests
{
    [Test]
    public void GetCustomer_IdIsZero_ReturnNotFound()
    {
        var controller = new CustomerController();

        var result = controller.GetCustomer(0);

        Assert.That(result, Is.TypeOf<NotFound>());
    }

    [Test]
    public void GetCustomer_IdIsNotZero_ReturnOK()
    {
        var controller = new CustomerController();

        var result = controller.GetCustomer(1);

        Assert.That(result, Is.TypeOf<Ok>());
    }

    
}
