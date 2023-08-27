﻿using Moq;
using TestNinja.Mocking;
namespace TestNinja.NunitTests;

public class OderServiceTests
{
    [Test]
    public void PlaceOrder_WhenCalled_StoreTheOrder()
    {
        var storage = new Mock<IStorage>();
        var service = new OrderService(storage.Object);

        var order = new Order();
        service.PlaceOrder(order);

        storage.Verify(s => s.Store(order) );
    }
}
