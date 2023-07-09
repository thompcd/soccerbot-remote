using MQTTnet.Client;

public class MqttClientService
{
    internal IMqttClient? _client;
    public MqttClientService(IMqttClient client)
    {
        _client = client;
    }

    public void Publish(string topic, string msg)
    {
        _client?.PublishStringAsync(
            topic,
            msg
        );
    }

    public void Subscribe(string topic)
    {
        _client?.SubscribeAsync(
            new MqttClientSubscribeOptionsBuilder()
            .WithTopicFilter(topic)
            .Build()
            );
    }
}