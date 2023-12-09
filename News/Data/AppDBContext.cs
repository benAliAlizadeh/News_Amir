using Microsoft.EntityFrameworkCore;
using News.Models;
using System;

namespace News.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Models.News> News { get; set; }

    }
}
