using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototipo_CAI.Entidades
{
    public class ServicioExtraVuelo
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioBase { get; set; }
        public decimal Impuestos { get; set; }
        public decimal Comision { get; set; }
        public int Disponibilidad { get; set; }

        public decimal CalcularPrecioFinal()
        {
            // Obtenemos el Precio final de la instancia
            return PrecioBase * (1 + Impuestos) * (1 + Comision);
        }
    }
}