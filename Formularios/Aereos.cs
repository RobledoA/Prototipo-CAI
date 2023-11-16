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

    private List<ListViewItem> todosLosVuelos = new List<ListViewItem>();

    private void Aereos_Load(object sender, EventArgs e)
    {
        dtFechaDesdeAereos.Value = new DateTime(1999, 1, 1);
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
        lsvAereos.Items.Clear(); // Limpia la lista antes de cargar nuevos elementos
        todosLosVuelos.Clear();  // Limpia la lista de todos los vuelos

        foreach (ListViewItem item in model.CargarVuelos())
        {
            lsvAereos.Items.Add(item);
            todosLosVuelos.Add(item); // Almacena una copia del elemento
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

    private void FiltrarVuelos()
    {
        string textoFiltroOrigen = txtOrigenAereos.Text.ToLower();
        string textoFiltroDestino = txtDestinoAereos.Text.ToLower();
        DateTime fechaSeleccionada = dtFechaDesdeAereos.Value.Date;
        DateTime fechaPredeterminada = new DateTime(1999, 1, 1); ; // No hay predeterminada pero x las dudas
        string textoTipoPasajero = cmbTipoPasajeroAereos.Text;
        string textoClase = cmbClaseAereos.Text;

        List<ListViewItem> itemsFiltrados = todosLosVuelos.Where(item =>
            (string.IsNullOrWhiteSpace(textoFiltroOrigen) || item.SubItems[3].Text.ToLower().Contains(textoFiltroOrigen)) &&
            (string.IsNullOrWhiteSpace(textoFiltroDestino) || item.SubItems[1].Text.ToLower().Contains(textoFiltroDestino)) &&
            (fechaSeleccionada == fechaPredeterminada || DateTime.Parse(item.SubItems[2].Text).Date == fechaSeleccionada) &&
            (string.IsNullOrWhiteSpace(textoTipoPasajero) || string.Equals(item.SubItems[4].Text, textoTipoPasajero)) &&
            (string.IsNullOrWhiteSpace(textoClase) || string.Equals(item.SubItems[5].Text, textoClase))).ToList();

        lsvAereos.Items.Clear();
        foreach (var item in itemsFiltrados)
        {
            lsvAereos.Items.Add(item);
        }
    }

    private void txtOrigenAereos_TextChanged(object sender, EventArgs e)
    {
        FiltrarVuelos();
    }

    private void txtDestinoAereos_TextChanged(object sender, EventArgs e)
    {
        FiltrarVuelos();
    }

    private void dtFechaDesdeAereos_ValueChanged(object sender, EventArgs e)
    {
        FiltrarVuelos();
    }

    private void cmbTipoPasajeroAereos_SelectedIndexChanged(object sender, EventArgs e)
    {
        FiltrarVuelos();
    }

    private void cmbClaseAereos_SelectedIndexChanged(object sender, EventArgs e)
    {
        FiltrarVuelos();
    }

    private void dtFechaDesdeAereos_CloseUp(object sender, EventArgs e)
    {
        FiltrarVuelos();
    }

    private void btnLimpiarFiltros_Click(object sender, EventArgs e)
    {
        txtOrigenAereos.Clear();
        txtDestinoAereos.Clear();
        dtFechaDesdeAereos.Value = new DateTime(1999, 1, 1);
        cmbTipoPasajeroAereos.SelectedIndex = -1;
        cmbClaseAereos.SelectedIndex = -1;
    }
}
