using bilet_5.Models;
using Microsoft.EntityFrameworkCore;

namespace bilet_5.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
        {
        }
        public DbSet<TeamMember> Members { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
    }
}
