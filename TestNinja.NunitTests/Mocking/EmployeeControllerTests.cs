namespace TestNinja.NunitTests;

using Moq;
using TestNinja.Mocking;

public class EmployeeControllerTests
{
    [Test]
    public void DeleteEmployee_WhenCalled_DeleteTheEmployFromDb()
    {
        var storage = new Mock<IEmployeeStorage>();
        var controller = new EmployeeController(storage.Object);

        controller.DeleteEmployee(1);

        storage.Verify(s => s.DeleteEmployee(1));
    }
}
