using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Prototipo_CAI;

internal class CrearReservaModel
{
    public string ValidarCampos(string nombreApellido, string dni, DateTime fechaNac, string nacionalidad, string genero)
    {
        string errores = "";

        //Nombre y Apellido
        if (string.IsNullOrWhiteSpace(nombreApellido))
        {
            errores += "El Nombre y Apellido no debe estar vacío.\n";
        }
        else if (!(Regex.IsMatch(nombreApellido, @"^[a-zA-Z\s]+$")))
        {
            errores += "El Nombre y Apellido no debe contener caracteres numéricos o símbolos.\n";
            
        }
        if (nombreApellido.Length > 45)
        {
            errores += "El Nombre y Apellido no puede tener más de 45 caracteres.\n";
        }
        //DNI
        if (string.IsNullOrWhiteSpace(dni))
        {
            errores += "El DNI no debe estar vacío.\n";
        }
        if (!int.TryParse(dni, out int salida))
        {
            errores += "El DNI debe ser numérico.\n";
        }
        if (dni.Length < 7 || dni.Length > 8)
        {
            errores += "El DNI debe tener entre 7 y 8 dígitos.\n";
        }
        //Fecha de Nacimiento
        if (fechaNac > DateTime.Now)
        {
            errores += "La Fecha de Nacimiento debe ser menor a la fecha actual.";
        }
        //Nacionalidad
        if(string.IsNullOrWhiteSpace(nacionalidad))
        {
            errores += "La Nacionalidad no debe estar vacía.\n";
        }
        //Género
        if (string.IsNullOrWhiteSpace(genero))
        {
            errores += "El Género no debe estar vacío.\n";
        }

        return errores;
    }

    public Itinerario ObtenerItinerarioActivo()
    {
        return ModuloItinerarios.ItinerarioActivo;
    }

    public Hotel ObtenerInfoHotel(string codHotel)
    {
        Hotel hotel = ModuloHoteles.ObtenerInfoHotel(codHotel);
        return hotel;
    }

    public Vuelo ObtenerInfoVuelo(string codVuelo)
    {
        Vuelo vuelo = ModuloVuelos.ObtenerInfoVuelo(codVuelo);
        return vuelo;
    }

    public string ValidarPasajeroTarifas(List<ItemCheckBox> list)
    {
        string cosa = string.Empty;
        foreach (ItemCheckBox item in list)
        {
            if (item.Hotel == null)
            {
                cosa+="vuelo;";
            }
            if (item.Vuelo == null)
            {
                cosa+="hotel";
            }
        }
        return cosa;
    }

    public ListViewItem FormatoPasajeroReserva(string nombreApellido, string dni, DateTime fechaNac, string nacionalidad, string genero, string tarifasAsociadas)
    {
        ListViewItem item = new ListViewItem(nombreApellido);
        item.SubItems.Add(dni);
        item.SubItems.Add(nacionalidad);
        item.SubItems.Add(genero);
        item.SubItems.Add(fechaNac.ToString("dd-MM-yyyy"));
        item.SubItems.Add(tarifasAsociadas);
        return item;

    }

    public bool ValidarUsoTarifas(List<ItemCheckBox> listcb, List<ListViewItem> listlsv)
    {
        // crear lista con todas las tarifas usadas

        List<int> CodigosTarifas = new();
        foreach (ListViewItem item in listlsv)
        {
            string[] vector = item.SubItems[5].Text.Split(';');
            foreach (string s in vector)
            {
                if (!CodigosTarifas.Contains(Convert.ToInt32(s)))
                {
                    CodigosTarifas.Add(Convert.ToInt32(s));
                }
            }
        }

        // comparar listas 1 y 2

        foreach (ItemCheckBox item in listcb)
        {
            if (!CodigosTarifas.Contains(item.CodTarifa))
            {
                return false;
            }
        }

        return true;
    }

    public string ValidarRepetidos(string dni, List<ListViewItem> list)
    {
        foreach (ListViewItem item in list)
        {
            if (item.SubItems[1].Text == dni)
            {
                return "No puede haber 2 pasajeros con el mismo DNI.";
            }
        }
        return "";
    }

    public string ValidarDisponibilidadTarifas(List<ItemCheckBox> list)
    {
        Dictionary<TarifaVuelo,int> listTarifaVuelos = new();
        List<ItinerarioHotel> temp = new();
        Dictionary<ItinerarioHotel, int> listItinerarioHotel = new();
        string errores = string.Empty;

        // LLENO LISTA DE TARIFAVUELO ACUMULADOS POR MISMA TARIFAVUELO

        foreach (ItemCheckBox item in list)
        {
            if (item.Hotel == null)
            {
                if (!listTarifaVuelos.TryGetValue(item.Vuelo, out int salida))
                {
                    listTarifaVuelos.Add(item.Vuelo, 1);
                }
                else
                {
                    listTarifaVuelos[item.Vuelo]++;
                }
            }
            if (item.Vuelo == null)
            {
                temp.Add(item.Hotel);
            }
        }

        // LISTA TEMPORAL PARA SEPARAR HOTELES DE VUELOS Y ACUMULAR HABITACIONES EN NUEVA LISTA

        foreach (ItinerarioHotel itinerarioHotel in temp)
        {
            bool flag = false;

            foreach (KeyValuePair<ItinerarioHotel, int> item in listItinerarioHotel)
            {
                if (itinerarioHotel.Disponibilidad == item.Key.Disponibilidad && itinerarioHotel.Desde == item.Key.Desde && itinerarioHotel.Hasta == item.Key.Hasta)
                {
                    listItinerarioHotel[item.Key]++;
                    flag = true;
                }
            }
            if (!flag)
            {
                listItinerarioHotel.Add(itinerarioHotel, 1);
            }
            flag = false;
        }

        // DEBUG, IGNORAR

        /*foreach (KeyValuePair<ItinerarioHotel, int> item in listItinerarioHotel)
        {
            MessageBox.Show($"Veces que uso este tipo habitación: {item.Value}");
        }
        foreach (KeyValuePair<TarifaVuelo,int> item in listTarifaVuelos)
        {
            MessageBox.Show($"Veces que uso este asiento: {item.Value}");
        }*/

        // FUNCIONES PARA VALIDAD DISPONIBILIDAD

        foreach (KeyValuePair<TarifaVuelo,int> kvp in listTarifaVuelos)
        {
            errores += ModuloVuelos.ValidarDisponibilidadVuelo(kvp.Key,kvp.Value);
        }
        foreach (KeyValuePair<ItinerarioHotel, int> kvp in listItinerarioHotel)
        {
            errores += ModuloHoteles.ValidarDisponibilidadHoteles(kvp.Key, kvp.Value);
        }

        return errores;

        // NO LA PROBE MUCHO, HAY QUE FORZAR BASTANTE ESTA FUNCION A VER SI SE ROMPE
    }

}
