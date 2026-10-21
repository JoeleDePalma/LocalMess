namespace LocalMess.Domain.Interfaces.Repositories.Chats.Relations
{
    public interface IUserInChatRepository
    {
        Task AddUserToChatAsync(int userId, int chatId);
        Task RemoveUserFromChatAsync(int userId, int chatId);
        Task<ICollection<int>> GetChatIdsFromUser(int userId);
    }
}
