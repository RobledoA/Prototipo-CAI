using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CAI.clases

{
    public class Moneda
    {
        public string moneda { get; set; }
        public decimal precio { get; set; }
    }

    public class Hotel
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Calificacion { get; set; }
        public List<Habitacion> Habitaciones { get; set; }
        public List<ServicioExtraHotel> ServiciosExtra { get; set; }

        public int Disponibilidad
        {
            get
            {
                return Habitaciones.Count;
            }
        }
    }

    public class Habitacion
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public Moneda TarifaDiaria { get; set; }
        public Hotel HotelReferenciado { get; set; }
        public int Capacidad { get; set; }
        public int Adultos { get; set; }
        public int Menores { get; set; }
        public int Infantes { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public List<DiaHabitacion> DiasReservados { get; set; }

        public List<DateTime> ObtenerDiasDisponibles()
        {
            var totalDias = Enumerable.Range(0, (FechaHasta - FechaDesde).Days + 1) // Añadimos +1 para incluir el último día
                                      .Select(offset => FechaDesde.AddDays(offset))
                                      .ToList();

            var diasOcupados = DiasReservados.Where(d => d.ReservaAsociada != null)  // Filtramos los días que tienen reserva
                                             .Select(d => d.FechaHasta)
                                             .ToList();

            return totalDias.Except(diasOcupados).ToList();
        }

   
    }

    public class DiaHabitacion
    {
        public Habitacion HabitacionRef { get; set; }
        public Reserva ReservaAsociada { get; set; }
        public DateTime FechaHasta { get; set; }
        
        public decimal Precio()
        {
            return HabitacionRef.TarifaDiaria.precio;
        }
    }


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
        public List<ServicioExtraVuelo> ServiciosExtra { get; set; }

        public void ReservarVuelo()
        {
            // Lógica para reservar el vuelo
        }

        public void ObtenerAsientosDisponibles()
        {
            // Lógica para obtener asientos disponibles
        }
    }

    public class Tarifa
    {
        public int id { get; set; }
        public char Clase { get; set; }
        public bool RoundTrip { get; set; }
        public char TipoPasajero { get; set; }
        public Moneda PrecioBase { get; set; }
        public decimal Impuestos { get; set; }
        public decimal Comision { get; set; }
        public List<Asiento> Asientos { get; set; }

        public decimal CalcularPrecioFinal()
        {
            // Obtenemos el Precio final de la instancia
            return PrecioBase.precio * (1 + Impuestos) * (1 + Comision);
        }
    }

    public class Asiento
    {
        public string Codigo { get; set; }
        public string Posicion { get; set; }
        public Reserva ReservaAsociada { get; set; }
        public Tarifa TarifaAsociada { get; set; } 

        public decimal Precio()
        {
            //Obtenemos el Precio del Asiento
            return TarifaAsociada.CalcularPrecioFinal();
        }
    }


    public class ServicioExtraVuelo
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public Moneda PrecioBase { get; set; }
        public decimal Impuestos { get; set; }
        public decimal Comision { get; set; }
        public int Disponibilidad { get; set; }

        public decimal CalcularPrecioFinal()
        {
            // Obtenemos el Precio final de la instancia
            return PrecioBase.precio * (1+Impuestos) * (1+Comision);
        }
        public string ObtenerMoneda()
        {
            return PrecioBase.moneda;
        }
    }

    public class ServicioExtraHotel
    {
        public int Clase { get; set; }
        public string Itinerario { get; set; }
        public int TipoReserva { get; set; }
        public Moneda PrecioBase { get; set; }
        public decimal Impuestos { get; set; }
        public decimal Comision { get; set; }
        public int Disponibilidad { get; set; }

        public decimal CalcularPrecioFinal()
        {
            // Obtenemos el Precio final de la instancia
            return PrecioBase.precio * (1 + Impuestos) * (1 + Comision);
        }
    }

    public class Adicional
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public List<Tarifa> Tarifas { get; set; }

        // Método para calcular el precio total de todas sus tarifas
        public decimal CalculaTotalDelAdicional()
        {
            decimal total = 0;
            foreach (var tarifa in Tarifas)
            {
                total += tarifa.CalcularPrecioFinal();
            }
            return total;
        }
    }

    public class Itinerario
    {
        public List<Asiento> AsientosReservados { get; set; }
        public List<DiaHabitacion> HabitacionesReservadas { get; set; }
        public int CodigoItinerario { get; set; }
        public string NombreCliente { get; set; }
        public int CUILCUIT { get; set; }

        public bool EstaReservado(Asiento asiento)
        {
            return AsientosReservados.Contains(asiento);
        }

        private decimal PrecioTotalAsientos()
        {
            decimal total = 0;
            foreach (var asiento in AsientosReservados)
            {
                total += asiento.Precio();
            }
            return total;
        }

        private decimal PrecioTotalHabitacion()
        {
            decimal total = 0;
            foreach (var Habitacion in HabitacionesReservadas)
            {
                total += Habitacion.Precio();
            }
            return total;
        }

        public decimal PrecioTotal()
        {
            return PrecioTotalAsientos() + PrecioTotalHabitacion();
        }
    }


    public class Reserva
    {

    }


}
