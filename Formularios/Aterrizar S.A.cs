using System.IO;
using System.Windows.Forms;

namespace Prototipo_CAI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProdDisponibles_Click(object sender, EventArgs e)
        {
            ProductosDisponibles productosDisponibles = new();
            productosDisponibles.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnItinerarios_Click(object sender, EventArgs e)
        {
            Itinerarios itinerario = new();
            itinerario.ShowDialog();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            Reservas reservas = new();
            reservas.ShowDialog();
        }

    }

}