namespace ASPNetCoreDesignPatterns.Patterns.Creational.FactoryMethod
{
    public class SmsNotificationFactory : NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new SmsNotification();
        }
    }
}
