using LocalMess.Domain.Exceptions.ValueObjects.GroupChat;

namespace LocalMess.Domain.ValueObjects.GroupChat
{
    /// <summary>
    /// Represents the group chat name value object.
    /// </summary>
    public class Name
    {
        private readonly string _value;
        public string Value { get => _value; }

        /// <summary>
        /// Validates and assigns the chat name value.
        /// </summary>
        /// <param name="value">
        /// Chat name value.
        /// </param>
        /// <exception cref="InvalidChatNameException">
        /// Thrown if the chat name is longer than 30 characters.
        /// </exception>
        /// <remarks>Empty descriptions are allowed.</remarks>
        public Name(string value)
        {
            if (value.Length > 30)
                throw new InvalidChatNameException("Chat name cannot be longer than 30 characters.");

            _value = value;
        }
    }
}