namespace ASPNetCoreDesignPatterns.Patterns.Creational.FactoryMethod
{
    public class PushNotificationFactory : NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new PushNotification();
        }
    }
}
