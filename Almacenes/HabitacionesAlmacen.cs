using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CAI;

internal static class HabitacionesAlmacen
{
    public readonly static List<Habitacion> Habitaciones;

    static HabitacionesAlmacen()
    {
        var habitacionesJson = File.ReadAllText("Habitaciones.json");
        Habitaciones = JsonConvert.DeserializeObject<List<Habitacion>>(habitacionesJson);
    }

    public static void Grabar()
    {
        var habitacionesJson = JsonConvert.SerializeObject(Habitaciones);
        File.WriteAllText("Habitaciones.json", habitacionesJson);
    }
}
