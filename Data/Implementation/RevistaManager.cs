using Arthes2022.Data.Interface;
using Arthes2022.Data.Repository;
using Arthes2022.Models.Entities;

namespace Arthes2022.Data.Implementation
{
    public class RevistaManager : IRevistaManager
    {
        private readonly IRevistaRepository revistaRepository;

        public RevistaManager(IRevistaRepository revistaRepository)
        {
            this.revistaRepository = revistaRepository;
        }

        public async Task<IEnumerable<Revista>> GetRevistasAsync()
        {
            return await revistaRepository.GetRevistasAsync();
        }

        public async Task<Revista?> GetRevistaAsyncById(int id)
        {
            return await revistaRepository.GetRevistaAsyncById(id);
        }
    }
}
