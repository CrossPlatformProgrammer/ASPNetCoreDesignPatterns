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


## Improved Testability and Flexibility:
Register the Singleton class as a singleton service in ASP.NET Core's dependency injection container (DIC).
This allows injecting the singleton instance into controllers or other classes as needed, promoting testability and looser coupling.
```csharp

services.AddSingleton<Singleton>();

```
## Dependency Injection (Recommended):
Inject the singleton into the controller constructor via dependency injection:
 

```csharp

private readonly Singleton _singleton;

public SingletonController(Singleton singleton) // Inject via DI (recommended)
{
    _singleton = singleton;
}
```
## Considerations:

Consider alternative patterns for shared state management if tight coupling or testing issues become problematic. Options include:
Thread Local Storage (TLS) for thread-specific data.
Scoped services in ASP.NET Core's DI for request-specific data.
Implement proper thread safety if your Singleton instance needs to be accessed from multiple threads concurrently.
```csharp
using ASPNetCoreDesignPatterns.Patterns.Creational.Singleton; // Assuming a separate Singleton class
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreDesignPatterns.Controllers.Creational
{
    [Route("Creational/[controller]/[action]")]
    [ApiController]
    public class SingletonController : ControllerBase
    {
        private readonly Singleton _singleton;

        public SingletonController(Singleton singleton) // Inject via DI (recommended)
        {
            _singleton = singleton;
        }

        [HttpGet]
        public IActionResult GetCurrentCounter()
        {
            return Ok(_singleton.GetCounter());
        }

        [HttpPost]
        public IActionResult IncrementCounter()
        {
            _singleton.IncrementCounter();
            return Ok("Counter incremented");
        }
    }
}

```




