using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototipo_CAI;

public class Vuelo
{
    public int CodigoVuelo { get; set; }
    public string Aerolinea { get; set; }
    public string Destino { get; set; }
    public DateTime FechaHoraSalida { get; set; }
    public DateTime FechaHoraLlegada { get; set; }
    public string Origen { get; set; }
    public TarifaVuelo[] Tarifas { get; set; }
    public TimeOnly TiempoVuelo { get; set; }


    /*public void CalcularTiempoVuelo()
    {
        //Calcula el tiempo entre fecha salida y fecha llegada
    }*/
}