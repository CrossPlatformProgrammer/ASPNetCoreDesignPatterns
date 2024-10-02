
using ASPNetCoreDesignPatterns.Patterns.Creational.FactoryMethod;
using ASPNetCoreDesignPatterns.Patterns.Creational.Singleton;

namespace ASPNetCoreDesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Register factories
            builder.Services.AddTransient<EmailNotificationFactory>();
            builder.Services.AddTransient<SmsNotificationFactory>();
            builder.Services.AddTransient<PushNotificationFactory>();

            // Register a factory resolver
            builder.Services.AddSingleton<NotificationFactoryResolver>();

            // Register the Singleton service
            builder.Services.AddSingleton<Singleton>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
