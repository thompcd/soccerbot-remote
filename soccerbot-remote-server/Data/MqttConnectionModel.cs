using System.ComponentModel.DataAnnotations;

public class MqttConnectionModel
{
    [Required]
    public string? ServerUrl { get; set; } = "broker.hivemq.com";
    public int Port { get; set; } = 1883;
}