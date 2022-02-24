using Microsoft.EntityFrameworkCore;

namespace NotaSpeseRESTService2.Models
{
    public class NotaSpeseDbContext : DbContext
    {
        public NotaSpeseDbContext(DbContextOptions<NotaSpeseDbContext> options)
    : base(options)
        {
        }

        public DbSet<NotaSpese> NotaSpeses { get; set; } = null!;
    }
}
