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
