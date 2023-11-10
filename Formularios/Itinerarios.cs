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
        lsvItinerario.SelectedIndexChanged += lsvItinerario_SelectedIndexChanged; //H
    }

    private void Itinerarios_Load(object sender, EventArgs e)
    {
        ItinerariosModel model = new ItinerariosModel();
        foreach (ListViewItem item in model.FormatoItinerarios())
        {
            lsvItinerario.Items.Add(item);
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        if (lsvItinerario.SelectedItems.Count > 0)
        {
            ListViewItem item = lsvItinerario.SelectedItems[0];
            lsvItinerario.Items.Remove(item);
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
            //lsvItinerario.SelectedItems.Clear();  pa que sirve esto

            foreach (ListViewItem item in lsvItinerario.Items)
            {
                string idElemento = item.Text;
                string cuit = item.SubItems[0].Text;
                string razonsocial = item.SubItems[1].Text;

                //Equals sirve para comprar dos cosas y ver si son iguales en este caso lo ingresado en el txtbox con lo que está en la lsv
                if (idElemento.Equals(idItinerario, StringComparison.OrdinalIgnoreCase))
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

        else
        {
            lsvItinerario.Items.Clear();
            FileInfo fi = new("itinerario.txt");
            StreamReader sr = fi.OpenText();
            while (!sr.EndOfStream)
            {
                string linea = sr.ReadLine();
                string[] vector = linea.Split(';');
                ListViewItem item = new(vector[0]);
                item.SubItems.Add(vector[1]);
                item.SubItems.Add(vector[2]);
                lsvItinerario.Items.Add(item);

            }

            sr.Close();
        }



    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void lsvItinerario_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

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

    private void btnNuevoItinerario_Click(object sender, EventArgs e)
    {
        var r = MessageBox.Show("Desea agregar datos de cliente?", "Crear Itinerario", MessageBoxButtons.YesNoCancel);
        if (r == DialogResult.Yes)
        {
            AgregarClientes agregarClientes = new();
            agregarClientes.ShowDialog();
        }
        if (r == DialogResult.No)
        {
            MessageBox.Show($"Se ha creado el itinerario correctamente. Su código de itinerario es {1}.", "Itinerario Creado");
        }

    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (lsvItinerario.SelectedItems.Count == 0)
        {
            MessageBox.Show("Seleccione un itinerario.", "Error");
        }
    }

    private void lsvItinerario_SelectedIndexChanged_1(object sender, EventArgs e)
    {

    }
}
