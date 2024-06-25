using Microsoft.EntityFrameworkCore;
using NotasELembretes.Data;
using NotasELembretes.Models;

namespace NotasELembretes.Services
{
    public class NotaService : INotaService
    {
        private readonly ApplicationDbContext _context;

        public NotaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Nota>> GetNotasAsync(string usuarioId)
        {
            return await _context.Notas.Where(n => n.UsuarioId == usuarioId).ToListAsync();
        }

        public async Task<Nota> GetNotaByIdAsync(int id)
        {
            return await _context.Notas.FindAsync(id);
        }

        public async Task CreateNotaAsync(Nota nota)
        {
            _context.Notas.Add(nota);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateNotaAsync(Nota nota)
        {
            _context.Notas.Update(nota);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteNotaAsync(int id)
        {
            var nota = await _context.Notas.FindAsync(id);
            if (nota != null)
            {
                _context.Notas.Remove(nota);
                await _context.SaveChangesAsync();
            }
        }
    }
}
