﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prototipo_CAI
{
    public partial class Reservas : Form
    {
        public Reservas()
        {
            InitializeComponent();
        }

        private void txtBuscarReserva_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarReserva(txtBuscarReserva.Text);
            }
        }

        private void btnConfirmarReserva_Click(object sender, EventArgs e)
        {
            ModuloReservas.ConfirmarReserva(lsvReservas);
        }
        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            ModuloReservas.CancelarReservas(lsvReservas);
        }

        //procedimientos que responden al formulario
        private void Reservas_Load(object sender, EventArgs e)
        {
            ReservasModel.Actualizar(lsvReservas);
        }

        private void BuscarReserva(string codReserva)
        {
            ReservasModel.BuscarReserva(lsvReservas, codReserva);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ReservasModel.Actualizar(lsvReservas);
        }

        private void lsvReservas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconbtnBuscarItinerario_Click(object sender, EventArgs e)
        {
            BuscarReserva(txtBuscarReserva.Text);
        }

        private void iconbtnRefrescaBuscarReserva_Click_1(object sender, EventArgs e)
        {
            ReservasModel.Actualizar(lsvReservas);
        }
    }
}