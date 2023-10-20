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
    public partial class Hoteles : Form
    {
        public Hoteles()
        {
            InitializeComponent();
        }

        private void Hoteles_Load(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo("hoteles.txt");
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
                lsvHoteles.Items.Add(item);
            }
        }
    }
}