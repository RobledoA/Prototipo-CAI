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

        private void btnAgregarItinerarioHoteles_Click(object sender, EventArgs e)
        {

        }

        private void lblItinerarioActivo_Click(object sender, EventArgs e)
        {/*
            Hotel a = HotelesAlmacen.Hoteles[0];
            MessageBox.Show($"{a.CodigoHotel},{a.Calificacion}, {a.CodigoCiudad}, {a.Direccion}, {a.Nombre}");
            foreach (Disponibilidad b in a.Disponibilidades)
            {
                MessageBox.Show($"{b.CodigoDisponibilidad}, {b.CodigoHotel}, {b.Nombre}, {b.Capacidad}, {b.Adultos}, {b.Menores}, {b.Infantes}, {b.TarifaDiaria}");
                foreach (Habitacion c in b.DiasDisponibles)
                {
                    MessageBox.Show($"{c.CodigoDisponibilidad}, {c.Fecha}, {c.HabitacionesDisponibles}");
                }
            }*/
        }
    }
}
