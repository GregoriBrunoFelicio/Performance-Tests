using System.Collections.Generic;

namespace EntityFramework_Estudos.Models
{
    public class Cargo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public virtual List<Usuario> Usuarios { get; set; }
    }
}