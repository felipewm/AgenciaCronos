namespace AgenciaCronos.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Integrante> Integrante { get; set; }
        public Servico Servico{ get; set; }
        public DateTime DataPostagem { get; set; }
        public DateTime DataEntrega { get; set; }
        public string Endereco{ get; set; }
        public string Descricao{ get; set; }
    }
}
