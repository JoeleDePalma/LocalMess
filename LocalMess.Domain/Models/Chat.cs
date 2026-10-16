using LocalMess.Domain.ValueObjects.Chat;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocalMess.Domain.Models
{
    /// <summary>
    /// Chat model.
    /// </summary>
    public class Chat
    {
        public int? Id { get; set; }
        public Description Description { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public Chat(Description description)
        {
            Description = description;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
