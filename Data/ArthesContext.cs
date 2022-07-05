using Arthes2022.Models.Entities;

using Microsoft.EntityFrameworkCore;

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
