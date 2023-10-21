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
            /*FileInfo fi = new FileInfo("aereos.txt");
            StreamReader sr = fi.OpenText();
            while (!sr.EndOfStream)
            {
                string linea = sr.ReadLine();
                string[] vector = linea.Split(';');
                ListViewItem item = new ListViewItem(vector[0]);
                item.SubItems.Add(vector[1]);
                item.SubItems.Add(vector[2]);
                item.SubItems.Add(vector[3]);
                item.SubItems.Add(vector[4]);
                item.SubItems.Add(vector[5]);
                item.SubItems.Add(vector[6]);
                item.SubItems.Add(vector[7]);
                item.SubItems.Add(vector[8]);
                lsvAereos.Items.Add(item);
            }

            sr.Close();*/
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDetalles_Click(object sender, EventArgs e)
        {
            Vuelos vuelos = new Vuelos();

            if (lsvAereos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un producto de la lista.");
            }
            else
            {
                vuelos.ShowDialog();
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
        private void button4_Click_1(object sender, EventArgs e)    //Agregar al Carrito
        {
            if (lsvAereos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un producto de la lista.");
            }

            if (lsvAereos.SelectedItems.Count != 0)
            {
                ListViewItem item = new ListViewItem("0912");
                item.SubItems.Add("Aéreo");
                item.SubItems.Add("$650000");

                lsvTarifas.Items.Add(item);
            }
        }
    }
}
