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
            string nombreRZ = txtNombreCliente.Text;
            string cuilcuit = txtCuilCuit.Text;
            string errores = AgregarClientesModel.ValidarCampos(nombreRZ, cuilcuit);

            if (string.IsNullOrEmpty(errores))
            {
                MessageBox.Show($"Se ha creado el itinerario correctamente. Su código de itinerario es {1}.", "Itinerario Creado");
            }
            else
            {
                MessageBox.Show(errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Close();

            //Se debería agregar los datos del cliente en la lista del formulario "Itinerario".
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
