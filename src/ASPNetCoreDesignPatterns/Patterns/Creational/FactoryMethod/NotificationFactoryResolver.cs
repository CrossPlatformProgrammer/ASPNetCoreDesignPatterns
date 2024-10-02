using ASPNetCoreDesignPatterns.Controllers.Creational;

namespace ASPNetCoreDesignPatterns.Patterns.Creational.FactoryMethod
{
    public class NotificationFactoryResolver
    {
        private readonly IServiceProvider _serviceProvider;

        public NotificationFactoryResolver(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public INotification GetNotification(NotificationType notificationType)
        {
            NotificationFactory factory = notificationType switch
            {
                NotificationType.Email => _serviceProvider.GetService<EmailNotificationFactory>(),
                NotificationType.SMS => _serviceProvider.GetService<SmsNotificationFactory>(),
                NotificationType.Push => _serviceProvider.GetService<PushNotificationFactory>(),
                _ => throw new ArgumentException("Invalid notification type")
            };

            return factory.CreateNotification();
        }
    }
}
