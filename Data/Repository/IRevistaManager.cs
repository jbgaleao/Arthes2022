using Arthes2022.Models.Entities;

namespace Arthes2022.Data.Repository
{
    public interface IRevistaManager
    {
        Task<Revista?> GetRevistaAsyncById(int id);
        Task<IEnumerable<Revista>> GetRevistasAsync();
    }
}
