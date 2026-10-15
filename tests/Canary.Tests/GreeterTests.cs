using Canary;

namespace Canary.Tests;

public class GreeterTests
{
    [Fact]
    public void GreetGreetsByName()
    {
        Assert.Equal("Hello, Ada!", Greeter.Greet("Ada"));
    }
}
