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
    public partial class ProductosDisponibles : Form
    {
        public ProductosDisponibles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lsvProductosDisponibles.Clear();
            lsvProductosDisponibles.Columns.Add("Código", -2, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Origen", -2, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Destino", -2, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Paradas", -2, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Fecha de Salida", -2, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Fecha de Arribo", -2, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Tiempo de Vuelo", -2, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Aerolínea", -2, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Tarifas", -2, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Servicios Extra", -2, HorizontalAlignment.Center);
            

        }
    }
}
