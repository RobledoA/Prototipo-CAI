using System.IO;
using System.Windows.Forms;

namespace Prototipo_CAI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            subpaneles();
            Size = new System.Drawing.Size(373, 365);
        }

        private void subpaneles()
        {
            panelSubmenu.Visible = false;
        }

        private void esconderSubpaneles()
        {
            if (panelSubmenu.Visible == true)
            {
                panelSubmenu.Visible = false;
            }
        }

        private void mostrarSubpaneles(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                Size = new System.Drawing.Size(373, 365);
                submenu.Visible = true;
            }
        }

        private void iconbtnItinerario_Click(object sender, EventArgs e)
        {
            Itinerarios itinerario = new();
            itinerario.ShowDialog();
        }

        private void iconbtnProductosDisponibles_Click(object sender, EventArgs e)
        {
            mostrarSubpaneles(panelSubmenu);
            ProductosDisponibles productosDisponibles = new();
            productosDisponibles.ShowDialog();
        }

        private void iconbtnReservas_Click(object sender, EventArgs e)
        {
            Reservas reservas = new();
            reservas.ShowDialog();
        }

        private void panelMenuPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}