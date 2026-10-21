using LocalMess.Domain.Models;

namespace LocalMess.Domain.Interfaces.Repositories.Chats.Messages
{
    public interface IMessageRepository
    {
        Task<Message?> GetByIdAsync(int id);
        Task<ICollection<Message>> GetByChatId(int chatId, int messagesNum = 30, int startFrom = 0);
        Task AddAsync(Message newMessage);
        Task UpdateAsync(Message updatedMessage);
        Task RemoveAsync(Message message);
    }
}
