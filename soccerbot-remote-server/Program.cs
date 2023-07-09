using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using soccerbot_remote_server.Data;
using MQTTnet;
using MQTTnet.Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Setup MQTT
MqttClientOptions options = new MqttClientOptionsBuilder()
        .WithTcpServer("broker.hivemq.com", 1883)
        .Build();

IMqttClient mqttclient = new MqttFactory().CreateMqttClient();
var connection =  mqttclient.ConnectAsync(options, CancellationToken.None);
connection.Wait();
var res = connection.Result;
builder.Services.AddSingleton<IMqttClient>(mqttclient);
builder.Services.AddSingleton<MqttClientService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
