namespace LocalMess.Domain.Models.Chats.Base
{
    /// <summary>
    /// Base chat common model.
    /// </summary>
    public class BaseChat
    {
        public int? Id { get; set; }
        public DateTime CreatedAt { get; private set; }

        public BaseChat()
        {
            CreatedAt = DateTime.UtcNow;
        }
    }

}
