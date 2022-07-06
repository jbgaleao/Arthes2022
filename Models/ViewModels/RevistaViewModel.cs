using Arthes2022.Models.Entities;

using System.ComponentModel.DataAnnotations;

namespace Arthes2022.Models.ViewModels
{
    public class RevistaViewModel
    {
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Display(Name = "Tema:")]
        [MaxLength(255, ErrorMessage = "O campo {0} não pode ter mais que 255 caracteres")]
        public string Tema { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Display(Name = "Número da Edição:")]
        public int NumeroEdicao { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Display(Name = "Mês de Edição:")]
        public Mes MesEdicao { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Display(Name = "Ano da Edição:")]
        public int AnoEdicao { get; set; }

        [Display(Name = "Foto de Capa:")]
        public string Foto { get; set; }
    }
}
