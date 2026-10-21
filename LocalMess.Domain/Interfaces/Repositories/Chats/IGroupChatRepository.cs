using LocalMess.Domain.Models.Chats;
using LocalMess.Domain.ValueObjects.GroupChat;

namespace LocalMess.Domain.Interfaces.Repositories.Chats
{
    public interface IGroupChatRepository
    {
        Task<GroupChat?> GetByIdAsync(int id);
        Task AddAsync(GroupChat groupChat);
        Task UpdateAsync(GroupChat newGroupChat);
        Task RemoveAsync(GroupChat grouChat);

        Task UpdateDescriptionAsync(int chatId, Description newDescription);
        Task UpdateChatNameAsync(int chatId, Name newChatName);
    }
}
