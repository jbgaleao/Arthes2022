using Arthes2022.Models.Entities;

namespace Arthes2022.Models.ViewModels
{
    public class CadastroRevistaViewModel
    {
        public int Id { get; set; }
        public string? Tema { get; set; }
        public int NumeroEdicao { get; set; }
        public Mes MesEdicao { get; set; }
        public int AnoEdicao { get; set; }
        public string? Foto { get; set; }
    }
}
