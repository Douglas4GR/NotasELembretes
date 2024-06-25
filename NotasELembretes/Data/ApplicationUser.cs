using Microsoft.AspNetCore.Identity;
using NotasELembretes.Models;

namespace NotasELembretes.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string Nome { get; set; }
        public ICollection<Nota> Notas { get; set; }
    }


}
