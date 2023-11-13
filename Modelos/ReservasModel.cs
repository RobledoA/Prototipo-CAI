using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CAI;

internal class ReservasModel
{
    public List<ListViewItem> FormatoReservas()
    {
        List<ListViewItem> listViewItems = new List<ListViewItem>();
        List<Reserva> listReservas = ModuloReservas.CargarListaReservas();
        List<Itinerario> listItinerarios = ModuloItinerarios.CargarListaItinerarios();

        foreach (Reserva reserva in listReservas)
        {
            Itinerario itinerario = listItinerarios.Find(i => i.CodigoItinerario == reserva.CodigoReserva);

            if (itinerario != null)
            {
                ListViewItem item = new ListViewItem(reserva.CodigoReserva.ToString());
                item.SubItems.Add(itinerario.NombreCliente.ToString());
                item.SubItems.Add(reserva.FechaReserva.ToString());
                item.SubItems.Add(reserva.EstadoReserva);
                listViewItems.Add(item);
            }
        }

        return listViewItems;
    }


}
