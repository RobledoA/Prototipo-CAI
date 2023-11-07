using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CAI;

internal class HotelesModel
{
    public List<ListViewItem> FormatoHoteles()
    {
        List<ListViewItem> listViewItem = new List<ListViewItem>();
        List<Hotel> listHotel = ModuloHoteles.CargarListaHoteles();
        foreach (Hotel hotel in listHotel)
        {
            foreach (Disponibilidad disp in hotel.Disponibilidades)
            {
                ListViewItem item = new ListViewItem(hotel.CodigoHotel);
                item.SubItems.Add(ModuloHoteles.ConversorCalificacion(hotel.Calificacion));
                item.SubItems.Add(hotel.CodigoCiudad);
                item.SubItems.Add(hotel.Direccion);
                item.SubItems.Add(hotel.Nombre);
                item.SubItems.Add(Convert.ToString(disp.CodigoDisponibilidad));
                item.SubItems.Add(disp.Nombre);
                item.SubItems.Add(Convert.ToString(disp.DiasDisponibles.Count));
                listViewItem.Add(item);
            }

        }
        return listViewItem;
    }
}
