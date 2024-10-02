namespace ASPNetCoreDesignPatterns.Patterns.Creational.FactoryMethod
{
    public class PushNotification : INotification
    {
        public static INotification CreateNotification()
        {
            return new PushNotification();
        }
        public void Send(string recipient, string message)
        {
            // Implementation for sending push notification
            Console.WriteLine($"Push Notification sent to {recipient}: {message}");
            // Integrate with an actual push notification service here
        }
    }
}
