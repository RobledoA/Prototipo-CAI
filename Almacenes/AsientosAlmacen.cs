using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CAI;

internal static class AsientosAlmacen
{
    public readonly static List<Asiento> Asientos;

    static AsientosAlmacen()
    {
        var asientosJson = File.ReadAllText("Asientos.json");
        Asientos = JsonConvert.DeserializeObject<List<Asiento>>(asientosJson);
    }

    public static void Grabar()
    {
        var asientosJson = JsonConvert.SerializeObject(Asientos);
        File.WriteAllText("Asientos.json", asientosJson);
    }
}
