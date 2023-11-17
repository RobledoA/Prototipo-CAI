using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CAI;

public class Itinerario
{
    public int CodigoItinerario { get; set; }
    public string CUILCUIT { get; set; }
    public List<ItinerarioHotel> Disponibilidades { get; set; }
    public bool EstaReservado { get; set; }
    public string NombreCliente { get; set; }
    public List<TarifaVuelo> TarifasVuelos { get; set; }

    /*private decimal PrecioTotalAsientos()
    {
        decimal total = 0;
        foreach (var asiento in AsientosReservados)
        {
            total += asiento.Precio();
        }
        return total;
    }*/

    /*private decimal PrecioTotalHabitacion()
    {
        decimal total = 0;
        foreach (var Habitacion in HabitacionesReservadas)
        {
            total += Habitacion.HabitacionRef.TarifaDiaria;
        }
        return total;
    }*/

    /*public decimal PrecioTotal()
    {
        return PrecioTotalAsientos() + PrecioTotalHabitacion();
    }*/
}
