using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
}
