using System.Net.WebSockets;
using System.Text;

public class Program
{
    public static async Task Main(string[] args)
    {
        var socket = new ClientWebSocket();

        await socket.ConnectAsync(new Uri("ws://localhost:5239/ws"), CancellationToken.None);

        Console.WriteLine("Connected!");

        // THREAD DI RICEZIONE
        Task.Run(async () =>
        {
            var buffer = new byte[1024 * 4];

            while (socket.State == WebSocketState.Open)
            {
                var result = await socket.ReceiveAsync(buffer, CancellationToken.None);
                var msg = Encoding.UTF8.GetString(buffer, 0, result.Count);
                Console.WriteLine(msg);
            }
        });

        // THREAD DI INVIO
        while (true)
        {
            var text = Console.ReadLine();
            if (text == null) continue;

            if (text == "CLOSE")
            {
                await socket.CloseAsync(
                    WebSocketCloseStatus.NormalClosure,
                    "OK",
                    CancellationToken.None
                    );
                break;
            }

            var bytes = Encoding.UTF8.GetBytes(text);

            await socket.SendAsync
            (
                bytes,
                WebSocketMessageType.Text,
                true,
                CancellationToken.None
            );
        }
    }
}