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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Prototipo_CAI
{
    public partial class DatosPasajeros : Form
    {
        public DatosPasajeros()
        {
            InitializeComponent();
        }

        private void DatosPasajeros_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void btnConfirmarGuardarReserva_Click(object sender, EventArgs e)
        {
            string nombre = txtNombrep.Text;
            string cuit = txtCuitP.Text;
            string pasaporte = txtPasaporteP.Text;
            DateTime FechaNacimiento = dtpNacimientoP.Value;
            string Nacionalidad = cmbNacionalidad.SelectedItem.ToString();
            string Genero = cmbGénero.SelectedItem.ToString();

            string rutaArchivo = "reservaCreada.txt";

            try
            {
                using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                {
                    // Verificar si el archivo está vacío
                    if (new FileInfo(rutaArchivo).Length == 0)
                    {
                        // Si el archivo está vacío, escribir la fila de encabezado
                        sw.WriteLine($"Código;Nombre;Cuit;Pasaporte;Fecha de Nacimiento;Nacionalidad;Género;");
                    }

                    // Escribir los datos del pasajero
                    sw.WriteLine($"-;{nombre};{cuit};{pasaporte};{FechaNacimiento.ToString("dd-MM-yyyy")};{Nacionalidad};{Genero};");

                    sw.Close();
                }

                MessageBox.Show("Reserva Creada Exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void btnCancelarGenerarReserva_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
