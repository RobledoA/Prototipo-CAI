using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_CAI
{
    public partial class Hoteles : Form
    {
        public Hoteles()
        {
            InitializeComponent();
        }


        private void Hoteles_Load(object sender, EventArgs e)
        {
            HotelesModel model = new HotelesModel();
            foreach (ListViewItem item in model.FormatoHoteles())
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (lsvHotelesAgregados.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un producto de la lista.", "Error");
            }
            else
            {
                lsvHotelesAgregados.SelectedItems[0].Remove();
            }
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            lsvHoteles.Items.Clear();
            txtUbicacionHoteles.Clear();
            cmbCalificacionHoteles.SelectedIndex = -1;
            dtpFechaDesdeHoteles.Text = "01/01/2023";
            dtpFechaHastaHoteles.Text = "01/01/2023";
            txtHabitacionesHoteles.Clear();
            HotelesModel model = new HotelesModel();
            foreach (ListViewItem item in model.FormatoHoteles())
            {
                lsvHoteles.Items.Add(item);
            }
        }

        private void btnBuscarHoteles_Click(object sender, EventArgs e)
        {
            string ubicacion = txtUbicacionHoteles.Text;
            string calificacion = cmbCalificacionHoteles.Text;
            string fechaDesde = dtpFechaDesdeHoteles.Text;
            string fechaHasta = dtpFechaHastaHoteles.Text;
            string cantHabitaciones = txtHabitacionesHoteles.Text;
            string errores = ModuloHoteles.ValidarFiltros(ubicacion, calificacion, fechaDesde, fechaHasta, cantHabitaciones);
            if (string.IsNullOrEmpty(errores))
            {
                MessageBox.Show("Todo piola");
            }
            else
            {
                MessageBox.Show(errores, "Error");
            }
        }
    }
}
