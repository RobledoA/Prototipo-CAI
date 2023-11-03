using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototipo_CAI;

public class Disponibilidad
{
    public int CodigoDisponibilidad { get; set; }
    public int CodigoHotel { get; set; }
    public string Nombre { get; set; }
    public int Capacidad { get; set; }
    public int Adultos { get; set; }
    public int Infantes { get; set; }
    public int Menores { get; set; }
    public List<Habitacion> DiasDisponibles { get; set; }
    public decimal TarifaDiaria { get; set; }

    /*public List<DateTime> ObtenerDiasDisponibles()
    {
        var totalDias = Enumerable.Range(0, (FechaHasta - FechaDesde).Days + 1) // Añadimos +1 para incluir el último día
                                  .Select(offset => FechaDesde.AddDays(offset))
                                  .ToList();

        var diasOcupados = DiasReservados.Where(d => d.ReservaAsociada != null)  // Filtramos los días que tienen reserva
                                         .Select(d => d.FechaHasta)
                                         .ToList();

        return totalDias.Except(diasOcupados).ToList();
    }*/
}