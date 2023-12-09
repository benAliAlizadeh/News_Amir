using News.Models;

namespace News.Services
{
    public interface IDBService
    {
        Task<User?> GetUserAsync(string userName, string password);

        Task<List<Models.News>> GetNewsAsync();
    }
}
