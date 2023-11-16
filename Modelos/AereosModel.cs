using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CAI;
internal class AereosModel
{
    public List<ListViewItem> FormatoVuelos(List<Vuelo> list)
    {
        List<ListViewItem> listViewItems = new List<ListViewItem>();
        foreach (Vuelo vuelo in list)
        {
            foreach (TarifaVuelo tarifa in vuelo.Tarifas)
            {
                ListViewItem item = new ListViewItem(vuelo.CodigoVuelo.ToString());
                item.SubItems.Add(vuelo.Destino);
                item.SubItems.Add(vuelo.FechaHoraSalida.ToString()); // Formato de fecha y hora
                item.SubItems.Add(vuelo.Origen);
                item.SubItems.Add(tarifa.TipoPasajero.ToString());
                item.SubItems.Add(tarifa.Clase.ToString());
                item.SubItems.Add(tarifa.Precio.ToString());
                item.SubItems.Add(tarifa.TarifasVuelosDisponibles.ToString());
                item.SubItems.Add(vuelo.FechaHoraLlegada.ToString());
                item.SubItems.Add(vuelo.TiempoVuelo);
                item.SubItems.Add(vuelo.Aerolinea);

                listViewItems.Add(item);
            }
            
        }

        return listViewItems;
    }

    public List<ListViewItem> CargarVuelos()
    {
        List<Vuelo> listVuelo = ModuloVuelos.CargarListaVuelos();
        List<ListViewItem> list = FormatoVuelos(listVuelo);
        return list;
    }
}
