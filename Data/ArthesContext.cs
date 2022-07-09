using Arthes2022.Models.Entities;

namespace Arthes2022.Data
{
    public class ArthesContext : DbContext
    {
        public ArthesContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Revista> REVISTAS { get; set; }
    }
}
