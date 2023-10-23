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
        List<ListViewItem> dataHabitaciones = new List<ListViewItem>();
        List<ListViewItem> dataServExtras = new List<ListViewItem>();
        public Hoteles()
        {
            InitializeComponent();
        }


        private void Hoteles_Load(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo("hoteles.txt");
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
                lsvHoteles.Items.Add(item);
            }

            sr.Close();
        }

        private void btnAgregarHoteles_Click(object sender, EventArgs e)
        {
            if (cbTipoHabitacion.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un producto de la lista.");
            }

            /*if (lsvHoteles.SelectedItems.Count > 0)
            {
                ListViewItem item = new ListViewItem("1010");
                item.SubItems.Add("Hotel");
                item.SubItems.Add("$100045");

                lsvTarifas.Items.Add(item);
            } TODO */
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            Habitaciones habitaciones = new Habitaciones();

            habitaciones.SetDatosHotel(lsvHoteles.SelectedItems[0]);

            if (lsvHoteles.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un producto de la lista.");
            }
            else
            {
                habitaciones.ShowDialog();
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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



        private void lsvHoteles_DoubleClick(object sender, EventArgs e)
        {
            cbTipoHabitacion.Items.Clear();
            dataHabitaciones.Clear();
            clbServExtras.Items.Clear();
            FileInfo fi = new FileInfo("habitaciones.txt");
            StreamReader sr = fi.OpenText();
            while (!sr.EndOfStream)
            {
                string linea = sr.ReadLine();
                string[] vector = linea.Split(';');
                if (vector[0] == lsvHoteles.SelectedItems[0].Text)
                {
                    ListViewItem item = new ListViewItem(vector[0]); //index 0
                    item.SubItems.Add(vector[1]); //index 1
                    item.SubItems.Add(vector[9]); //index 2
                    item.SubItems.Add(vector[3]); //index 3
                    dataHabitaciones.Add(item);
                    cbTipoHabitacion.Items.Add(vector[1]);
                }

            }
            sr.Close();
            cbTipoHabitacion.SelectedIndex = 0;
            FileInfo fi2 = new FileInfo("servExtraHoteles.txt");
            StreamReader sr2 = fi2.OpenText();
            while (!sr2.EndOfStream)
            {
                string linea = sr2.ReadLine();
                string[] vector = linea.Split(';');
                if (vector[0] == lsvHoteles.SelectedItems[0].Text)
                {
                    ListViewItem item = new ListViewItem(vector[0]);
                    item.SubItems.Add(vector[1]);
                    item.SubItems.Add(vector[2]);
                    item.SubItems.Add(vector[3]);
                    dataServExtras.Add(item);
                    clbServExtras.Items.Add(vector[1]);
                }

            }
            sr2.Close();

        }

        private void cbTipoHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem a in dataHabitaciones)
            {
                if (a.SubItems[1].Text == cbTipoHabitacion.Text)
                {
                    lblContadorHabitaciones.Text = a.SubItems[2].Text;
                    cbCantHuespedes.Items.Clear();
                    for (int i = 1; i <= Convert.ToInt32(a.SubItems[3].Text); i++)
                    {
                        cbCantHuespedes.Items.Add(i);
                    }
                    cbCantHuespedes.SelectedIndex = 0;
                }
            }
        }

        private void btnLimpiarCarrito_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Se eliminarán todos los productos del carrito.\n                             ¿Está seguro?","Confirmación",MessageBoxButtons.YesNo); //no borren el espacio es para que se vea bonito
            if (r == DialogResult.Yes)
            {
                lsvTarifas.Items.Clear();
            }
        }
    }
}
