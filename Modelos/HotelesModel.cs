using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_CAI;

internal class HotelesModel
{
    public List<ListViewItem> FormatoHoteles(List<Hotel> listHotel)
    {
        HotelesModel model = new HotelesModel();
        List<ListViewItem> listViewItem = new List<ListViewItem>();
        foreach (Hotel hotel in listHotel)
        {
            foreach (Disponibilidad disp in hotel.Disponibilidades)
            {
                ListViewItem item = new ListViewItem(hotel.CodigoHotel);
                item.SubItems.Add(hotel.Nombre);
                item.SubItems.Add(model.ConversorCalificacion(hotel.Calificacion));
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
        HotelesModel model = new HotelesModel();
        List<ListViewItem> listViewItem = new List<ListViewItem>();
        foreach (Disponibilidad disp in listDisponibilidades)
        {
            Hotel hotel = ModuloHoteles.ObtenerInfoHotel(Convert.ToString(disp.CodigoHotel));
            ListViewItem item = new ListViewItem(hotel.CodigoHotel);
            item.SubItems.Add(hotel.Nombre);
            item.SubItems.Add(model.ConversorCalificacion(hotel.Calificacion));
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

    public string ValidarFiltros(string ubicacion, string calificacion, string fechaDesde, string fechaHasta, string cantHabitaciones)
    {
        string errores = "";
        if (string.IsNullOrWhiteSpace(ubicacion + calificacion + cantHabitaciones) && fechaDesde == "01/01/2023" && fechaHasta == "01/01/2023")
        {
            errores += "Debe seleccionar un filtro.\n";
            return errores;
        }
        if (!string.IsNullOrWhiteSpace(ubicacion) && !(Regex.IsMatch(ubicacion, @"^[a-zA-Z]+$") && ubicacion.Length == 3))
        {
            errores += "La ubicación debe ser un código formado por 3 letras.\n";
        }
       /* if ((!String.Equals(fechaDesde, "01/01/2023") && Convert.ToDateTime(fechaDesde) < DateTime.Now) || (!String.Equals(fechaHasta, "01/01/2023") && Convert.ToDateTime(fechaHasta) < DateTime.Now))
        {
            errores += "Cualquier fecha ingresada no puede ser anterior a la fecha actual.\n";
        }*/
        if (!string.IsNullOrWhiteSpace(cantHabitaciones))
        {
            errores += ValidarNumeroEntero(cantHabitaciones);
        }


        return errores;
    }

    public string ValidarNumeroEntero(string numero)
    {
        int salida;
        if (!int.TryParse(numero, out salida))
        {
            return "El dato ingresado debe ser un número entero.\n";
        }
        else if (salida <= 0)
        {
            return "El número ingresado debe ser mayor a 0.\n";
        }
        return "";
    }

    public string ConversorCalificacion(int calificacion)
    {
        string estrellas = "";
        for (int i = 1; i <= calificacion; i++)
        {
            estrellas += "★";
        }
        return estrellas;
    }

    public List<ListViewItem> FiltrarHoteles(string ubicacion, string calificacion, string fechaDesde, string fechaHasta, string cantHabitaciones)
    {
        List<Hotel> hotelesFiltrados = ModuloHoteles.BuscarHoteles(ubicacion, calificacion, fechaDesde, fechaHasta, cantHabitaciones);
        List<ListViewItem> listViewHoteles = new();
        foreach (ListViewItem item in FormatoHoteles(hotelesFiltrados))
        {
            listViewHoteles.Add(item);
        }
        return listViewHoteles;
    }

    public void ActualizarHotelesItinerarioActivo(List<ListViewItem> list)
    {
        List<Disponibilidad> disp = ModuloHoteles.ObtenerDisponibilidadesItinerarioActivo(list);
        ModuloItinerarios.AgregarDisponibilidadesAItinerarioActivo(disp);
    }
}
