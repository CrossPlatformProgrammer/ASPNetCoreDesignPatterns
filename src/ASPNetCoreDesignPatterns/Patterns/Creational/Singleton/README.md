# Singleton Pattern

The Singleton pattern ensures a class has only one instance and provides a global point of access to it. In ASP.NET Core, this is particularly useful for managing shared resources like database contexts, logging services, or configuration settings.

## When to Use

- When exactly one instance of a class is needed to coordinate actions across the system.
- To manage shared resources such as caching, logging, or configuration settings.

## Implementation

### SingletonPattern.cs

```csharp

public class Singleton 
{
    private int _counter = 0;

    public int GetCounter()
    {
        return _counter;
    }

    public void IncrementCounter()
    {
        _counter++;
    }
}
```
