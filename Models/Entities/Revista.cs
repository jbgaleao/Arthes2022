namespace Arthes2022.Models.Entities
{
    public class Revista
    {
        public Guid Id { get; set; }
        public string? Tema { get; set; }
        public int NumeroEdicao { get; set; }
        public Mes MesEdicao { get; set; }
        public int AnoEdicao { get; set; }
        public string Foto { get; set; }

    }
}
