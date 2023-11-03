using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototipo_CAI;

public class Habitacion
{
    public int CodigoDisponibilidad { get; set; }
    public DateOnly Fecha { get; set; }
    public int HabitacionesDisponibles { get; set; }
}