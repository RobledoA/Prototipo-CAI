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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prototipo_CAI;

public partial class Itinerarios : Form
{
    public Itinerarios()
    {
        InitializeComponent();
    }

    ItinerariosModel model = new ItinerariosModel();
    private void Itinerarios_Load(object sender, EventArgs e)
    {
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
            int ultimoCodigo = lsvItinerario.Items.Count; 
            int codigoSiguiente = ultimoCodigo + 1; //No sirve si se elemina un Itinerario.

            MessageBox.Show($"Se ha creado el itinerario correctamente. Su código de itinerario es {codigoSiguiente}.",
                "Itinerario Creado");
            //Falta que se agregue al Json.

            //Esto debería ir en otro lado?
            var item = new ListViewItem();
            item.Text = codigoSiguiente.ToString();
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
        else
        {
            string codItinerario = lsvItinerario.SelectedItems[0].Text;
            model.CambiarItinerarioActivo(codItinerario);
            MessageBox.Show($"Se ha establecido el itinerario {codItinerario} como activo.");
        }
    }
    private void btnEliminarItinerario_Click(object sender, EventArgs e)
    {
        if (lsvItinerario.SelectedItems.Count == 0)
        {
            MessageBox.Show("Debe seleccionar un itinerario de la lista.", "Error");
        }
        else
        {
            lsvItinerario.SelectedItems[0].Remove();
            //Falta que lo elimine del Json.
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
