using LocalMess.Domain.ValueObjects.Message;

namespace LocalMess.Domain.Models
{
    /// <summary>
    /// Message model.
    /// </summary>
    public class Message
    {
        public int? Id { get; set; }
        public EncryptedPayload EncryptedPayload { get; private set; }
        public DateTime? SentAt { get; private set; }
        public DateTime? LastUpdateAt { get; private set; }
        public int SentFromId { get; private set; }
        public int SentToChatId { get; private set; }

        public Message
        (
            EncryptedPayload encryptedPayload,
            int sentFromId,
            int sentToChatId
        )
        {
            EncryptedPayload = encryptedPayload;
            SentAt = DateTime.UtcNow;
            LastUpdateAt = DateTime.UtcNow;
            SentFromId = sentFromId;
            SentToChatId = sentToChatId;
        }

        /// <summary>
        /// Updated the encrypted payload of the object.
        /// </summary>
        /// <param name="newEncryptedPayload">
        /// New encrypted payload.
        /// </param>
        public void UpdateMessage(EncryptedPayload newEncryptedPayload)
        {
            EncryptedPayload = newEncryptedPayload;
            LastUpdateAt = DateTime.UtcNow;
        }

        /// <summary>
        /// Define the status of the message, if it's been edited or not.
        /// </summary>
        public bool IsEdited => SentAt != LastUpdateAt; 
    }
}
