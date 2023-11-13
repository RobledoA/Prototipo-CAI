using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CAI;

internal static class ModuloItinerarios
{
    public static List<Itinerario> Itinerarios = ItinerariosAlmacen.Itinerarios;

    public static Itinerario ItinerarioActivo;

    public static List<Itinerario> CargarListaItinerarios()
    {
        return Itinerarios;
    }

    public static void EstablecerItinerarioActivo(Itinerario itinerario)
    {
        ItinerarioActivo = itinerario;
    }

    public static Itinerario BuscarItinerario(string codItinerario)
    {
        foreach (Itinerario itinerario in Itinerarios)
        {
            if (Convert.ToInt32(codItinerario) == itinerario.CodigoItinerario)
            {
                return itinerario;
            }
        }

        return null;
    }

    public static void GuardarDisponibilidadEnItinerarioActivo(List<Disponibilidad> disponibilidad)
    {
        ItinerarioActivo.Disponibilidades.Clear();
        foreach (Disponibilidad disp in disponibilidad)
        {
            ItinerarioActivo.Disponibilidades.Add(disp);
        }
    }

    public static Itinerario LlamarItinerarioActivo()
    {
        return ItinerarioActivo;
    }
}
