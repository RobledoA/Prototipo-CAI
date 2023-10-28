    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototipo_CAI.Entidades
{
    public class Asiento
    {
        public string Codigo { get; set; }
        public string Posicion { get; set; }
        public Reserva ReservaAsociada { get; set; }
        public TarifaVuelo TarifaAsociada { get; set; }

        public decimal Precio()
        {
            //Obtenemos el Precio del Asiento
            return TarifaAsociada.CalcularPrecioFinal();
        }
    }

}