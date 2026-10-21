using LocalMess.Domain.Exceptions.ValueObjects.GroupChat;

namespace LocalMess.Domain.ValueObjects.GroupChat
{
    /// <summary>
    /// Represents the group chat description value object.
    /// </summary>
    public class Description
    {
        private readonly string _value;
        public string Value { get => _value;  }

        /// <summary>
        /// Validates and assigns the description value.
        /// </summary>
        /// <param name="value">
        /// Description value.
        /// </param>
        /// <exception cref="InvalidDescriptionException">
        /// Thrown if the description is longer than 300 characters.
        /// </exception>
        /// <remarks>Empty descriptions are allowed.</remarks>
        public Description(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                value = "";

            if (value.Length > 300)
                throw new InvalidDescriptionException("Description cannot be longer than 300 characters.");

            _value = value;
        }
    }
}
