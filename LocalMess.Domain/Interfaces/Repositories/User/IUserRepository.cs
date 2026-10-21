using LocalMess.Domain.Models;
using LocalMess.Domain.ValueObjects.User;

namespace LocalMess.Domain.Interfaces.Repositories.User
{
    public interface IUserRepository
    {
        Task<User?> GetByIdAsync(int id);
        Task<User?> GetByUsernameAsync(Username username);
        Task AddAsync(User newUser);
        Task UpdateAsync(User updatedUser);
        Task RemoveAsync(User user);

        Task<bool> UsernameAlreadyExistsAsync(Username username, int excludedUserId);
    }
}
