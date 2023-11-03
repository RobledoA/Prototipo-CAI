using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CAI;

internal static class TarifasVuelosAlmacen
{
    public readonly static List<TarifaVuelo> TarifasVuelos;

    static TarifasVuelosAlmacen()
    {
        var tarifasVuelosJson = File.ReadAllText("TarifasVuelos.json");
        TarifasVuelos = JsonConvert.DeserializeObject<List<TarifaVuelo>>(tarifasVuelosJson);
    }

    public static void Grabar()
    {
        var tarifasVuelosJson = JsonConvert.SerializeObject(TarifasVuelos);
        File.WriteAllText("TarifasVuelos.json", tarifasVuelosJson);
    }
}
