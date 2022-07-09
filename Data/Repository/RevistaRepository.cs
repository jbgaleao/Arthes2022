using Arthes2022.Data.Interface;
using Arthes2022.Models.Entities;

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

        public async Task<Revista> InsertRevistaAsync(Revista revista)
        {
            await _context.REVISTAS.AddAsync(revista);
            await _context.SaveChangesAsync();
            return revista;
        }

        public async Task<Revista> UpdateRevistaAsync(Revista revista)
        {
            Revista? revistaConsultada = await _context.REVISTAS.FindAsync(revista.Id);
            if (revistaConsultada == null)
            {
                return null;
            }
            _context.Entry(revistaConsultada).CurrentValues.SetValues(revista);
            await _context.SaveChangesAsync();
            return revistaConsultada;
        }

        public async Task DeletaRevistaAsync(int Id)
        {
            Revista? revistaConsultada = await _context.REVISTAS.FindAsync(Id);
            _context.REVISTAS.Remove(revistaConsultada);
            await _context.SaveChangesAsync();
        }


    }

}
