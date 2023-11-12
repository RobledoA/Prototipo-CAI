using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CAI;

internal class ItinerariosModel
{
    public List<ListViewItem> FormatoItinerarios()
    {
        List<ListViewItem> listViewItem = new List<ListViewItem>();
        List<Itinerario> listitinerario = ModuloItinerarios.CargarListaItinerarios();

        foreach (Itinerario itinerario in listitinerario)
        {
            ListViewItem item = new ListViewItem(itinerario.CodigoItinerario.ToString());
            item.SubItems.Add(itinerario.CUILCUIT.ToString());
            item.SubItems.Add(itinerario.NombreCliente);
            listViewItem.Add(item);
        }

        return listViewItem;
    }

    public void CambiarItinerarioActivo(string codItinerario)
    {
        Itinerario itinerario = ModuloItinerarios.BuscarItinerario(codItinerario);
        ModuloItinerarios.EstablecerItinerarioActivo(itinerario);
    }
}
