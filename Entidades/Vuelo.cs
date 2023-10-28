using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototipo_CAI.Entidades
{
    public class Vuelo
    {
        public int Codigo { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public int Plazas { get; set; }
        public DateTime FechaHoraSalida { get; set; }
        public DateTime FechaHoraLlegada { get; set; }
        public DateTime TiempoUso { get; set; }
        public string Aerolinea { get; set; }
        public Tarifa Tarifa { get; set; }

        public void ReservarVuelo()
        {
            // Lógica para reservar el vuelo
        }

        public void ObtenerAsientosDisponibles()
        {
            // Lógica para obtener asientos disponibles
        }
    }
}