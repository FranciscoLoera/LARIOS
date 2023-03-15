using LARIOS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LARIOS.Controllers
{
    public class PacientesController : Controller
    {
        private readonly PruebaCitasContext _context;

        public PacientesController(PruebaCitasContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        =>View(await _context.Pacientes.ToListAsync());
        
    }
}
