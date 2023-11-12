using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_CAI;

internal class HotelesModel
{
    public List<ListViewItem> FormatoHoteles(List<Hotel> listHotel)
    {
        List<ListViewItem> listViewItem = new List<ListViewItem>();
        foreach (Hotel hotel in listHotel)
        {
            foreach (Disponibilidad disp in hotel.Disponibilidades)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(disp.CodigoDisponibilidad));
                item.SubItems.Add(hotel.Nombre);
                item.SubItems.Add(ModuloHoteles.ConversorCalificacion(hotel.Calificacion));
                item.SubItems.Add(hotel.CodigoCiudad);
                item.SubItems.Add(disp.Nombre);
                item.SubItems.Add($"${Convert.ToString(disp.TarifaDiaria)}");
                item.SubItems.Add(Convert.ToString(disp.Capacidad));
                listViewItem.Add(item);
            }
        }
        return listViewItem;
    }

    public List<ListViewItem> FormatoItinerarioHoteles(List<Disponibilidad> listDisponibilidades)
    {
        List<ListViewItem> listViewItem = new List<ListViewItem>();
        foreach (Disponibilidad disp in listDisponibilidades)
        {
            Hotel hotel = ModuloHoteles.ObtenerInfoHotel(Convert.ToString(disp.CodigoHotel));
            ListViewItem item = new ListViewItem(Convert.ToString(disp.CodigoDisponibilidad));
            item.SubItems.Add(hotel.Nombre);
            item.SubItems.Add(ModuloHoteles.ConversorCalificacion(hotel.Calificacion));
            item.SubItems.Add(hotel.CodigoCiudad);
            item.SubItems.Add(disp.Nombre);
            item.SubItems.Add($"${Convert.ToString(disp.TarifaDiaria)}");
            item.SubItems.Add(Convert.ToString(disp.Capacidad));
            listViewItem.Add(item);
        }
        return listViewItem;
    }

    public List<ListViewItem> CargarHoteles()
    {
        List<Hotel> listHotel = ModuloHoteles.CargarListaHoteles();
        List<ListViewItem> list = FormatoHoteles(listHotel);
        return list;
    }

    public List<ListViewItem> CargarHotelesItinerarioActivo()
    {
        List<Disponibilidad> listDisponibilidades = ModuloItinerarios.ItinerarioActivo.Disponibilidades;
        List<ListViewItem> list = FormatoItinerarioHoteles(listDisponibilidades);
        return list;
    }

    public bool GuardarItemsItinerarioActivo(List<ListViewItem> list)
    {
        return true;
    }

}
