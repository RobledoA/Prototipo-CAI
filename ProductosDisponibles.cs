﻿using System;
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
            lsvProductosDisponibles.Columns.Add("Código", -2, HorizontalAlignment.Center);
        }
    }
}
