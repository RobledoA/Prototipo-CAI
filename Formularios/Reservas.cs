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

        private void txtBuscarReserva_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarReserva(txtBuscarReserva.Text);

            }
        }
        private void btnBuscarReserva_Click(object sender, EventArgs e)
        {
            BuscarReserva(txtBuscarReserva.Text);
        }

        private void btnConfirmarReserva_Click(object sender, EventArgs e)
        {
            ConfirmarReserva();
        }
        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            CancelarReservas();
        }



        //procedimientos que responden al formulario
        private void Reservas_Load(object sender, EventArgs e)
        {
            ReservasModel model = new ReservasModel();
            foreach (ListViewItem item in model.FormatoReservas())
            {
                lsvReservas.Items.Add(item);
            }
        }

        private void ConfirmarReserva()
        {
            if (lsvReservas.SelectedItems.Count > 0)
            {
                int indiceSeleccionado = lsvReservas.SelectedItems[0].Index;

                List<Reserva> listReservas = ModuloReservas.CargarListaReservas();

                if (indiceSeleccionado >= 0 && indiceSeleccionado < listReservas.Count)
                {
                    Reserva reservaSeleccionada = listReservas[indiceSeleccionado];
                    if (reservaSeleccionada.EstadoReserva.Equals("Cancelado", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Esta reserva está cancelada y no se puede confirmar.");
                    }
                    else if (reservaSeleccionada.EstadoReserva.Equals("Confirmado", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Esta reserva ya ha sido confirmada.");
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea confirmar esta reserva?", "Confirmar Reserva", MessageBoxButtons.YesNoCancel);

                        if (result == DialogResult.Yes)
                        {
                            reservaSeleccionada.EstadoReserva = "Confirmado";

                            ReservasAlmacen.Grabar();
                            ActualizarListView();
                        }

                    }
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



        private void CancelarReservas()
        {

            if (lsvReservas.SelectedItems.Count > 0)
            {
                int indiceSeleccionado = lsvReservas.SelectedItems[0].Index;
                List<Reserva> listReservas = ModuloReservas.CargarListaReservas();
                if (indiceSeleccionado >= 0 && indiceSeleccionado < listReservas.Count)
                {
                    Reserva reservaSeleccionada = listReservas[indiceSeleccionado];
                    if (reservaSeleccionada.EstadoReserva.Equals("Cancelado", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Esta reserva ya ha sido cancelada.");
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea cancelar esta reserva?", "Confirmar Reserva", MessageBoxButtons.YesNoCancel);
                        if (result == DialogResult.Yes)
                        {

                            reservaSeleccionada.EstadoReserva = "Cancelado";
                            ReservasAlmacen.Grabar();
                            ActualizarListView();
                        }
                        else if (result == DialogResult.No)
                        {

                        }
                        else
                        {

                        }
                    }
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

        private void CambiarEstadoReserva(ListViewItem item)
        {
            // Cambiar el estado de la reserva
            if (item.SubItems.Count > 3 && item.SubItems[3].Text == "Confirmado")
            {
                item.SubItems[3].Text = "Cancelado";
            }
            else if (item.SubItems.Count > 3 && item.SubItems[3].Text == "Cancelado")
            {
                item.SubItems[3].Text = "Confirmado";
            }

            // Guardar los cambios
            ReservasAlmacen.Grabar();

            // Actualizar el ListView
            ActualizarListView();
        }


        public void BuscarReserva(string codReserva)
        {
            ReservasModel model = new ReservasModel();
            List<ListViewItem> reservas = model.FormatoReservas();

            if (string.IsNullOrWhiteSpace(codReserva))
            {
                lsvReservas.Items.Clear();
                lsvReservas.Items.AddRange(reservas.ToArray());
            }
            else
            {
                bool reservaEncontrada = false;
                foreach (ListViewItem item in reservas)
                {
                    if (item.SubItems.Count > 0 && item.SubItems[0].Text == codReserva)
                    {
                        lsvReservas.Items.Clear();
                        lsvReservas.Items.Add(item);

                        string estadoActual = item.SubItems[3].Text;
                        MessageBox.Show("Estado actual de la reserva: " + estadoActual);

                        DialogResult result = MessageBox.Show("¿Desea cambiar el estado de esta reserva?", "Cambiar Estado", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            CambiarEstadoReserva(item);
                        }

                        reservaEncontrada = true;
                        break;
                    }
                }

                if (!reservaEncontrada)
                {
                    MessageBox.Show("No se encontró ninguna reserva con el código: " + codReserva);
                }
            }

        }
    }
}
