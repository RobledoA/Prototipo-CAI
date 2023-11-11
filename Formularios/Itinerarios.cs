using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Prototipo_CAI;

public partial class Itinerarios : Form
{
    public Itinerarios()
    {
        InitializeComponent();
    }

    private void Itinerarios_Load(object sender, EventArgs e)
    {
        ItinerariosModel model = new ItinerariosModel();
        foreach (ListViewItem item in model.FormatoItinerarios())
        {
            lsvItinerario.Items.Add(item);
        }
    }
    private void btnNuevoItinerario_Click(object sender, EventArgs e)
    {
        var r = MessageBox.Show("Desea agregar datos de cliente?", "Crear Itinerario", MessageBoxButtons.YesNoCancel);
        if (r == DialogResult.Yes)
        {
            AgregarClientes agregarClientes = new();
            agregarClientes.ShowDialog();

            //Acá hay que agregar los datos de la pantalla "AgregarClientes".
        }
        if (r == DialogResult.No)
        {
            MessageBox.Show($"Se ha creado el itinerario correctamente. Su código de itinerario es {6}.", "Itinerario Creado");
            //Habría que hacer un contador para el código itinerario.

            var item = new ListViewItem();
            item.Text = "6";
            item.SubItems.Add("");
            item.SubItems.Add("");

            lsvItinerario.Items.Add(item);
        }
    }
    private void btnDatosCliente_Click(object sender, EventArgs e)
    {

    }
    private void btnEstItinerarioActivo_Click(object sender, EventArgs e)
    {
        if (lsvItinerario.SelectedItems.Count == 0)
        {
            MessageBox.Show("Seleccione un itinerario.", "Error");
        }
    }
    private void btnEliminarItinerario_Click(object sender, EventArgs e)
    {
        if (lsvItinerario.SelectedItems.Count == 0)
        {
            MessageBox.Show("Debe seleccionar un producto de la lista.", "Error");
        }
        else
        {
            lsvItinerario.SelectedItems[0].Remove();
        }
    }
    private void btnCrearReserva_Click(object sender, EventArgs e)
    {

        if (lsvItinerario.SelectedItems.Count > 0)
        {
            CrearReserva crearReserva = new();

            crearReserva.ShowDialog();
        }
        else
        {
            MessageBox.Show("Seleccione un itinerario.", "Error");
        }
    }
    /*Esto se puede mejorar con una función y llamar a la función directamente esto es una gronchada. También se puede agregar la función de 
    presionar enter y buscar*/
    private void btnBuscarItinerario_Click(object sender, EventArgs e)
    {
        string idItinerario = txtBuscarItinerario.Text;

        if (!string.IsNullOrWhiteSpace(idItinerario))
        {
            //lsvItinerario.SelectedItems.Clear(); 

            foreach (ListViewItem item in lsvItinerario.Items)
            {
                string codigo = item.Text;
                string cuit = item.SubItems[0].Text;
                string razonsocial = item.SubItems[1].Text;

                //Equals sirve para comprar dos cosas y ver si son iguales en este caso lo ingresado en el txtbox con lo que está en la lsv
                if (codigo.Equals(idItinerario, StringComparison.OrdinalIgnoreCase))
                {
                    lsvItinerario.Items.Clear();
                    lsvItinerario.Items.Add(item);
                }
                if (cuit.Equals(idItinerario, StringComparison.OrdinalIgnoreCase))
                {
                    lsvItinerario.Items.Clear();
                    lsvItinerario.Items.Add(item);
                }
                if (razonsocial.Equals(idItinerario, StringComparison.OrdinalIgnoreCase))
                {
                    lsvItinerario.Items.Clear();
                    lsvItinerario.Items.Add(item);
                }
            }
        }
    }



}
