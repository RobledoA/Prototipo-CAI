﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

    public string ModificarCliente(string nombre, string cuilcuit)
    {
        if (string.IsNullOrWhiteSpace(nombre))
        {          
            return "El campo Nombre/Razón Social no debe estar vacío.";
        }
        if (!string.IsNullOrWhiteSpace(nombre) && !(Regex.IsMatch(nombre, @"^[a-zA-Z]+$")))
        {
            return "El campo Nombre/Razón Social no debe ser numérico.\n";
        }
        if (cuilcuit.Length > 30)
        {
            return "El campo Nombre/Razón Social debe tener menos de 30 caracteres.";
        }
        if (string.IsNullOrWhiteSpace(cuilcuit))
        {
            return "El campo CUIL/CUIT no debe estar vacío.";
        }
        if (cuilcuit.Length != 11)
        {
            return "El campo CUIL/CUIT debe tener 11 dígitos.";
        }
        if (!long.TryParse(cuilcuit, out long cuilcuitNumero))
        {
            return "El campo CUIL/CUIT debe ser numérico.";
        }
      
        return null;
    }
    
    public string ValidarCampos(string nombreRZ, string cuilcuit)
    {
        string errores = "";

        if (string.IsNullOrWhiteSpace(nombreRZ))
        {
            errores += "El campo Nombre/Razón Social no debe estar vacío.\n";
        }
        if (!string.IsNullOrWhiteSpace(nombreRZ) && !(Regex.IsMatch(nombreRZ, @"^[a-zA-Z]+$")))
        {
            errores += "El campo Nombre/Razón Social no debe ser numérico.\n";
        }
        if (nombreRZ.Length > 30)
        {
            errores += "El campo Nombre/Razón Social debe tener menos de 30 caracteres.\n";
        }
        if (string.IsNullOrWhiteSpace(cuilcuit))
        {
            errores += "El campo CUIL/CUIT no debe estar vacío.\n";
        }
        if (!long.TryParse(cuilcuit, out long salida))
        {
            errores += "El campo CUIL/CUIT debe ser un número.\n";
        }
        if (cuilcuit.Length != 11)
        {
            errores += "El campo CUIL/CUIT debe tener 11 dígitos.\n";
        }

        return errores;
    }

    public void ModificarItinerario(string codItinerario, string nombre, string CUIL)
    {
        ModuloItinerarios.ModificarItinerario(codItinerario, nombre, CUIL);
    }

    public void EliminarItinerario(string codItinerario)
    {
        ModuloItinerarios.EliminarItinerario(codItinerario);
    }
    public void AgregarItinerario(int codigoItinerario, string cuilcuit, string nombrecliente)
    {
        Itinerario itinerario = new();

        itinerario.CodigoItinerario = codigoItinerario;
        itinerario.NombreCliente = nombrecliente;
        itinerario.CUILCUIT = cuilcuit;
        itinerario.TarifasVuelos = new List<TarifaVuelo>();
        itinerario.Disponibilidades = new List<Disponibilidad>();
        itinerario.EstaReservado = false;

        ModuloItinerarios.AgregarItinerario(itinerario);
    }
}
