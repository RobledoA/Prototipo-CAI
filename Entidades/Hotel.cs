using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototipo_CAI.Entidades
{
    public class Hotel
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Calificacion { get; set; }
        public List<Habitacion> Habitaciones { get; set; }
        public List<ServicioExtraHotel> ServiciosExtra { get; set; }

        public int Disponibilidad()
        {
            return Habitaciones.Count;
        }
    }
}