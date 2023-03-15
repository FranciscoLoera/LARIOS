using LARIOS.Models;
using LARIOS.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace LARIOS.Controllers
{
    public class HomeController : Controller        ///CITAS
    {
        private readonly PruebaCitasContext _context;
        public HomeController(PruebaCitasContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var citas=_context.Citas;
            return View(await citas.ToListAsync());
        }

        public IActionResult AgCita()
        {
            var model = new AgCitaVM
            {
                Pacientes = _context.Pacientes
                    .Select(p => new SelectListItem
                    {
                        Value = p.Id.ToString(),
                        Text = p.Nombre
                    })
                    .ToList(),
                Tratamientos = _context.Tratamientos
                    .Select(t => new SelectListItem
                    {
                        Value = t.Id.ToString(),
                        Text = t.Tratamientos
                    })
                    .ToList(),
                Doctores = _context.Doctores
                    .Select(t => new SelectListItem
                    {
                        Value = t.Id.ToString(),
                        Text = t.Doctor
                    })
                    .ToList()
            };

            return View(model);
        }


    }
}