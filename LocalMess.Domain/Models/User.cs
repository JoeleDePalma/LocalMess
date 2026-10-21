using LocalMess.Domain.ValueObjects.User;
using LocalMess.Domain.Exceptions.ValueObjects.User;

namespace LocalMess.Domain.Models
{
    /// <summary>
    /// User model.
    /// </summary>
    public class User
    {
        public int? Id { get; set; }
        public Username Username { get; private set; }
        public Password Password { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime LastUpdateAt { get; private set; }
        public PublicKey PublicKey { get; private set; }

        public User
        (
            Username username,
            Password password,
            DateTime createdAt,
            DateTime lastUpdateAt,
            PublicKey publicKey
        )
        {
            Username = username;
            Password = password;
            CreatedAt = createdAt;
            LastUpdateAt = lastUpdateAt;
            PublicKey = publicKey;
        }

        /// <summary>
        /// Password update function.
        /// </summary>
        /// <param name="newPassword">New password.</param>
        /// <exception cref="InvalidPasswordException">
        /// Thrown if the Password object is null.
        /// </exception>
        public void UpdatePassword(Password newPassword)
        {
            if (newPassword is null)
                throw new InvalidPasswordException("Password cannot be null."); 

            Password = newPassword;
            LastUpdateAt = DateTime.UtcNow;
        }
    }
}