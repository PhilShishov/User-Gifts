namespace UsersGiftsRegistryTask.Services.Database
{
    using System.Data.Entity;

    using UsersGiftsRegistryTask.Models;

    public class WinFormsTaskDbContext : DbContext
    {
        public WinFormsTaskDbContext() : base("WinFormsTaskDb")
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
