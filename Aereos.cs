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
    public partial class Aereos : Form
    {
        public Aereos()
        {
            InitializeComponent();
        }

        private void Aereos_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void grpProdcutos_Enter(object sender, EventArgs e)
        {

        }
        private void btnDetalles_Click(object sender, EventArgs e)
        {
            Vuelos vuelos = new Vuelos();
            Habitaciones habitaciones = new Habitaciones();

            if (lsvProductosDisponibles.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un producto de la lista.");
            }
        }
        private void btnCrearItinerario_Click(object sender, EventArgs e)
        {
            if (lsvTarifas.Items.Count == 0)
            {
                MessageBox.Show("El carrito de productos no puede estar vacío.");
            }
            //Hay que ver a que pantalla te lleva este boton.
            //Por ahora lo dejamos así:
            else
            {
                Itinerario itinerario = new Itinerario();
                itinerario.ShowDialog();
            }
        }
        private void chkIdaVuelta_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIdaVuelta.Checked == true)
            {
                dtpFechaVuelta.Enabled = true;
            }

            if (chkIdaVuelta.Checked == false)
            {
                dtpFechaVuelta.Enabled = false;
            }
        }
        private void grpAgregarVuelos_Enter(object sender, EventArgs e)
        {

        }
        private void grpAgregarHoteles_Enter(object sender, EventArgs e)
        {

        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (lsvProductosDisponibles.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un producto de la lista.");
            }

            if (lsvProductosDisponibles.SelectedItems.Count != 0)
            {
                ListViewItem item = new ListViewItem("0912");
                item.SubItems.Add("Aéreo");
                item.SubItems.Add("$650000");

                lsvTarifas.Items.Add(item);
            }
        }
        private void btnAgregarHoteles_Click_1(object sender, EventArgs e)
        {
            if (lsvProductosDisponibles.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un producto de la lista.");
            }

            if (lsvProductosDisponibles.SelectedItems.Count > 0)
            {
                ListViewItem item = new ListViewItem("1010");
                item.SubItems.Add("Hotel");
                item.SubItems.Add("$100045");

                lsvTarifas.Items.Add(item);
            }
        }


    }
}
