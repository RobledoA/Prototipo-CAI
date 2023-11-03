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
    public partial class AgregarClientes : Form
    {
        public AgregarClientes()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombreCliente.Text) && string.IsNullOrWhiteSpace(txtCuilCuit.Text))
            {
                MessageBox.Show("Debe completar al menos un campo.", "Error");
            }
            else if (!string.IsNullOrWhiteSpace(txtCuilCuit.Text) && !int.TryParse(txtCuilCuit.Text, out int salida))
            {
                MessageBox.Show("El cuil/cuit debe ser un número.", "Error");
            }

            else
            {
                MessageBox.Show($"Se ha creado el itinerario correctamente. Su código de itinerario es {1}.", "Itinerario Creado");
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
