using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CAI.Entidades
{
    public class Itinerario
    {
        public List<Asiento> AsientosReservados { get; set; }
        public List<Habitacion> HabitacionesReservadas { get; set; }
        public int CodigoItinerario { get; set; }
        public string NombreCliente { get; set; }
        public int CUILCUIT { get; set; }

        public bool EstaReservado(Asiento asiento)
        {
            return AsientosReservados.Contains(asiento);
        }

        private decimal PrecioTotalAsientos()
        {
            decimal total = 0;
            foreach (var asiento in AsientosReservados)
            {
                total += asiento.Precio();
            }
            return total;
        }

        private decimal PrecioTotalHabitacion()
        {
            decimal total = 0;
            foreach (var Habitacion in HabitacionesReservadas)
            {
                total += Habitacion.HabitacionRef.TarifaDiaria;
            }
            return total;
        }

        public decimal PrecioTotal()
        {
            return PrecioTotalAsientos() + PrecioTotalHabitacion();
        }
    }
}
