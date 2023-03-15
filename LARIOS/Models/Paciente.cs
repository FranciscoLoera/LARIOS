using System;
using System.Collections.Generic;

namespace LARIOS.Models;

public partial class Paciente
{
    internal string nombre;

    public int? Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Email { get; set; }

    public string? Telefono { get; set; }
}
