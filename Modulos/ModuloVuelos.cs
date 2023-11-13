using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CAI;

internal class ModuloVuelos
{
    public static List<Vuelo> Vuelos = VuelosAlmacen.Vuelos;

    public static List<Vuelo> CargarListaVuelos()
    {
        return Vuelos;
    }
}
