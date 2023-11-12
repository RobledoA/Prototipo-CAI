using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prototipo_CAI
{
    public partial class Reservas : Form
    {
        public Reservas()
        {
            InitializeComponent();
        }

        private void Reservas_Load(object sender, EventArgs e)
        {
            ReservasModel model = new ReservasModel();
            foreach (ListViewItem item in model.FormatoReservas())
            {
                lsvReservas.Items.Add(item);
            }
        }

        private void txtBuscarReserva_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarReserva(txtBuscarReserva.Text);

            }
        }

        public void BuscarReserva(string codReserva)
        {
            // TO DO
            MessageBox.Show(codReserva);

        }

        private void btnBuscarReserva_Click(object sender, EventArgs e)
        {
            BuscarReserva(txtBuscarReserva.Text);
        }

        private void btnConfirmarReserva_Click(object sender, EventArgs e)
        {
            if (lsvReservas.SelectedItems.Count > 0)
            {
     
                int indiceSeleccionado = lsvReservas.SelectedItems[0].Index;

           
                List<Reserva> listReservas = ModuloReservas.CargarListaReservas();

            
                if (indiceSeleccionado >= 0 && indiceSeleccionado < listReservas.Count)
                {
                   
                    listReservas[indiceSeleccionado].EstadoReserva = "Confirmado";

      
                    ReservasAlmacen.Grabar();

                 
                    ActualizarListView();
                }
                else
                {
                    MessageBox.Show("Seleccione una reserva válida.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una reserva antes de confirmar.");
            }
        

    }
        private void ActualizarListView()
        {
          
            lsvReservas.Items.Clear();

           
            ReservasModel model = new ReservasModel();
            foreach (ListViewItem item in model.FormatoReservas())
            {
                lsvReservas.Items.Add(item);
            }
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            if (lsvReservas.SelectedItems.Count > 0)
            {
                
                int indiceSeleccionado = lsvReservas.SelectedItems[0].Index;

                
                List<Reserva> listReservas = ModuloReservas.CargarListaReservas();

               
                if (indiceSeleccionado >= 0 && indiceSeleccionado < listReservas.Count)
                {
                    
                    listReservas[indiceSeleccionado].EstadoReserva = "Cancelado";

                 
                    ReservasAlmacen.Grabar();

                    ActualizarListView();
                }
                else
                {
                    MessageBox.Show("Seleccione una reserva válida.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una reserva antes de confirmar.");
            }
        }
    }
}
