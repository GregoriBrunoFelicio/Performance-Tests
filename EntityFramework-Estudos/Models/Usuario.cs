namespace EntityFramework_Estudos.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }

        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
        public int CargoId { get; set; }
        public Cargo Cargo { get; set; }
    }
}
