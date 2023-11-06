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
    public partial class Aereos : Form
    {
        public Aereos()
        {
            InitializeComponent();
        }

        private void Aereos_Load(object sender, EventArgs e)
        {
            /*FileInfo fi = new FileInfo("aereos.txt");
            StreamReader sr = fi.OpenText();
            while (!sr.EndOfStream)
            {
                string linea = sr.ReadLine();
                string[] vector = linea.Split(';');
                ListViewItem item = new ListViewItem(vector[0]);
                item.SubItems.Add(vector[1]);
                item.SubItems.Add(vector[2]);
                item.SubItems.Add(vector[3]);
                item.SubItems.Add(vector[4]);
                item.SubItems.Add(vector[5]);
                item.SubItems.Add(vector[6]);
                item.SubItems.Add(vector[7]);
                item.SubItems.Add(vector[8]);
                lsvAereos.Items.Add(item);
            }

            sr.Close();*/

            //dtpFechaVueltaAereos.Enabled = false;
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grpAgregarVuelos_Enter(object sender, EventArgs e)
        {

        }
        private void grpAgregarHoteles_Enter(object sender, EventArgs e)
        {

        }

        private void txtDestino_TextChanged(object sender, EventArgs e)
        {

        }

        private void lsvAereos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
