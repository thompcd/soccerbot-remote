public interface IMqttClientService
{
    void Connect(string server, int port);
    void Publish(string topic, string msg);
    void Subscribe(string topic);
    void Disconnect();
}

public class MqttMessage
{
    public string? Data;
    public string? SourceTopic;
}