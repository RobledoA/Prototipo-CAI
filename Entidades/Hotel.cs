using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototipo_CAI;

public class Hotel
{
    public int Codigo { get; set; }
    public string Nombre { get; set; }
    public string codigoCiudad { get; set; }
    public string Direccion { get; set; }
    public int Calificacion { get; set; }
    public List<TipoHabitacion> Disponibilidad { get; set; }

    public int CalcularDisponibilidad()
    {
        return Disponibilidad.Count;
    }
}