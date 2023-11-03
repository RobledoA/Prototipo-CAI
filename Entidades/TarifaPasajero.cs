using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CAI;

public class TarifaPasajero
{
    public string Nombre { get; set; }
    public int DNI { get; set; }
    public int Pasaporte { get; set; }
    public DateOnly FechaNacimiento { get; set; }
    public string Nacionalidad { get; set; }
    public string Genero { get; set; }
    public DisponibilidadItinerario DisponibilidadesAsociadas { get; set; }
    public TarifaVueloItinerario TarifasVuelosAsociadas { get; set; }
}
