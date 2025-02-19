using StackExchange.Redis;

ConnectionMultiplexer connection = await ConnectionMultiplexer.ConnectAsync("localhost:3000");

ISubscriber subscriber = connection.GetSubscriber();

while (true)
{
    Console.WriteLine("Mesaj : ");
    string message = Console.ReadLine();
    await subscriber.PublishAsync("channel", message);
}