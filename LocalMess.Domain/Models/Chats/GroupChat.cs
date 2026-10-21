using LocalMess.Domain.Models.Chats.Base;
using LocalMess.Domain.ValueObjects.GroupChat;

namespace LocalMess.Domain.Models.Chats
{
    /// <summary>
    /// Group chat model.
    /// </summary>
    public class GroupChat : BaseChat
    {
        public Name Name { get; private set; }
        public Description Description { get; private set; }

        public GroupChat(Name name, Description description) : base()
        {
            Name = name;
            Description = description;
        }
    }
}
