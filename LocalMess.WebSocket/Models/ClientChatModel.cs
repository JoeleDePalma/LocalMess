namespace LocalMess.WebSocket.Models
{
    public class ClientChatModel
    {
        public string Username { get; set; }
        public System.Net.WebSockets.WebSocket Socket { get; set; }
    }
}
