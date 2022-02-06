namespace AgenciaCronos.Models
{
    public class Servico
    {
        public int Id { get; set; }
        public string NomeServico { get; set; }
        public string Tipo { get; set; }
        public DateTime DataServico{ get; set; }
        public string Descricao { get; set; }

    }
}
