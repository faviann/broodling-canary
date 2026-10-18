using Canary;

namespace Canary.Tests;

public class GreeterTests
{
    [Fact]
    public void GreetGreetsByName()
    {
        Assert.Equal("Hello, Ada!", Greeter.Greet("Ada"));
    }

    [Fact]
    public void ShoutUpperCasesNameWithExclamation()
    {
        Assert.Equal("ADA!", Greeter.Shout("Ada"));
    }
}
