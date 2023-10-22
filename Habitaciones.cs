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
    public partial class Habitaciones : Form
    {
        private ListViewItem hotelData;

        public Habitaciones()
        {
            InitializeComponent();
        }

        private void Habitaciones_Load(object sender, EventArgs e)
        {
            string estrellas = "";
            string codigoHotel = hotelData.SubItems[0].Text;
            lblNombreHotel.Text = Convert.ToString(hotelData.SubItems[1].Text);
            for (int i = 0; i < Convert.ToInt32(hotelData.SubItems[4].Text); i++)
            {
                estrellas += "★";
            }
            lblEstrellas.Text = estrellas;
            lblDireccion.Text = $"{hotelData.SubItems[3].Text} - {hotelData.SubItems[2].Text}";

            FileInfo fi = new FileInfo("habitaciones.txt");
            StreamReader sr = fi.OpenText();
            while (!sr.EndOfStream)
            {
                string linea = sr.ReadLine();
                string[] vector = linea.Split(';');
                if (vector[0] == codigoHotel)
                {
                    ListViewItem item = new ListViewItem(vector[0]);
                    item.SubItems.Add(vector[1]);
                    item.SubItems.Add(vector[2]);
                    item.SubItems.Add(vector[3]);
                }

            }

            sr.Close();

        }

        public void SetDatosHotel(ListViewItem data)
        {
            hotelData = data;
        }

    }
}
