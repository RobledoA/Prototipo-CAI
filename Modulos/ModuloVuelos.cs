using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CAI;

internal class ModuloVuelos
{
    public static List<Vuelo> Vuelos = VuelosAlmacen.Vuelos;

    public static List<Vuelo> CargarListaVuelos()
    {
        return Vuelos;
    }

    public static List<TarifaVuelo> ObtenerTarifasItinerarioActivo(List<ListViewItem> list)
    {
        List<TarifaVuelo> tarifasVuelosItinerarioActivo = new();
        foreach (ListViewItem item in list)
        {
            foreach (Vuelo vuelo in Vuelos)
            {
                if (vuelo.CodigoVuelo == item.Text)
                {
                    foreach (TarifaVuelo tarifa in vuelo.Tarifas)
                    {
                        if (vuelo.CodigoVuelo.ToString().Equals(item.Text) && tarifa.CodigoTarifaVuelo.ToString().Equals(item.SubItems[11].Text))
                        {
                            tarifasVuelosItinerarioActivo.Add(tarifa);
                        }
                    }
                }
            }
        }
        return tarifasVuelosItinerarioActivo;
    }

    public static Vuelo ObtenerInfoVuelo(string codVuelo)
    {
        foreach (Vuelo vuelo in Vuelos)
        {
            if (codVuelo == vuelo.CodigoVuelo)
            {
                return vuelo;
            }
        }

        return null;
    }
}
