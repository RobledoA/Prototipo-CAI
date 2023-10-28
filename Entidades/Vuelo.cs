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
        public DateTime FechaHoraSalida { get; set; }
        public DateTime FechaHoraLlegada { get; set; }
        public TimeOnly TiempoVuelo { get; set; }
        public string Aerolinea { get; set; }
        public TarifaVuelo[] Tarifas { get; set; }

        public void ReservarVuelo()
        {
           // Lógica para reservar el vuelo
           // No útil en el contexto actual
        }

        public void CalcularTiempoVuelo()
        {
            //Calcula el tiempo entre fecha salida y fecha llegada
        }
    }
}