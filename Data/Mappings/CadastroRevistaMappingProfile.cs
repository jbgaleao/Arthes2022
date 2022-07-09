using Arthes2022.Models.Entities;
using Arthes2022.Models.ViewModels;

namespace Arthes2022.Data.Mappings
{
    public class CadastroRevistaMappingProfile : Profile
    {
        public CadastroRevistaMappingProfile()
        {
            CreateMap<CadastroRevistaViewModel, Revista>();
        }
    }
}
