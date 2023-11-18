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
            CrearReservaModel model = new();
            Itinerario itinerarioActivo = model.ObtenerItinerarioActivo();

            foreach (var disp in itinerarioActivo.Disponibilidades)
            {
                Hotel hotel = model.ObtenerInfoHotel(disp.Disponibilidad.CodigoHotel);
                var item = new ItemCheckBox();
                item.Hotel = disp;
                //Crear una descripcion buscando los datos del hotel en el modulo, etc....
                item.Descripcion = $"{hotel.Nombre};{item.Hotel.Disponibilidad.Nombre};Capacidad:{item.Hotel.Disponibilidad.Capacidad};{item.Hotel.Disponibilidad.TarifaDiaria}";
                this.chklbTarifasAsignadas.Items.Add(item);
            }

            foreach (var tarifaVuelo in itinerarioActivo.TarifasVuelos)
            {
                Vuelo vuelo = model.ObtenerInfoVuelo(tarifaVuelo.CodigoVuelo);
                var item = new ItemCheckBox();
                item.Vuelo = tarifaVuelo;
                item.Descripcion = $"{vuelo.CodigoVuelo};{vuelo.Origen};{vuelo.Destino};{tarifaVuelo.Clase};{tarifaVuelo.TipoPasajero};{tarifaVuelo.Precio};";
                this.chklbTarifasAsignadas.Items.Add(item);
            }

        }

        private void txtNombrePasajero_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarPasajero_Click(object sender, EventArgs e)
        {
            CrearReservaModel model = new();
            string nombreApellido = txtNombrePasajero.Text;
            string dni = txtDNIPasajero.Text;
            DateTime fechaNac = dtpNacimientoP.Value.Date;
            string nacionalidad = cmbNacionalidad.Text;
            string genero = cmbGenero.Text;

            string errores = model.ValidarCampos(nombreApellido, dni, fechaNac, nacionalidad, genero);

            if (string.IsNullOrWhiteSpace(errores))
            {
                List<ItemCheckBox> list = new List<ItemCheckBox>();
                foreach (var item in this.chklbTarifasAsignadas.CheckedItems)
                {
                    list.Add((ItemCheckBox)item);
                }
                MessageBox.Show(model.ValidarPasajeroTarifas(list));

                /*model.ValidarPasajeroTarifa(list, nombreApellido, dni, fechaNac, nacionalidad, genero);*/
                MessageBox.Show("Hasta aca llegaste javier");
            }
            else
            {
                MessageBox.Show(errores, "Error");
            }
        }
    }
}
