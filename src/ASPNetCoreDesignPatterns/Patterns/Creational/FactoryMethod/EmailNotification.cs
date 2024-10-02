﻿namespace ASPNetCoreDesignPatterns.Patterns.Creational.FactoryMethod
{
    public class EmailNotification : INotification
    {
        public static INotification CreateNotification()
        {
            return new EmailNotification();
        }
        public void Send(string recipient, string message)
        {
            // Implementation for sending email
            Console.WriteLine($"Email sent to {recipient}: {message}");
            // Integrate with an actual email service here
        }
    }
}