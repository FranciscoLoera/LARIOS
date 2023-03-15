using System;
using System.Collections.Generic;

namespace LARIOS.Models;

public partial class Cita
{
    public int Id { get; set; }

    public string Paciente { get; set; } = null!;

    public string Tratamiento { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string Hora { get; set; } = null!;

    public string Doctor { get; set; } = null!;
}
