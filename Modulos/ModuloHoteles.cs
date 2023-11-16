using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Prototipo_CAI;

internal static class ModuloHoteles
{
    public static List<Hotel> Hoteles = HotelesAlmacen.Hoteles;
    public static List<Hotel> list = new List<Hotel>();

    public static List<Hotel> CargarListaHoteles()
    {
        return Hoteles;
    }

    public static Hotel ObtenerInfoHotel(string codHotel)
    {
        foreach (Hotel hotel in Hoteles)
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
        foreach (Hotel hotel in Hoteles)
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

    public static List<Hotel> BuscarHoteles(string ubicacion, string calificacion, string fechaDesde, string fechaHasta, string cantHabitaciones)
    {
        

        foreach (Hotel hotel in Hoteles)
        {
            list.Add(hotel);
        }

        if (!string.IsNullOrEmpty(ubicacion))
        {
            foreach (Hotel hotel in list.ToList())
            {
                if (hotel.CodigoCiudad != ubicacion)
                {
                    list.Remove(hotel);
                }
            }
        }

        if (!string.IsNullOrEmpty(calificacion))
        {
            foreach (Hotel hotel in list.ToList())
            {
                if (Convert.ToString(hotel.Calificacion) != calificacion)
                {
                    list.Remove(hotel);
                }
            }
        }

        if (!string.Equals(fechaDesde, "01/01/2023") && !string.Equals(fechaHasta, "01/01/2023"))
        {
            foreach (Hotel hotel in list)
            {
                foreach (Disponibilidad disp in hotel.Disponibilidades.ToList())
                {
                    if (!ObtenerDispFecha(disp, fechaDesde, fechaHasta, Convert.ToInt32(cantHabitaciones)))
                    {
                        hotel.Disponibilidades.Remove(disp);
                    }
                }
            }
        }

        return list;
    }

    public static bool ObtenerDispFecha(Disponibilidad disp, string fechaDesde, string fechaHasta, int cantHabitaciones)
    {

        for (DateTime date = Convert.ToDateTime(fechaDesde); date <= Convert.ToDateTime(fechaHasta); date.AddDays(1.0))
        {
            int salida;
            if (!disp.DiasDisponibles.TryGetValue(date, out salida) || salida <= cantHabitaciones)
            {
                return false;
            }
        }
        return true;
    }

    public static List<Disponibilidad> ObtenerDisponibilidadesItinerarioActivo(List<ListViewItem> list)
    {
        List<Disponibilidad> disponibilidadesItinerarioActivo = new();
        foreach (ListViewItem item in list)
        {
            foreach (Hotel hotel in Hoteles)
            {
                if (hotel.CodigoHotel == item.Text)
                {
                    foreach (Disponibilidad disp in hotel.Disponibilidades)
                    {
                        //MessageBox.Show(disp.Nombre, item.Text);
                        if (disp.Nombre == item.SubItems[4].Text)
                        {
                            //MessageBox.Show("encontro la wea madre santa");
                            disponibilidadesItinerarioActivo.Add(disp);
                        }
                    }
                }
            }
        }
        return disponibilidadesItinerarioActivo;
    }

    /*public int CompareTo(object o)
    {
        ModuloHoteles moduloHoteles = (ModuloHoteles)o;
    }*/

}
