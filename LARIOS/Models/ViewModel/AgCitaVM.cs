using Microsoft.AspNetCore.Mvc.Rendering;

namespace LARIOS.Models.ViewModel
{
    public class AgCitaVM
    {
        public List<SelectListItem> Pacientes { get; set; }
        public List<SelectListItem> Tratamientos { get; set; }
        public List<SelectListItem> Doctores { get; set; }
    }
}
