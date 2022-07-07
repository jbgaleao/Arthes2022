using Arthes2022.Data.Interface;
using Arthes2022.Models.Entities;

using Microsoft.EntityFrameworkCore;

namespace Arthes2022.Data.Repository
{
    public class RevistaRepository : IRevistaRepository
    {
        private readonly ArthesContext _context;
        public RevistaRepository(ArthesContext context) => _context = context;

        public async Task<IEnumerable<Revista>> GetRevistasAsync()
        {
            return await _context.REVISTAS.AsNoTracking().ToListAsync();
        }

        public async Task<Revista?> GetRevistaAsyncById(int id)
        {
            return await _context.REVISTAS.FindAsync(id);
        }
    }

}
