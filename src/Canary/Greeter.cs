namespace Canary;

public static class Greeter
{
    public static string Greet(string name) => $"Hello, {name}!";

    public static string Shout(string name) => $"{name.ToUpperInvariant()}!";
}
