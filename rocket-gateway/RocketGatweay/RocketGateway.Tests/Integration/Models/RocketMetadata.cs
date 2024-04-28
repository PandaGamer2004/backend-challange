namespace RocketGateway.Tests.Integration.Models;

public class RocketMetadata
{
    public string Channel { get; set; }

    public int MessageNumber { get; set; }

    public DateTimeOffset MessageTime { get; set; }

    public string MessageType { get; set; }

    public static RocketMetadata MakeWithType(string messageType)
        => new RocketMetadata
        {
            Channel = "1",
            MessageNumber = 1,
            MessageTime = DateTime.Now,
            MessageType = messageType
        };
}