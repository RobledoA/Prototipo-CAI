using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototipo_CAI.Entidades
{
    public class Tarifa
    {
        public int Id { get; set; }
        public char Clase { get; set; }
        public char TipoPasajero { get; set; }
        public decimal PrecioBase { get; set; }
        public decimal Impuestos { get; set; }
        public decimal Comision { get; set; }
        public List<Asiento> Asientos { get; set; }

        public decimal CalcularPrecioFinal()
        {
            // Obtenemos el Precio final de la instancia
            return PrecioBase * (1 + Impuestos) * (1 + Comision);
        }
    }
}