using System.Net.WebSockets;
using System.Text;
using LocalMess.WebSocket.Models;

var clients = new List<ClientChatModel>();

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.UseAuthorization();
app.UseWebSockets();

app.Map("/ws", async context =>
{
    if (context.WebSockets.IsWebSocketRequest)
    {
        var socket = await context.WebSockets.AcceptWebSocketAsync();

        var thisClient = new ClientChatModel()
        {
            Username = "",
            Socket = socket
        };

        clients.Add(thisClient);

        Console.WriteLine("Client connected!");

        var buffer = new byte[1024 * 4];

        while (true)
        {
            var result = await socket.ReceiveAsync(buffer, CancellationToken.None);

            if (result.MessageType == WebSocketMessageType.Close)
            {
                Console.WriteLine("Client closed connection");
                clients.Remove(thisClient);
                await socket.CloseAsync(WebSocketCloseStatus.NormalClosure, "OK", CancellationToken.None);
                break;
            }

            var message = Encoding.UTF8.GetString(buffer, 0, result.Count);

            // SET USERNAME
            if (message.StartsWith("SET_USERNAME: "))
            {
                thisClient.Username = message.Replace("SET_USERNAME: ", "");
                Console.WriteLine($"Username set: {thisClient.Username}");
                continue;
            }

            Console.WriteLine($"Message received: {message}");

            var response = Encoding.UTF8.GetBytes($"{thisClient.Username}: {message}");

            // BROADCAST
            foreach (var client in clients)
            {
                if (client.Socket != socket && client.Socket.State == WebSocketState.Open)
                {
                    await client.Socket.SendAsync(
                        response,
                        WebSocketMessageType.Text,
                        true,
                        CancellationToken.None
                    );
                }
            }
        }
    }
    else
    {
        context.Response.StatusCode = 400;
    }
});

app.MapControllers();
app.Run();
