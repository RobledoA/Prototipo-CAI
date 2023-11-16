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
    public partial class CrearReserva : Form
    {
        CrearReservaModel model = new CrearReservaModel();
        public CrearReserva()
        {
            InitializeComponent();
        }

        private void CrearReserva_Load(object sender, EventArgs e)
        {

        }

        private void txtNombrePasajero_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarPasajero_Click(object sender, EventArgs e)
        {
            string nombreApellido = txtNombrePasajero.Text;
            string dni = txtDNIPasajero.Text;
            DateTime fechaNac = dtpNacimientoP.Value.Date;
            string nacionalidad = cmbNacionalidad.Text;
            string genero = cmbGenero.Text;

            string errores = model.ValidarCampos(nombreApellido, dni, fechaNac, nacionalidad, genero);

            if(string.IsNullOrWhiteSpace(errores))
            {
                
            }
            else
            {
                MessageBox.Show(errores, "Error");
            }
        }
    }
}
