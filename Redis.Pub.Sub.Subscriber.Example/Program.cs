using StackExchange.Redis;

ConnectionMultiplexer connection = await ConnectionMultiplexer.ConnectAsync("localhost:3000");

ISubscriber subscriber = connection.GetSubscriber();

await subscriber.SubscribeAsync("mychannel.*", (channel, message) =>
{
    Console.WriteLine(channel);
});

Console.Read();