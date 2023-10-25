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
    public partial class CrearReserva : Form
    {
        public CrearReserva()
        {
            InitializeComponent();
        }

        private void btnAgregarPasajero_Click(object sender, EventArgs e)
        {
            DatosPasajeros datosPasajeros = new DatosPasajeros();
            datosPasajeros.ShowDialog();

        }

        private void lsvGenerarReserva_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CrearReserva_Load(object sender, EventArgs e)
        {
            lsvGenerarReserva.View = View.Details;
            lsvGenerarReserva.FullRowSelect = true;
            string rutaArchivo = "reservaCreada.txt";

            try
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    string headerLine = sr.ReadLine();
                    string[] columnNames = headerLine.Split(';');

                    // Configurar las columnas del ListView
                    foreach (string columnName in columnNames)
                    {
                        lsvGenerarReserva.Columns.Add(columnName, 150);
                    }

                    string dataLine;
                    while ((dataLine = sr.ReadLine()) != null)
                    {
                        string[] values = dataLine.Split(';');

                        if (values.Length == columnNames.Length)
                        {
                            ListViewItem item = new ListViewItem(values[0]);
                            for (int i = 1; i < values.Length; i++)
                            {
                                item.SubItems.Add(values[i]);
                            }
                            lsvGenerarReserva.Items.Add(item);
                        }
                    }

                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Ajustes del menú contextual. No le encontré la vuelta para que funcione el eliminar 
        private void lsvGenerarReserva_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ListViewHitTestInfo hitTest = lsvGenerarReserva.HitTest(e.Location);

                if (hitTest.Item != null)
                {
                    // Mostrar el menú contextual solo si se hace clic izquierdo en una fila
                    lsvGenerarReserva.SelectedItems.Clear();
                    hitTest.Item.Selected = true;
                    contextMenuStrip1.Show(lsvGenerarReserva, e.Location);
                    if (lsvGenerarReserva.SelectedItems.Count > 0)
                    {
                        ListViewItem item = lsvGenerarReserva.SelectedItems[0];
                        lsvGenerarReserva.Items.Remove(item);

                    }

                }


            }

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            string rutaArchivo = "reservaCreada.txt";

            // Estp borra todos los elementos actuales en la lsv para no duplicarlos
            lsvGenerarReserva.Items.Clear();

            //Carga del archivo de texto
            try
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    string headerLine = sr.ReadLine();
                    string[] columnNames = headerLine.Split(';');


                    foreach (string columnName in columnNames)
                    {

                    }

                    string dataLine;
                    while ((dataLine = sr.ReadLine()) != null)
                    {
                        string[] values = dataLine.Split(';');

                        if (values.Length == columnNames.Length)
                        {
                            ListViewItem item = new ListViewItem(values[0]); // Primer valor
                            for (int i = 1; i < values.Length; i++)
                            {
                                item.SubItems.Add(values[i]); // Resto de los valores
                            }
                            lsvGenerarReserva.Items.Add(item);
                        }
                    }

                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnConfirmarGuardarReserva_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarGenerarReserva_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
