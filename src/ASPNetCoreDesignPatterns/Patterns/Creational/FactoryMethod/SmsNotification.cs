namespace ASPNetCoreDesignPatterns.Patterns.Creational.FactoryMethod
{
    public class SmsNotification : INotification
    {
        public static INotification CreateNotification()
        {
            return new SmsNotification();
        }
        public void Send(string recipient, string message)
        {
            // Implementation for sending SMS
            Console.WriteLine($"SMS sent to {recipient}: {message}");
            // Integrate with an actual SMS service here
        }
    }
}
