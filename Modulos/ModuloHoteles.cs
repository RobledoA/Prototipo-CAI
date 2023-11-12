using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Prototipo_CAI;

internal static class ModuloHoteles
{
    public static List<Hotel> CargarListaHoteles()
    {
        return HotelesAlmacen.Hoteles;
    }

    public static string ConversorCalificacion(int calificacion)
    {
        string estrellas = "";
        for (int i = 1; i <= calificacion; i++)
        {
            estrellas+="★";
        }
        return estrellas;
    }

    public static string ValidarFiltros(string ubicacion, string calificacion, string fechaDesde, string fechaHasta, string cantHabitaciones)
    {
        string errores = "";
        int salida = 0;
        if (string.IsNullOrWhiteSpace(ubicacion+calificacion+cantHabitaciones) && fechaDesde == "01/01/2023" && fechaHasta == "01/01/2023")
        {
            errores += "Debe seleccionar un filtro.\n";
            return errores;
        }
        if (!string.IsNullOrWhiteSpace(ubicacion) && !(Regex.IsMatch(ubicacion, @"^[a-zA-Z]+$") && ubicacion.Length == 3))
        {
            errores += "La ubicación debe ser un código formado por 3 letras.\n";
        }
        if ((!String.Equals(fechaDesde,"01/01/2023") && Convert.ToDateTime(fechaDesde) < DateTime.Now) || (!String.Equals(fechaHasta,"01/01/2023") && Convert.ToDateTime(fechaHasta) < DateTime.Now))
        {
            errores += "Cualquier fecha ingresada no puede ser anterior a la fecha actual.\n";
        }
        if (!string.IsNullOrWhiteSpace(ubicacion) && !int.TryParse(cantHabitaciones, out salida))
        {
            errores += "La cantidad de habitaciones debe ser un número entero.\n";
        }
        else
        {
            if (Convert.ToInt32(cantHabitaciones) < 1)
            {
                errores += "La cantidad de habitaciones debe ser mayor que 0.\n";
            }
        }
        return errores;
    }

    public static Hotel ObtenerInfoHotel(string codHotel)
    {
        foreach (Hotel hotel in HotelesAlmacen.Hoteles)
        {
            if (codHotel == hotel.CodigoHotel)
            {
                return hotel;
            }
        }

        return null;
    }

    public static Disponibilidad ObtenerInfoDisponibilidad(string codHotel, string codDisponibilidad)
    {
        foreach (Hotel hotel in HotelesAlmacen.Hoteles)
        {
            if (codHotel == hotel.CodigoHotel)
            {
                foreach (Disponibilidad disp in hotel.Disponibilidades)
                {
                    if (codDisponibilidad == Convert.ToString(disp.CodigoDisponibilidad))
                    {
                        return disp;
                    }
                }
            }
        }
        return null;
    }


    /*public static string FiltrarHoteles(string ubicacion, string calificacion, string fechaDesde, string fechaHasta, string cantHabitaciones)
    {
        List<Hotel> list = new List<Hotel>();
        if (!string.IsNullOrEmpty(ubicacion))
        {
            foreach (Hotel hotel in HotelesAlmacen.Hoteles)
            {
                if (hotel.CodigoCiudad == ubicacion)
                {
                    list.Add(hotel);
                }
            }
        }
        
        if (!string.IsNullOrEmpty(calificacion))
        {
            foreach (Hotel hotel in list)
            {
                if (Convert.ToString(hotel.Calificacion) != calificacion)
                {
                    list.Remove(hotel);
                }
            }
        }

        if (!string.Equals(fechaDesde,"01/01/2023"))
        {
            foreach (Hotel hotel in list)
            {
                for (DateTime date = Convert.ToDateTime(fechaDesde); date <= Convert.ToDateTime(fechaHasta); date.AddDays(1))
                {

                }
            }
        }



    }*/

}
