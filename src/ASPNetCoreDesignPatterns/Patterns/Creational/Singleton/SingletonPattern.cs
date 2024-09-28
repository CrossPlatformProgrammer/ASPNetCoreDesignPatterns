using System;

namespace ASPNetCoreDesignPatterns.Patterns.Creational.Singleton;

/// <summary>
/// The Singleton class ensures a class has only one instance and provides a global point of access to it.
/// </summary>

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

