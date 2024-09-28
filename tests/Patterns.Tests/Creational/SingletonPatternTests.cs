

using ASPNetCoreDesignPatterns.Patterns.Creational.Singleton;

namespace Patterns.Tests;

public class SingletonPatternTests
{
    private readonly Singleton _counterService;

    public SingletonPatternTests()
    {
        // Arrange: Create an instance of the service to test
        _counterService = new Singleton();
    }

    [Fact]
    public void GetCounter_ShouldReturnInitialCounterValue()
    {
        // Act: Get the initial counter value
        var result = _counterService.GetCounter();

        // Assert: Verify that the initial counter is 0
        Assert.Equal(0, result);
    }

    [Fact]
    public void IncrementCounter_ShouldIncreaseCounterValue()
    {
        // Act: Increment the counter and then get the counter value
        _counterService.IncrementCounter();
        var result = _counterService.GetCounter();

        // Assert: Verify that the counter is incremented to 1
        Assert.Equal(1, result);
    }
}
