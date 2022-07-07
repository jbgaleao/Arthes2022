using Arthes2022.Models.Entities;

namespace Arthes2022.Data.Interface
{
    public interface IRevistaRepository
    {
 
        Task<Revista?> GetRevistaAsyncById(int id);
        Task<IEnumerable<Revista>> GetRevistasAsync();
        Task<Revista> InsertRevistaAsync(Revista revista);
        Task<Revista> UpdateRevistaAsync(Revista revista);       
        Task DeletaRevistaAsync(int Id);
    }
}