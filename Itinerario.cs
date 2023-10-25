using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Prototipo_CAI
{
    public partial class Itinerario : Form
    {
        public Itinerario()
        {
            InitializeComponent();
            lsvItinerario.SelectedIndexChanged += lsvItinerario_SelectedIndexChanged;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Itinerario_Load(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo("itinerario.txt");
            StreamReader sr = fi.OpenText();
            while (!sr.EndOfStream)
            {
                string linea = sr.ReadLine();
                string[] vector = linea.Split(';');
                ListViewItem item = new ListViewItem(vector[0]);
                item.SubItems.Add(vector[1]);
                item.SubItems.Add(vector[2]);
                lsvItinerario.Items.Add(item);
            }

            sr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lsvItinerario.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvItinerario.SelectedItems[0];
                lsvItinerario.Items.Remove(item);
            }
        }


        /*Esto se puede mejorar con una función y llamar a la función directamente esto es una gronchada. También se puede agregar la función de 
        presionar enter y buscar*/
        private void btnBuscarItinerario_Click(object sender, EventArgs e)
        {

            string idItinerario = txtBuscarItinerario.Text;

            if (!string.IsNullOrWhiteSpace(idItinerario))
            {
                //lsvItinerario.SelectedItems.Clear();  pa que sirve esto

                foreach (ListViewItem item in lsvItinerario.Items)
                {
                    string idElemento = item.Text;
                    string cuit = item.SubItems[0].Text;
                    string razonsocial = item.SubItems[1].Text;

                    //Equals sirve para comprar dos cosas y ver si son iguales en este caso lo ingresado en el txtbox con lo que está en la lsv
                    if (idElemento.Equals(idItinerario, StringComparison.OrdinalIgnoreCase))
                    {

                        lsvItinerario.Items.Clear();

                        lsvItinerario.Items.Add(item);

                    }
                    if (cuit.Equals(idItinerario, StringComparison.OrdinalIgnoreCase))
                    {
                        lsvItinerario.Items.Clear();

                        lsvItinerario.Items.Add(item);
                    }
                    if (razonsocial.Equals(idItinerario, StringComparison.OrdinalIgnoreCase))
                    {
                        lsvItinerario.Items.Clear();

                        lsvItinerario.Items.Add(item);
                    }
                }
            }

            else
            {
                lsvItinerario.Items.Clear();
                FileInfo fi = new FileInfo("itinerario.txt");
                StreamReader sr = fi.OpenText();
                while (!sr.EndOfStream)
                {
                    string linea = sr.ReadLine();
                    string[] vector = linea.Split(';');
                    ListViewItem item = new ListViewItem(vector[0]);
                    item.SubItems.Add(vector[1]);
                    item.SubItems.Add(vector[2]);
                    lsvItinerario.Items.Add(item);

                }

                sr.Close();
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lsvItinerario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearReserva_Click(object sender, EventArgs e)
        {

            if(lsvItinerario.SelectedItems.Count > 0)
            {
                CrearReserva crearReserva = new CrearReserva();

                crearReserva.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un itinerario");
            }

        }
    }
}
