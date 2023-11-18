using Prototipo_CAI.Modelos;
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

    private List<ListViewItem> todosLosHoteles = new List<ListViewItem>();
    internal DateTime fechaPredeterminada = new DateTime(1999, 1, 1);

    private void Hoteles_Load(object sender, EventArgs e)
    {
        dtpFechaDesdeHoteles.Value = fechaPredeterminada;
        dtpFechaHastaHoteles.Value = fechaPredeterminada;
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

        lsvHoteles.Items.Clear(); // Limpia la lista antes de cargar nuevos elementos
        todosLosHoteles.Clear();  // Limpia la lista de todos los vuelos
        foreach (ListViewItem item in model.CargarHoteles())
        {
            lsvHoteles.Items.Add(item);
            todosLosHoteles.Add(item);
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
        else if (dtpFechaDesdeHoteles.Value.Date == fechaPredeterminada || dtpFechaHastaHoteles.Value.Date == fechaPredeterminada)
        {
            MessageBox.Show("Debe establecer una fecha en los filtros si desea agregar un hotel.", "Error");
        }
        else
        {
            ListViewItem item = lsvHoteles.SelectedItems[0];
            var itemAgregado = lsvHotelesAgregados.Items.Add(item.Clone() as ListViewItem);
            itemAgregado.Tag = new DesdeHasta { Desde = dtpFechaDesdeHoteles.Value, Hasta = dtpFechaHastaHoteles.Value };
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

    private void btnLimpiarFiltros_Click(object sender, EventArgs e)
    {

        lsvHoteles.Items.Clear();
        txtUbicacionHoteles.Clear();
        cmbCalificacionHoteles.SelectedIndex = -1;
        dtpFechaDesdeHoteles.Value = new DateTime(1999, 1, 1);
        dtpFechaHastaHoteles.Value = new DateTime(1999, 1, 1);
        txtHabitacionesHoteles.Clear();
        cmbTipoHabitacion.SelectedIndex = -1;
        HotelesModel model = new HotelesModel();
        foreach (ListViewItem item in model.CargarHoteles())
        {
            lsvHoteles.Items.Add(item);
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
                list.Add(item);
            }
            model.ActualizarHotelesItinerarioActivo(list);
        }
    }

    private void FiltrarHoteles()
    {
        HotelesModel model = new();
        string ubicacion = txtUbicacionHoteles.Text.ToLower();
        string calificacion = cmbCalificacionHoteles.Text;
        DateTime fechaDesde = dtpFechaDesdeHoteles.Value.Date;
        DateTime fechaHasta = dtpFechaHastaHoteles.Value.Date;
        string cantHabitaciones = txtHabitacionesHoteles.Text;
        string tipoHabitacion = cmbTipoHabitacion.Text;
        if (string.IsNullOrWhiteSpace(cantHabitaciones) || !int.TryParse(cantHabitaciones, out int salida))
        {
            cantHabitaciones = "1";
        }
        List<string> filtroFecha = model.FiltrarDisponibilidad(fechaDesde, fechaHasta, cantHabitaciones);

        List<ListViewItem> itemsFiltrados = todosLosHoteles.Where(item =>
            (string.IsNullOrWhiteSpace(ubicacion) || item.SubItems[3].Text.ToLower().Contains(ubicacion)) &&
            (string.IsNullOrWhiteSpace(calificacion) || item.SubItems[2].Text.Equals(calificacion)) &&
            (string.IsNullOrWhiteSpace(tipoHabitacion) || string.Equals(item.SubItems[4].Text, tipoHabitacion)) &&
            (fechaDesde == fechaPredeterminada || fechaHasta == fechaPredeterminada || filtroFecha.Contains(item.SubItems[7].Text))).ToList();

        lsvHoteles.Items.Clear();
        foreach (var item in itemsFiltrados)
        {
            lsvHoteles.Items.Add(item);
        }
    }

    private void txtUbicacionHoteles_TextChanged(object sender, EventArgs e)
    {
        FiltrarHoteles();
    }

    private void cmbCalificacionHoteles_TextChanged(object sender, EventArgs e)
    {
        FiltrarHoteles();
    }

    private void dtpFechaDesdeHoteles_ValueChanged(object sender, EventArgs e)
    {
        FiltrarHoteles();
    }

    private void dtpFechaHastaHoteles_ValueChanged(object sender, EventArgs e)
    {
        FiltrarHoteles();
    }

    private void txtHabitacionesHoteles_TextChanged(object sender, EventArgs e)
    {
        FiltrarHoteles();
    }

    private void cmbTipoHabitacion_TextChanged(object sender, EventArgs e)
    {
        FiltrarHoteles();
    }

    private void iconbtnLimpiarBuscarHoteles_Click(object sender, EventArgs e)
    {
        lsvHoteles.Items.Clear();
        txtUbicacionHoteles.Clear();
        cmbCalificacionHoteles.SelectedIndex = -1;
        dtpFechaDesdeHoteles.Value = fechaPredeterminada;
        dtpFechaHastaHoteles.Value = fechaPredeterminada;
        txtHabitacionesHoteles.Clear();
        cmbTipoHabitacion.SelectedIndex = -1;
        HotelesModel model = new HotelesModel();
        foreach (ListViewItem item in model.CargarHoteles())
        {
            lsvHoteles.Items.Add(item);
        }
    }

}
