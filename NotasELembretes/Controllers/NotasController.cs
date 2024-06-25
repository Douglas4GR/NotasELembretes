using Microsoft.AspNetCore.Mvc;
using NotasELembretes.Models;
using NotasELembretes.Services;

namespace NotasELembretes.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotasController : ControllerBase
    {
        private readonly INotaService _notaService;

        public NotasController(INotaService notaService)
        {
            _notaService = notaService;
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetNotas(string userId)
        {
            var notas = await _notaService.GetNotasAsync(userId);
            return Ok(notas);
        }

        [HttpPost]
        public async Task<IActionResult> CreateNota(Nota nota)
        {
            await _notaService.CreateNotaAsync(nota);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateNota(Nota nota)
        {
            await _notaService.UpdateNotaAsync(nota);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNota(int id)
        {
            await _notaService.DeleteNotaAsync(id);
            return Ok();
        }
    }
}
