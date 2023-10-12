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
    public partial class Reservas : Form
    {
        public Reservas()
        {
            InitializeComponent();
        }

        private void Reservas_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscarReserva_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarReserva(txtBuscarReserva.Text);
                
            }
        }

        public void BuscarReserva(string codReserva)
        {
            // TO DO
            MessageBox.Show(codReserva);
            
        }

        private void btnBuscarReserva_Click(object sender, EventArgs e)
        {
            BuscarReserva(txtBuscarReserva.Text);
        }
    }
}
