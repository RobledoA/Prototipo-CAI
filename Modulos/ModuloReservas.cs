using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CAI;

internal class ModuloReservas
{
    public static List<Reserva> Reservas = ReservasAlmacen.Reservas;

    public static List<Reserva> CargarListaReservas()
    {
        return Reservas;
    }
}
