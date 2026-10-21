using LocalMess.Domain.Models.Chats;

namespace LocalMess.Domain.Interfaces.Repositories.Chats
{
    public interface IPrivateChatRepository
    {
        Task<PrivateChat?> GetByIdAsync(int id);
        Task AddAsync(PrivateChat newChat);
        Task UpdateAsync(PrivateChat updatedChat);
        Task RemoveAsync(PrivateChat chat);
    }
}
