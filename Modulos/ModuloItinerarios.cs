using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CAI;

internal static class ModuloItinerarios
{
    public static List<Itinerario> CargarListaItinerarios()
    {
        return ItinerariosAlmacen.Itinerarios;
    }
}
