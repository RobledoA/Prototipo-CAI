using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototipo_CAI.Entidades
{
    public class DiaHabitacion
    {
        public Habitacion HabitacionRef { get; set; }
        public Reserva ReservaAsociada { get; set; }
        public DateTime FechaHasta { get; set; }
    }
}