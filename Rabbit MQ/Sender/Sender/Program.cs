using System;
using System.Text;
using RabbitMQ.Client;

namespace Sender
{
    class Program
    {

        static void Main(string[] args)
        {
            var connectionFactory = new ConnectionFactory()
            {
                UserName = "guest",
                Password = "guest",
                HostName = "localhost"
            };

            var publishConnection = connectionFactory.CreateConnection();
            var publishModel = publishConnection.CreateModel();
            var publishProperties = publishModel.CreateBasicProperties();
            publishProperties.Persistent = false;

            for (; true;)
            {
                var message = Console.ReadLine();
                byte[] messageBuffer = Encoding.Default.GetBytes(message);

                publishModel.ExchangeDeclare("demoExchange", ExchangeType.Direct);
                publishModel.QueueDeclare("demoQueue", true, false, false, null);
                publishModel.QueueBind("demoQueue", "demoExchange", "directexchange_key");
                publishModel.BasicPublish("demoExchange", "directexchange_key", publishProperties, messageBuffer);
            }

        }
    }
}
