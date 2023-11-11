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
        List<ListViewItem> listViewItem = new List<ListViewItem>();
        List<Reserva> listReservas = ModuloReservas.CargarListaReservas();
        
        foreach (Reserva reservas in listReservas)
        {
            ListViewItem item = new ListViewItem(reservas.CodigoReserva.ToString());
            item.SubItems.Add(reservas.FechaReserva.ToString());
            item.SubItems.Add(reservas.EstadoReserva);
            listViewItem.Add(item);
        }
        return listViewItem;
    }


}
