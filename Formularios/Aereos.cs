using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_CAI;

public partial class Aereos : Form
{
    public Aereos()
    {
        InitializeComponent();
    }

    private void Aereos_Load(object sender, EventArgs e)
    {
        AereosModel model = new();
        if (ModuloItinerarios.ItinerarioActivo == null)
        {
            MessageBox.Show("Si desea agregar productos, establezca un itinerario como activo en el menú Itinerarios.", "Advertencia");
        }
        else
        {
            btnAgregarItinerarioAereos.Enabled = true;
            btnQuitarItinerarioAereos.Enabled = true;
            lblItinerarioActivo.Text = $"Itinerario Nº{ModuloItinerarios.ItinerarioActivo.CodigoItinerario.ToString()}";
            /*foreach (ListViewItem list in model.CargarHotelesItinerarioActivo())
            {
                lsvHotelesAgregados.Items.Add(list);
            }*/
        }
        foreach (ListViewItem item in model.CargarVuelos())
        {
            lsvAereos.Items.Add(item);
        }

    }

    private void lsvAereos_SelectedIndexChanged(object sender, EventArgs e)
    {
        lsvItinerarioAereos.SelectedItems.Clear();
    }

    private void lsvAereosSeleccionados_SelectedIndexChanged(object sender, EventArgs e)
    {
        lsvAereos.SelectedItems.Clear();
    }

    private void btnAgregarItinerarioAereos_Click(object sender, EventArgs e)
    {

        if (lsvAereos.SelectedItems.Count == 0)
        {
            MessageBox.Show("Debe seleccionar un vuelo de la lista izquierda para poder agregarlo", "Error");
        }
        else
        {
            ListViewItem item = lsvAereos.SelectedItems[0];
            lsvItinerarioAereos.Items.Add((ListViewItem)item.Clone());

        }
    }

    private void lsvItinerarioAereos_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btnQuitarItinerarioAereos_Click(object sender, EventArgs e)
    {
        if (lsvItinerarioAereos.SelectedItems.Count > 0)
        {
            lsvItinerarioAereos.Items.Remove(lsvItinerarioAereos.SelectedItems[0]);
        }
        else
        {
            MessageBox.Show("Debe seleccionar un vuelo de la lista derecha para poder quitarlo", "Error");
        }
    }

}
