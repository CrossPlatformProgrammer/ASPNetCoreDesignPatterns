namespace ASPNetCoreDesignPatterns.Patterns.Creational.FactoryMethod
{
    public class EmailNotificationFactory : NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new EmailNotification();
        }
    }
}
