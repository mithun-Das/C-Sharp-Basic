using System;
using System.Text;
using System.IO;
using RabbitMQ.Client;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Sender
{
    public class MessageReceiver : DefaultBasicConsumer
    {
        Program p = new Program();
        private readonly IModel _receiverChannel;

        public MessageReceiver(IModel receiverChannel)
        {
            _receiverChannel = receiverChannel;
        }

        public override void HandleBasicDeliver(string consumerTag, ulong deliveryTag, bool redelivered, string exchange, string routingKey, IBasicProperties properties, byte[] body)
        {
            Console.WriteLine(string.Concat("Sender: ", Encoding.UTF8.GetString(body)));

            _receiverChannel.BasicAck(deliveryTag, false);
        }

    }


    public class MessageThreadPayload
    {
        public List<string> userList { get; set; }
    }

    public class MessageHistoryPayload
    {
        public string userEmail { get; set; }
    }

    class Program
    {
        //public static HttpClient client = new HttpClient();


        //public static async void initializeUser()
        //{
            //Console.WriteLine("login : please enter your credential");
            //string email = Console.ReadLine();
            //string password = Console.ReadLine();


            //HttpResponseMessage response = await client.GetAsync("http://localhost:5000/user/liveuser");
            //var liveUserList = await response.Content.ReadAsStringAsync();
            //Console.WriteLine("Live User : ");
            //Console.WriteLine(liveUserList);

            //Console.WriteLine("Add User To ChatBox : ");

            //string userEmail = "";
            //List<string> addedUserList = new List<string>() { "mithun.das@selise.ch", "mithun1.das@selise.ch" };

            //for (int i = 1; ;)
            //{
            //    i = int.Parse(Console.ReadLine());

            //    if(i == -1) { break; }

            //    userEmail = Console.ReadLine();
            //    addedUserList.Add(userEmail);
            //}    
           


            //var payLoad = new MessageThreadPayload() { userList = addedUserList };
            //var data = JsonConvert.SerializeObject(payLoad);

            //var values = new Dictionary<string, string>
            //{
            //    { "userList", data }
            //};


            //var content = new FormUrlEncodedContent(values);
            //HttpResponseMessage messageResponse = await client.PostAsync("http://localhost:5000/message/create", content);

            //var responseValue = await messageResponse.Content.ReadAsStringAsync();
            //Console.WriteLine(responseValue);
           // Console.WriteLine("Message Thread Created ....");
           // Console.WriteLine("Now Start your Coversation.....");

        //}

        public static void downloadHistory()
        {
            using( var client = new WebClient() )
            {
                var values = new NameValueCollection();

                string userEmail = Console.ReadLine();

                values["userEmail"] = userEmail;

                var response =  client.UploadValues("http://localhost:5000/message/history", values);
                var responseString = Encoding.Default.GetString(response);
                Console.WriteLine(responseString);
                System.IO.File.WriteAllText(@"E:\ChatBox\Sender\History.txt", responseString);
            }
        }

        static void Main(string[] args)
        {

            //var connectionFactory = new ConnectionFactory()
            //{
            //    UserName = "guest",
            //    Password = "guest",
            //    HostName = "localhost"
            //};

            //var publishConnection = connectionFactory.CreateConnection();
            //var publishModel = publishConnection.CreateModel();
            //var publishProperties = publishModel.CreateBasicProperties();
            //publishProperties.Persistent = false;

            //initializeUser();


            //var receiverConnection = connectionFactory.CreateConnection();
            //var receiverChannel = receiverConnection.CreateModel();
            //receiverChannel.BasicQos(0, 1, false);
            //MessageReceiver messageReceiver = new MessageReceiver(receiverChannel);
            //receiverChannel.BasicConsume("receiverQueue", true, messageReceiver);

            //for (; true;)
            //{
            //    var message = Console.ReadLine();
            //    byte[] messageBuffer = Encoding.Default.GetBytes(message);

            //    publishModel.ExchangeDeclare("senderExchange", ExchangeType.Fanout);
            //    publishModel.QueueDeclare("senderQueue", true, false, false, null);
            //    publishModel.QueueBind("senderQueue", "senderExchange", "directexchange_key");
            //    publishModel.BasicPublish("senderExchange", "directexchange_key", publishProperties, messageBuffer);
            //}
            downloadHistory();
            Console.ReadKey();

        }
    }
}