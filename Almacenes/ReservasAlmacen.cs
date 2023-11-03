using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CAI;

internal static class ReservasAlmacen
{
    public readonly static List<Reserva> Reservas;

    static ReservasAlmacen()
    {
        var reservasJson = File.ReadAllText("Reservas.json");
        Reservas = JsonConvert.DeserializeObject<List<Reserva>>(reservasJson);
    }

    public static void Grabar()
    {
        var reservasJson = JsonConvert.SerializeObject(Reservas);
        File.WriteAllText("Reservas.json", reservasJson);
    }
}
