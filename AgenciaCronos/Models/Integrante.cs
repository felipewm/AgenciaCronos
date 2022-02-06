using System.Collections.Generic;
using System.Diagnostics;

namespace AgenciaCronos.Models
{
    public class Integrante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Equipe { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Funcao { get; set; }
    }
}
