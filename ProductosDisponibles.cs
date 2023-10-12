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
            ListViewItem item = new ListViewItem("0912");
            item.SubItems.Add("Ciudad A");
            item.SubItems.Add("Ciudad B");
            item.SubItems.Add("2");
            item.SubItems.Add("15/10/2023");
            item.SubItems.Add("16/10/2023");
            item.SubItems.Add("2 horas");
            item.SubItems.Add("Aerolínea X");
            item.SubItems.Add("$300");
            item.SubItems.Add("Wi-Fi, Comida");

            lsvProductosDisponibles.Items.Add(item);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            lsvProductosDisponibles.Clear();

            lsvProductosDisponibles.Columns.Add("Código Hotel", 100, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Nombre", 100, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Código Ciudad", 100, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Dirección", 100, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Calificación", 100, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Disponibilidad", 100, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Servicios Extra", 150, HorizontalAlignment.Center);

            ListViewItem item = new ListViewItem("0912");
            item.SubItems.Add("Hotel CAI");
            item.SubItems.Add("REA");
            item.SubItems.Add("Calle Falsa 123");
            item.SubItems.Add("3");
            item.SubItems.Add("18");
            item.SubItems.Add("Wi-Fi, Comida, Spa");

            lsvProductosDisponibles.Items.Add(item);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lsvProductosDisponibles.Clear();

            lsvProductosDisponibles.Columns.Add("Origen", 100, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Destino", 100, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Paradas", 150, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Tarifas", 100, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Fecha de Salida", 100, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Fecha de Llegada", 150, HorizontalAlignment.Center);

            ListViewItem item = new ListViewItem("Argentina");
            item.SubItems.Add("España");
            item.SubItems.Add("Buenos Aires - Barcelona");
            item.SubItems.Add("US$ 1000");
            item.SubItems.Add("10/10/2023");
            item.SubItems.Add("09/12/2023");

            lsvProductosDisponibles.Items.Add(item);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lsvProductosDisponibles.Clear();

            lsvProductosDisponibles.Columns.Add("Código", 100, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Origen", 100, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Destino", 150, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Fecha de Inicio", 100, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Fecha Fin", 100, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Actividades", 150, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Adicionales", 150, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Capacidad Adultos", 150, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Capacidad Menores", 150, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Capacidad Infantes", 150, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Tarifas", 150, HorizontalAlignment.Center);
            lsvProductosDisponibles.Columns.Add("Disponibilidad", 150, HorizontalAlignment.Center);


            ListViewItem item = new ListViewItem("0912");
            item.SubItems.Add("BUE");
            item.SubItems.Add("BAR");
            item.SubItems.Add("10/10/2023");
            item.SubItems.Add("09/12/2023");
            item.SubItems.Add("Fútbol");
            item.SubItems.Add("Stand-Up");
            item.SubItems.Add("20");
            item.SubItems.Add("8");
            item.SubItems.Add("6");
            item.SubItems.Add("US$ 300");
            item.SubItems.Add("56");


            lsvProductosDisponibles.Items.Add(item);
        }

        private void ProductosDisponibles_Load(object sender, EventArgs e)
        {
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

            ListViewItem item = new ListViewItem("0912");
            item.SubItems.Add("Ciudad A");
            item.SubItems.Add("Ciudad B");
            item.SubItems.Add("2");
            item.SubItems.Add("15/10/2023");
            item.SubItems.Add("16/10/2023");
            item.SubItems.Add("2 horas");
            item.SubItems.Add("Aerolínea X");
            item.SubItems.Add("$300");
            item.SubItems.Add("Wi-Fi, Comida");

            lsvProductosDisponibles.Items.Add(item);

            button1.Select();
        }


    }
}
