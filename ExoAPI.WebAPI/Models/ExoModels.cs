namespace ExoAPI.WebAPI.Models
{
    public class ExoProjeto
    {
        public int id { get; set; }

        public string? Titulo { get; set; }

        public string? Status { get; set; }

        public DateTime DataInicio { get; set; }

        public string? Requisitos { get; set; }
    }
}
