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

public partial class Hoteles : Form
{
    public Hoteles()
    {
        InitializeComponent();

    }


    private void Hoteles_Load(object sender, EventArgs e)
    {
        HotelesModel model = new HotelesModel();
        if (ModuloItinerarios.ItinerarioActivo == null)
        {
            MessageBox.Show("Si desea agregar productos, establezca un itinerario como activo en el menú Itinerarios.", "Advertencia");
        }
        else
        {
            btnAgregarItinerarioHoteles.Enabled = true;
            btnQuitarItinerarioHotel.Enabled = true;
            lblItinerarioActivo.Text = $"Itinerario Nº{ModuloItinerarios.ItinerarioActivo.CodigoItinerario.ToString()}";
            foreach (ListViewItem list in model.CargarHotelesItinerarioActivo())
            {
                lsvHotelesAgregados.Items.Add(list);
            }
        }
        foreach (ListViewItem item in model.CargarHoteles())
        {
            lsvHoteles.Items.Add(item);
        }
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void lsvHoteles_SelectedIndexChanged(object sender, EventArgs e)
    {
        lsvHotelesAgregados.SelectedItems.Clear();
    }

    private void lsvHotelesAgregados_SelectedIndexChanged(object sender, EventArgs e)
    {
        lsvHoteles.SelectedItems.Clear();
    }

    private void btnAgregarItinerarioHoteles_Click(object sender, EventArgs e)
    {
        if (lsvHoteles.SelectedItems.Count == 0)
        {
            MessageBox.Show("Debe seleccionar un producto de la lista.", "Error");
        }
        else
        {
            ListViewItem item = lsvHoteles.SelectedItems[0];
            lsvHotelesAgregados.Items.Add(item.Clone() as ListViewItem);
        }
    }

    private void btnQuitarItinerarioHotel_Click(object sender, EventArgs e)
    {
        if (lsvHotelesAgregados.SelectedItems.Count > 0)
        {
            lsvHotelesAgregados.Items.Remove(lsvHotelesAgregados.SelectedItems[0]);
        }
        else
        {
            MessageBox.Show("Debe seleccionar un hotel de la lista derecha para poder quitarlo", "Error");
        }
    }

    private void Hoteles_FormClosed(object sender, FormClosedEventArgs e)
    {
        if (!lblItinerarioActivo.Text.Equals("NO HAY ITINERARIO ACTIVO"))
        {
            HotelesModel model = new();
            List<ListViewItem> list = new List<ListViewItem>();
            foreach (ListViewItem item in lsvHotelesAgregados.Items)
            {
                MessageBox.Show(item.Text);
                list.Add(item);
            }
            model.ActualizarHotelesItinerarioActivo(list);
        }
    }

    private void iconbtnBuscarHoteles_Click(object sender, EventArgs e)
    {
        HotelesModel model = new();
        string ubicacion = txtUbicacionHoteles.Text;
        string calificacion = cmbCalificacionHoteles.Text;
        string fechaDesde = dtpFechaDesdeHoteles.Text;
        string fechaHasta = dtpFechaHastaHoteles.Text;
        string cantHabitaciones = txtHabitacionesHoteles.Text;
        string errores = model.ValidarFiltros(ubicacion, calificacion, fechaDesde, fechaHasta, cantHabitaciones);
        if (string.IsNullOrEmpty(errores))
        {
            List<ListViewItem> hotelesFiltrados = model.FiltrarHoteles(ubicacion, calificacion, fechaDesde, fechaHasta, cantHabitaciones);
            lsvHoteles.Items.Clear();
            foreach (ListViewItem item in hotelesFiltrados)
            {
                lsvHoteles.Items.Add(item);
            }
            if (hotelesFiltrados.Count == 0)
            {
                MessageBox.Show("No se han encontrado hoteles que coincidan con los filtros. Por favor, intente nuevamente.");
            }
        }
        else
        {
            MessageBox.Show(errores, "Error");
        }
    }

    private void iconbtnLimpiarBuscarHoteles_Click(object sender, EventArgs e)
    {
        lsvHoteles.Items.Clear();
        txtUbicacionHoteles.Clear();
        cmbCalificacionHoteles.SelectedIndex = -1;
        dtpFechaDesdeHoteles.Text = "01/01/2023";
        dtpFechaHastaHoteles.Text = "01/01/2023";
        txtHabitacionesHoteles.Clear();
        HotelesModel model = new HotelesModel();
        foreach (ListViewItem item in model.CargarHoteles())
        {
            lsvHoteles.Items.Add(item);
        }
    }
}
