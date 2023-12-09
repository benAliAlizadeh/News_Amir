using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using News.Data;
using News.Models;

namespace News.Services
{
    public class DBService : IDBService
    {
        private readonly AppDBContext _appDBContext;
        public DBService(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task<List<Models.News>> GetNewsAsync()
        {
            return await _appDBContext.News.ToListAsync();
        }

        public async Task<User?> GetUserAsync(string userName, string password)
        {
            return await _appDBContext.Users.FirstOrDefaultAsync(c => c.UserName.ToLower() == userName.ToLower() & c.Password == password);
        }
    }
}
