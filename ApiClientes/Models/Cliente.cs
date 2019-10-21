using System.ComponentModel.DataAnnotations;

namespace ApiCliente.Models
{
    public class Cliente
    {
        [Key]
        public int Id_Cli {get; set;}
        public string Nome {get; set;}
        public string Cidade {get; set;}
        public string Telefone {get; set;}
        public string Celular {get; set;}
        public string Email {get; set;}
        
    }
}