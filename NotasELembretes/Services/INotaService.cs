using NotasELembretes.Models;

namespace NotasELembretes.Services
{
    public interface INotaService
    {
        Task<List<Nota>> GetNotasAsync(string usuarioId);
        Task<Nota> GetNotaByIdAsync(int id);
        Task CreateNotaAsync(Nota nota);
        Task UpdateNotaAsync(Nota nota);
        Task DeleteNotaAsync(int id);
    }
}
