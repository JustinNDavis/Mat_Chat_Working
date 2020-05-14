using Mat_Chat_Working.Models;
using Microsoft.EntityFrameworkCore;

namespace Mat_Chat_Working.Data
{
    public class ProfileContext : DbContext
    {
        public ProfileContext(DbContextOptions<ProfileContext> options)
            : base(options)
        {
        }
        public DbSet<Profile> Profile { get; set; }
    }
}