using System;
using Microsoft.Extensions.DependencyInjection;

interface IMessage
{
    void Send();
}

class EmailService : IMessage
{
    public void Send() => Console.WriteLine("Email Sent");
}

class Program
{
    static void Main()
    {
        var services = new ServiceCollection();
        services.AddTransient<IMessage, EmailService>();

        var provider = services.BuildServiceProvider();
        var service = provider.GetService<IMessage>();
        service.Send();
    }
}