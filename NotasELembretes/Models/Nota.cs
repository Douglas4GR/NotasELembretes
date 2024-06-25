using NotasELembretes.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotasELembretes.Models
{
    public class Nota
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataHoraEscrito { get; set; } = DateTime.Now; // Definir automaticamente como DateTime.Now
        public string UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public ApplicationUser Usuario { get; set; }
    }
}
