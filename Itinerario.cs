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
    }
}
