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
            // Limpia las columnas existentes si las hay
            lsvProductosDisponibles.Clear();

            // Configura las columnas con su texto de encabezado y alineación
            lsvProductosDisponibles.Columns.Add("Código", 100, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Origen", 100, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Destino", 100, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Paradas", 100, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Fecha de Salida", 100, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Fecha de Arribo", 100, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Tiempo de Vuelo", 100, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Aerolínea", 100, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Tarifas", 100, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Servicios Extra", 100, HorizontalAlignment.Center);

            // Agrega datos a las filas
            ListViewItem item = new ListViewItem("");
            item.SubItems.Add("Ciudad A");
            item.SubItems.Add("Ciudad B");
            item.SubItems.Add("2");
            item.SubItems.Add("2023-10-15");
            item.SubItems.Add("2023-10-16");
            item.SubItems.Add("2 horas");
            item.SubItems.Add("Aerolínea X");
            item.SubItems.Add("$300");
            item.SubItems.Add("Wi-Fi, Comida");

            lsvProductosDisponibles.Items.Add(item);


        }
    }
}
