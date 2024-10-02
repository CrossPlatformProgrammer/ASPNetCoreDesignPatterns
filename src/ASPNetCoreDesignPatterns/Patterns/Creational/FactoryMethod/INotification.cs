using System;

namespace ASPNetCoreDesignPatterns.Patterns.Creational.FactoryMethod;

/// <summary>
/// The Singleton class ensures a class has only one instance and provides a global point of access to it.
/// </summary>

public interface INotification
{
    void Send(string recipient, string message);
}


