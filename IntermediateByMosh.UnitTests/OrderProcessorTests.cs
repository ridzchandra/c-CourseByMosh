using IntermediateByMosh.Interfaces.Testability;

namespace IntermediateByMosh.UnitTests;

[TestClass] // This is just an attribute. In C#, attributes are used to add metadata to classes, methods, and properties. They don't have any logic. They are just markers. Another app or another assembly can read this metadata and act accordingly. For example, Microsoft TestRunner is going to look at classes that have an attribute [TestClass] and run all the methods that have an attribute [TestMethod].

// Naming Convention: <ClassNameToTest>Tests. 
public class OrderProcessorTests
{
    [TestMethod]
    // Naming Convention: <MethodName>_<Scenario>_<ExpectedBehavior>()
    [ExpectedException(typeof(InvalidOperationException))] // In an MSTest project, this attribute is used to assert that a test method should throw a specific exception. If the test method does not throw the expected exception, the test fails.
    public void Process_OrderIsAlreadyShipped_ThrowsAnException()
    {
        var orderProcessor = new OrderProcessor(new MockShippingCalculator());
        var order = new Order
        {
            Shipment = new Shipment() // This is the scenario where the order is already shipped.
        };

        orderProcessor.Process(order);
    }

    [TestMethod]
    public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
    {
        var orderProcessor = new OrderProcessor(new MockShippingCalculator());
        var order = new Order();

        orderProcessor.Process(order);

        Assert.IsTrue(order.IsShipped); // This is the expected behavior.
        Assert.AreEqual(1, order.Shipment.Cost); // This is the expected behavior.
        Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate); // This is the expected behavior.
    }


}

