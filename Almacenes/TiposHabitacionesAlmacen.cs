using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CAI;

internal static class TiposHabitacionesAlmacen
{
    public readonly static List<TipoHabitacion> TiposHabitaciones;

    static TiposHabitacionesAlmacen()
    {
        var tipoHabitacionesJson = File.ReadAllText("TiposHabitaciones.json");
        TiposHabitaciones = JsonConvert.DeserializeObject<List<TipoHabitacion>>(tipoHabitacionesJson);
    }

    public static void Grabar()
    {
        var tipoHabitacionesJson = JsonConvert.SerializeObject(TiposHabitaciones);
        File.WriteAllText("TiposHabitaciones.json", tipoHabitacionesJson);
    }
}
